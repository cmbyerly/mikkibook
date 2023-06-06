namespace MikkiBookWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            chkReconciled = new CheckBox();
            btnNew = new Button();
            txtCheckNum = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            txtAmount = new TextBox();
            dtRecDate = new DateTimePicker();
            cmbTransType = new ComboBox();
            dtTransDate = new DateTimePicker();
            txtDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            lstTrans = new ListBox();
            bwRebuildTransList = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            lblBalance = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkReconciled);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(txtCheckNum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(dtRecDate);
            groupBox1.Controls.Add(cmbTransType);
            groupBox1.Controls.Add(dtTransDate);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entry";
            // 
            // chkReconciled
            // 
            chkReconciled.AutoSize = true;
            chkReconciled.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkReconciled.Location = new Point(285, 153);
            chkReconciled.Name = "chkReconciled";
            chkReconciled.Size = new Size(113, 19);
            chkReconciled.TabIndex = 15;
            chkReconciled.Text = "Is In Bank Record";
            chkReconciled.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(236, 301);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(224, 23);
            btnNew.TabIndex = 14;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtCheckNum
            // 
            txtCheckNum.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCheckNum.Location = new Point(79, 247);
            txtCheckNum.Name = "txtCheckNum";
            txtCheckNum.Size = new Size(200, 21);
            txtCheckNum.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 250);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 12;
            label6.Text = "Check Num";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(6, 301);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(224, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(79, 200);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(381, 21);
            txtAmount.TabIndex = 9;
            // 
            // dtRecDate
            // 
            dtRecDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtRecDate.Location = new Point(79, 150);
            dtRecDate.Name = "dtRecDate";
            dtRecDate.Size = new Size(200, 21);
            dtRecDate.TabIndex = 8;
            // 
            // cmbTransType
            // 
            cmbTransType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransType.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTransType.FormattingEnabled = true;
            cmbTransType.Location = new Point(79, 110);
            cmbTransType.Name = "cmbTransType";
            cmbTransType.Size = new Size(200, 23);
            cmbTransType.TabIndex = 7;
            // 
            // dtTransDate
            // 
            dtTransDate.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtTransDate.Location = new Point(79, 65);
            dtTransDate.Name = "dtTransDate";
            dtTransDate.Size = new Size(200, 21);
            dtTransDate.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(79, 29);
            txtDescription.MaxLength = 100;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(381, 21);
            txtDescription.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 203);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Rec Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Trans Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Trans Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(484, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(664, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstTrans
            // 
            lstTrans.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTrans.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lstTrans.FormattingEnabled = true;
            lstTrans.ItemHeight = 15;
            lstTrans.Location = new Point(484, 36);
            lstTrans.Name = "lstTrans";
            lstTrans.Size = new Size(664, 559);
            lstTrans.TabIndex = 1;
            lstTrans.SelectedIndexChanged += lstTrans_SelectedIndexChanged;
            // 
            // bwRebuildTransList
            // 
            bwRebuildTransList.DoWork += bwRebuildTransList_DoWork;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBalance);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 396);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Balance";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(6, 34);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(71, 36);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 616);
            Controls.Add(groupBox2);
            Controls.Add(lstTrans);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Mikki Book";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private ListBox lstTrans;
        private TextBox txtAmount;
        private DateTimePicker dtRecDate;
        private ComboBox cmbTransType;
        private DateTimePicker dtTransDate;
        private TextBox txtDescription;
        private Label label5;
        private Button btnSave;
        private Button btnDelete;
        private System.ComponentModel.BackgroundWorker bwRebuildTransList;
        private TextBox txtCheckNum;
        private Label label6;
        private GroupBox groupBox2;
        private Label lblBalance;
        private Button btnNew;
        private CheckBox chkReconciled;
    }
}