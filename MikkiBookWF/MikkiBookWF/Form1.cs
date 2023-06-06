using MikkiBookWF.Context;
using MikkiBookWF.DataModel;
using MikkiBookWF.UIClasses;

namespace MikkiBookWF
{
    public partial class Form1 : Form
    {
        private AccountContext? dbContext;
        private long currentId = 0;

        public Form1()
        {
            InitializeComponent();
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.bwRebuildTransList.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbContext = new AccountContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.bwRebuildTransList.RunWorkerAsync();

            this.cmbTransType.Items.AddRange(TransactionTypes.GetTransactionTypes());
        }

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

        private void bwRebuildTransList_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                this.lstTrans.Invoke(() =>
                {
                    this.lstTrans.Items.Clear();
                });

                decimal balance = 0.00M;

                var tempContext = new AccountContext();
                tempContext.Database.EnsureCreated();
                foreach (var trans in tempContext.AccountTransactions.ToList())
                {
                    balance = balance + trans.Amount;

                    this.lstTrans.Invoke(() =>
                    {
                        this.lstTrans.Items.Add(trans.Clone());
                    });
                }

                this.lblBalance.Invoke(() =>
                {
                    lblBalance.Text = $"${balance}";
                });

                tempContext.Dispose();
                tempContext = null;

                btnDelete.Enabled = false;
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void lstTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var item = (AccountTransaction)this.lstTrans.SelectedItem;

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
    }
}