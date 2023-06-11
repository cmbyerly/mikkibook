using MikkiBookWF.Context;
using MikkiBookWF.DataModel;
using MikkiBookWF.UIClasses;

namespace MikkiBookWF
{
    /// <summary>
    ///   Form1
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>The database context</summary>
        private AccountContext? dbContext;

        /// <summary>The current identifier</summary>
        private long currentId = 0;

        /// <summary>The transaction list</summary>
        private List<AccountTransaction> transactionList = new List<AccountTransaction>();

        /// <summary>Initializes a new instance of the <see cref="Form1" /> class.</summary>
        public Form1()
        {
            InitializeComponent();

            this.gvAccount.Columns["Amount"].DefaultCellStyle.Format = "c";
            this.gvAccount.Columns["TransactionDate"].DefaultCellStyle.Format = "d";
            this.gvAccount.Columns["ReconciliationDate"].DefaultCellStyle.Format = "d";
        }

        /// <summary>Handles the Click event of the btnSave control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ttype = ((TransactionTypes)cmbTransType.SelectedItem);

                if (currentId == 0)
                {
                    AccountTransaction accountTransaction = new AccountTransaction(
                        0,
                        txtDescription.Text,
                        ttype.TransactionTypeCode,
                        dtTransDate.Value,
                        chkReconciled.Checked ? dtRecDate.Value : null,
                        ttype.IsCredit ? Math.Abs(Convert.ToDecimal(txtAmount.Text)) : Math.Abs(Convert.ToDecimal(txtAmount.Text)) * -1,
                        txtCheckNum.Text);

                    dbContext.AccountTransactions.Add(accountTransaction);
                    dbContext.SaveChanges();
                }
                else
                {
                    AccountTransaction accountTransaction = dbContext.AccountTransactions.First(x => x.Id == currentId);
                    accountTransaction.TransactionDate = dtTransDate.Value;
                    accountTransaction.TransType = ttype.TransactionTypeCode;
                    accountTransaction.CheckNumber = txtCheckNum.Text;
                    accountTransaction.Amount = ttype.IsCredit ? Math.Abs(Convert.ToDecimal(txtAmount.Text)) : Math.Abs(Convert.ToDecimal(txtAmount.Text)) * -1;
                    accountTransaction.ReconciliationDate = chkReconciled.Checked ? dtRecDate.Value : null;
                    accountTransaction.Description = txtDescription.Text;

                    dbContext.AccountTransactions.Update(accountTransaction);
                    dbContext.SaveChanges();
                }

                this.currentId = 0;
                txtAmount.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtCheckNum.Text = string.Empty;
                dtRecDate.Value = DateTime.Now;
                dtTransDate.Value = DateTime.Now;
                chkReconciled.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.bwRebuildTransList.RunWorkerAsync();
        }

        /// <summary>Handles the Load event of the Form1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbContext = new AccountContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.bwRebuildTransList.RunWorkerAsync();

            this.cmbTransType.Items.AddRange(TransactionTypes.GetTransactionTypes());
        }

        /// <summary>Handles the Click event of the btnNew control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.currentId = 0;
                txtAmount.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtCheckNum.Text = string.Empty;
                dtRecDate.Value = DateTime.Now;
                dtTransDate.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>Handles the DoWork event of the bwRebuildTransList control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs" /> instance containing the event data.</param>
        private void bwRebuildTransList_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                this.gvAccount.Invoke(() =>
                {
                    this.transactionList.Clear();
                });

                decimal balance = 0.00M;

                var tempContext = new AccountContext();
                tempContext.Database.EnsureCreated();
                foreach (var trans in tempContext.AccountTransactions.ToList())
                {
                    balance = balance + trans.Amount;

                    this.gvAccount.Invoke(() =>
                    {
                        this.transactionList.Add((AccountTransaction)trans.Clone());
                    });
                }

                this.lblBalance.Invoke(() =>
                {
                    lblBalance.Text = $"${balance}";
                });

                this.gvAccount.Invoke(() =>
                {
                    this.gvAccount.DataSource = this.transactionList;
                    this.gvAccount.Refresh();
                });

                tempContext.Dispose();
                tempContext = null;

                btnDelete.Enabled = false;
            }
            catch { }
        }

        /// <summary>Handles the FormClosing event of the Form1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs" /> instance containing the event data.</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        /// <summary>Handles the Click event of the btnDelete control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                AccountTransaction accountTransaction = dbContext.AccountTransactions.First(x => x.Id == currentId);
                this.dbContext.AccountTransactions.Remove(accountTransaction);
                this.dbContext.SaveChanges();

                this.currentId = 0;
                txtAmount.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtCheckNum.Text = string.Empty;
                dtRecDate.Value = DateTime.Now;
                dtTransDate.Value = DateTime.Now;

                this.bwRebuildTransList.RunWorkerAsync();

                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>Handles the CellClick event of the gvAccount control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs" /> instance containing the event data.</param>
        private void gvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>Handles the RowEnter event of the gvAccount control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs" /> instance containing the event data.</param>
        private void gvAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var item = (AccountTransaction)this.gvAccount.Rows[e.RowIndex].DataBoundItem;

                this.currentId = item.Id;
                txtAmount.Text = Math.Abs(item.Amount).ToString("N2");
                txtDescription.Text = item.Description;
                txtCheckNum.Text = item.CheckNumber;
                dtRecDate.Value = item.ReconciliationDate == null ? new DateTime(1754, 1, 1) : (DateTime)item.ReconciliationDate;
                chkReconciled.Checked = item.ReconciliationDate == null ? false : true;
                dtTransDate.Value = item.TransactionDate;

                for (int i = 0; i < this.cmbTransType.Items.Count; i++)
                {
                    var ttype = (TransactionTypes)this.cmbTransType.Items[i];

                    if (ttype.TransactionTypeCode == item.TransType)
                    {
                        this.cmbTransType.SelectedIndex = i;
                    }
                }

                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMikkiBook aboutMikkiBook = new AboutMikkiBook();
            aboutMikkiBook.ShowDialog();
        }
    }
}