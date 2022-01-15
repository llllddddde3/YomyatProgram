
namespace YomyatProgram.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.grdAccounting = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioDaily = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioYearly = new System.Windows.Forms.RadioButton();
            this.radioMonthly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumPayments = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumReceipts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNetProfit = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuIteManage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddAgency = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddPackage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItePayment = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuIteRecipts = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPayOffDebts = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddRecipts = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuIteItems = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddPost = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGrantPackage = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounting)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdAccounting
            // 
            this.grdAccounting.AllowUserToAddRows = false;
            this.grdAccounting.AllowUserToDeleteRows = false;
            this.grdAccounting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdAccounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAccounting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccounting.Location = new System.Drawing.Point(261, 80);
            this.grdAccounting.Name = "grdAccounting";
            this.grdAccounting.ReadOnly = true;
            this.grdAccounting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdAccounting.RowTemplate.Height = 25;
            this.grdAccounting.Size = new System.Drawing.Size(640, 323);
            this.grdAccounting.TabIndex = 1;
            this.grdAccounting.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccounting_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // radioDaily
            // 
            this.radioDaily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioDaily.AutoSize = true;
            this.radioDaily.Checked = true;
            this.radioDaily.Location = new System.Drawing.Point(125, 17);
            this.radioDaily.Name = "radioDaily";
            this.radioDaily.Size = new System.Drawing.Size(52, 19);
            this.radioDaily.TabIndex = 3;
            this.radioDaily.TabStop = true;
            this.radioDaily.Text = "يومي";
            this.radioDaily.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioYearly);
            this.groupBox1.Controls.Add(this.radioMonthly);
            this.groupBox1.Controls.Add(this.radioDaily);
            this.groupBox1.Location = new System.Drawing.Point(626, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(196, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فلترة حسب";
            // 
            // radioYearly
            // 
            this.radioYearly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioYearly.AutoSize = true;
            this.radioYearly.Location = new System.Drawing.Point(9, 17);
            this.radioYearly.Name = "radioYearly";
            this.radioYearly.Size = new System.Drawing.Size(54, 19);
            this.radioYearly.TabIndex = 5;
            this.radioYearly.Text = "سنوي";
            this.radioYearly.UseVisualStyleBackColor = true;
            // 
            // radioMonthly
            // 
            this.radioMonthly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioMonthly.AutoSize = true;
            this.radioMonthly.Location = new System.Drawing.Point(67, 17);
            this.radioMonthly.Name = "radioMonthly";
            this.radioMonthly.Size = new System.Drawing.Size(54, 19);
            this.radioMonthly.TabIndex = 4;
            this.radioMonthly.Text = "شهري";
            this.radioMonthly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "التاريخ";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(279, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 154);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "مجموع المدفوعات";
            // 
            // txtSumPayments
            // 
            this.txtSumPayments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumPayments.Location = new System.Drawing.Point(55, 187);
            this.txtSumPayments.Name = "txtSumPayments";
            this.txtSumPayments.ReadOnly = true;
            this.txtSumPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumPayments.Size = new System.Drawing.Size(138, 23);
            this.txtSumPayments.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 232);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "مجموع المقبوضات";
            // 
            // txtSumReceipts
            // 
            this.txtSumReceipts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumReceipts.Location = new System.Drawing.Point(55, 265);
            this.txtSumReceipts.Name = "txtSumReceipts";
            this.txtSumReceipts.ReadOnly = true;
            this.txtSumReceipts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumReceipts.Size = new System.Drawing.Size(138, 23);
            this.txtSumReceipts.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "الرصيد";
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBalance.Location = new System.Drawing.Point(55, 106);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBalance.Size = new System.Drawing.Size(138, 23);
            this.txtBalance.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 317);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "صافي الربح";
            // 
            // txtNetProfit
            // 
            this.txtNetProfit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNetProfit.Location = new System.Drawing.Point(55, 346);
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.ReadOnly = true;
            this.txtNetProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNetProfit.Size = new System.Drawing.Size(138, 23);
            this.txtNetProfit.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuIteManage,
            this.ToolStripMenuItemPayments,
            this.ToolStripMenuIteRecipts,
            this.ToolStripMenuIteItems});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuIteManage
            // 
            this.ToolStripMenuIteManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddAgency,
            this.ToolStripMenuItemAddPackage,
            this.ToolStripMenuItemAddAccount,
            this.ToolStripMenuItemLogOut});
            this.ToolStripMenuIteManage.Name = "ToolStripMenuIteManage";
            this.ToolStripMenuIteManage.Size = new System.Drawing.Size(41, 20);
            this.ToolStripMenuIteManage.Text = "إدارة";
            // 
            // ToolStripMenuItemAddAgency
            // 
            this.ToolStripMenuItemAddAgency.Name = "ToolStripMenuItemAddAgency";
            this.ToolStripMenuItemAddAgency.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemAddAgency.Text = "اضافة وكيل";
            this.ToolStripMenuItemAddAgency.Click += new System.EventHandler(this.ToolStripMenuItemAddAgency_Click);
            // 
            // ToolStripMenuItemAddPackage
            // 
            this.ToolStripMenuItemAddPackage.Name = "ToolStripMenuItemAddPackage";
            this.ToolStripMenuItemAddPackage.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemAddPackage.Text = "إضافة باقة";
            this.ToolStripMenuItemAddPackage.Click += new System.EventHandler(this.ToolStripMenuItemAddPackage_Click);
            // 
            // ToolStripMenuItemAddAccount
            // 
            this.ToolStripMenuItemAddAccount.Name = "ToolStripMenuItemAddAccount";
            this.ToolStripMenuItemAddAccount.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemAddAccount.Text = "إضافة حساب";
            this.ToolStripMenuItemAddAccount.Click += new System.EventHandler(this.ToolStripMenuItemAddAccount_Click);
            // 
            // ToolStripMenuItemLogOut
            // 
            this.ToolStripMenuItemLogOut.Name = "ToolStripMenuItemLogOut";
            this.ToolStripMenuItemLogOut.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLogOut.Text = "تسجيل خروج";
            this.ToolStripMenuItemLogOut.Click += new System.EventHandler(this.ToolStripMenuItemLogOut_Click);
            // 
            // ToolStripMenuItemPayments
            // 
            this.ToolStripMenuItemPayments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItePayment});
            this.ToolStripMenuItemPayments.Name = "ToolStripMenuItemPayments";
            this.ToolStripMenuItemPayments.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemPayments.Text = "مدفوعات";
            // 
            // ToolStripMenuItePayment
            // 
            this.ToolStripMenuItePayment.Name = "ToolStripMenuItePayment";
            this.ToolStripMenuItePayment.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuItePayment.Text = "إضافة دفعة";
            this.ToolStripMenuItePayment.Click += new System.EventHandler(this.ToolStripMenuItePayment_Click);
            // 
            // ToolStripMenuIteRecipts
            // 
            this.ToolStripMenuIteRecipts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPayOffDebts,
            this.ToolStripMenuItemAddRecipts});
            this.ToolStripMenuIteRecipts.Name = "ToolStripMenuIteRecipts";
            this.ToolStripMenuIteRecipts.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuIteRecipts.Text = "مقبوضات";
            // 
            // ToolStripMenuItemPayOffDebts
            // 
            this.ToolStripMenuItemPayOffDebts.Name = "ToolStripMenuItemPayOffDebts";
            this.ToolStripMenuItemPayOffDebts.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItemPayOffDebts.Text = "تسديد دين";
            this.ToolStripMenuItemPayOffDebts.Click += new System.EventHandler(this.ToolStripMenuItemPayOffDebts_Click);
            // 
            // ToolStripMenuItemAddRecipts
            // 
            this.ToolStripMenuItemAddRecipts.Name = "ToolStripMenuItemAddRecipts";
            this.ToolStripMenuItemAddRecipts.Size = new System.Drawing.Size(130, 22);
            this.ToolStripMenuItemAddRecipts.Text = "استلام مبلغ";
            this.ToolStripMenuItemAddRecipts.Click += new System.EventHandler(this.ToolStripMenuItemAddRecipts_Click);
            // 
            // ToolStripMenuIteItems
            // 
            this.ToolStripMenuIteItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddPost,
            this.ToolStripMenuItemGrantPackage});
            this.ToolStripMenuIteItems.Name = "ToolStripMenuIteItems";
            this.ToolStripMenuIteItems.Size = new System.Drawing.Size(55, 20);
            this.ToolStripMenuIteItems.Text = "منتجات";
            // 
            // ToolStripMenuItemAddPost
            // 
            this.ToolStripMenuItemAddPost.Name = "ToolStripMenuItemAddPost";
            this.ToolStripMenuItemAddPost.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuItemAddPost.Text = "إضافة إعلان";
            this.ToolStripMenuItemAddPost.Click += new System.EventHandler(this.ToolStripMenuItemAddPost_Click);
            // 
            // ToolStripMenuItemGrantPackage
            // 
            this.ToolStripMenuItemGrantPackage.Name = "ToolStripMenuItemGrantPackage";
            this.ToolStripMenuItemGrantPackage.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuItemGrantPackage.Text = "منح باقة";
            this.ToolStripMenuItemGrantPackage.Click += new System.EventHandler(this.ToolStripMenuItemGrantPackage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(55, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 42);
            this.panel1.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "UserName";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNetProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSumReceipts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSumPayments);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grdAccounting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرئيسية";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounting)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAccounting;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioDaily;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioYearly;
        private System.Windows.Forms.RadioButton radioMonthly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumPayments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumReceipts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNetProfit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuIteManage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPayments;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItePayment;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuIteRecipts;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddAgency;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddPackage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddAccount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPayOffDebts;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddRecipts;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuIteItems;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddPost;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGrantPackage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
    }
}
