
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
            resources.ApplyResources(this.grdAccounting, "grdAccounting");
            this.grdAccounting.AllowUserToAddRows = false;
            this.grdAccounting.AllowUserToDeleteRows = false;
            this.grdAccounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAccounting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccounting.Name = "grdAccounting";
            this.grdAccounting.ReadOnly = true;
            this.grdAccounting.RowTemplate.Height = 25;
            this.grdAccounting.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccounting_CellDoubleClick);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // radioDaily
            // 
            resources.ApplyResources(this.radioDaily, "radioDaily");
            this.radioDaily.Checked = true;
            this.radioDaily.Name = "radioDaily";
            this.radioDaily.TabStop = true;
            this.radioDaily.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.radioYearly);
            this.groupBox1.Controls.Add(this.radioMonthly);
            this.groupBox1.Controls.Add(this.radioDaily);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioYearly
            // 
            resources.ApplyResources(this.radioYearly, "radioYearly");
            this.radioYearly.Name = "radioYearly";
            this.radioYearly.UseVisualStyleBackColor = true;
            // 
            // radioMonthly
            // 
            resources.ApplyResources(this.radioMonthly, "radioMonthly");
            this.radioMonthly.Name = "radioMonthly";
            this.radioMonthly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtSumPayments
            // 
            resources.ApplyResources(this.txtSumPayments, "txtSumPayments");
            this.txtSumPayments.Name = "txtSumPayments";
            this.txtSumPayments.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtSumReceipts
            // 
            resources.ApplyResources(this.txtSumReceipts, "txtSumReceipts");
            this.txtSumReceipts.Name = "txtSumReceipts";
            this.txtSumReceipts.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtBalance
            // 
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Leave += new System.EventHandler(this.txtBalance_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtNetProfit
            // 
            resources.ApplyResources(this.txtNetProfit, "txtNetProfit");
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.ReadOnly = true;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuIteManage,
            this.ToolStripMenuItemPayments,
            this.ToolStripMenuIteRecipts,
            this.ToolStripMenuIteItems});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ToolStripMenuIteManage
            // 
            resources.ApplyResources(this.ToolStripMenuIteManage, "ToolStripMenuIteManage");
            this.ToolStripMenuIteManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddAgency,
            this.ToolStripMenuItemAddPackage,
            this.ToolStripMenuItemAddAccount,
            this.ToolStripMenuItemLogOut});
            this.ToolStripMenuIteManage.Name = "ToolStripMenuIteManage";
            // 
            // ToolStripMenuItemAddAgency
            // 
            resources.ApplyResources(this.ToolStripMenuItemAddAgency, "ToolStripMenuItemAddAgency");
            this.ToolStripMenuItemAddAgency.Name = "ToolStripMenuItemAddAgency";
            this.ToolStripMenuItemAddAgency.Click += new System.EventHandler(this.ToolStripMenuItemAddAgency_Click);
            // 
            // ToolStripMenuItemAddPackage
            // 
            resources.ApplyResources(this.ToolStripMenuItemAddPackage, "ToolStripMenuItemAddPackage");
            this.ToolStripMenuItemAddPackage.Name = "ToolStripMenuItemAddPackage";
            this.ToolStripMenuItemAddPackage.Click += new System.EventHandler(this.ToolStripMenuItemAddPackage_Click);
            // 
            // ToolStripMenuItemAddAccount
            // 
            resources.ApplyResources(this.ToolStripMenuItemAddAccount, "ToolStripMenuItemAddAccount");
            this.ToolStripMenuItemAddAccount.Name = "ToolStripMenuItemAddAccount";
            this.ToolStripMenuItemAddAccount.Click += new System.EventHandler(this.ToolStripMenuItemAddAccount_Click);
            // 
            // ToolStripMenuItemLogOut
            // 
            resources.ApplyResources(this.ToolStripMenuItemLogOut, "ToolStripMenuItemLogOut");
            this.ToolStripMenuItemLogOut.Name = "ToolStripMenuItemLogOut";
            this.ToolStripMenuItemLogOut.Click += new System.EventHandler(this.ToolStripMenuItemLogOut_Click);
            // 
            // ToolStripMenuItemPayments
            // 
            resources.ApplyResources(this.ToolStripMenuItemPayments, "ToolStripMenuItemPayments");
            this.ToolStripMenuItemPayments.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItePayment});
            this.ToolStripMenuItemPayments.Name = "ToolStripMenuItemPayments";
            // 
            // ToolStripMenuItePayment
            // 
            resources.ApplyResources(this.ToolStripMenuItePayment, "ToolStripMenuItePayment");
            this.ToolStripMenuItePayment.Name = "ToolStripMenuItePayment";
            this.ToolStripMenuItePayment.Click += new System.EventHandler(this.ToolStripMenuItePayment_Click);
            // 
            // ToolStripMenuIteRecipts
            // 
            resources.ApplyResources(this.ToolStripMenuIteRecipts, "ToolStripMenuIteRecipts");
            this.ToolStripMenuIteRecipts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPayOffDebts,
            this.ToolStripMenuItemAddRecipts});
            this.ToolStripMenuIteRecipts.Name = "ToolStripMenuIteRecipts";
            // 
            // ToolStripMenuItemPayOffDebts
            // 
            resources.ApplyResources(this.ToolStripMenuItemPayOffDebts, "ToolStripMenuItemPayOffDebts");
            this.ToolStripMenuItemPayOffDebts.Name = "ToolStripMenuItemPayOffDebts";
            this.ToolStripMenuItemPayOffDebts.Click += new System.EventHandler(this.ToolStripMenuItemPayOffDebts_Click);
            // 
            // ToolStripMenuItemAddRecipts
            // 
            resources.ApplyResources(this.ToolStripMenuItemAddRecipts, "ToolStripMenuItemAddRecipts");
            this.ToolStripMenuItemAddRecipts.Name = "ToolStripMenuItemAddRecipts";
            this.ToolStripMenuItemAddRecipts.Click += new System.EventHandler(this.ToolStripMenuItemAddRecipts_Click);
            // 
            // ToolStripMenuIteItems
            // 
            resources.ApplyResources(this.ToolStripMenuIteItems, "ToolStripMenuIteItems");
            this.ToolStripMenuIteItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddPost,
            this.ToolStripMenuItemGrantPackage});
            this.ToolStripMenuIteItems.Name = "ToolStripMenuIteItems";
            // 
            // ToolStripMenuItemAddPost
            // 
            resources.ApplyResources(this.ToolStripMenuItemAddPost, "ToolStripMenuItemAddPost");
            this.ToolStripMenuItemAddPost.Name = "ToolStripMenuItemAddPost";
            this.ToolStripMenuItemAddPost.Click += new System.EventHandler(this.ToolStripMenuItemAddPost_Click);
            // 
            // ToolStripMenuItemGrantPackage
            // 
            resources.ApplyResources(this.ToolStripMenuItemGrantPackage, "ToolStripMenuItemGrantPackage");
            this.ToolStripMenuItemGrantPackage.Name = "ToolStripMenuItemGrantPackage";
            this.ToolStripMenuItemGrantPackage.Click += new System.EventHandler(this.ToolStripMenuItemGrantPackage_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Name = "panel1";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Main";
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
