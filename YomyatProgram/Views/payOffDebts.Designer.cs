
namespace YomyatProgram.Views
{
    partial class payOffDebts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payOffDebts));
            this.grdDebt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboTitles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAgency = new System.Windows.Forms.ComboBox();
            this.txtSumDebts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPayOffAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDebt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDebt
            // 
            resources.ApplyResources(this.grdDebt, "grdDebt");
            this.grdDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDebt.Name = "grdDebt";
            this.grdDebt.ReadOnly = true;
            this.grdDebt.RowTemplate.Height = 25;
            this.grdDebt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDebt_CellDoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtValue
            // 
            resources.ApplyResources(this.txtValue, "txtValue");
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComboTitles);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboAgency);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnFilter
            // 
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ComboTitles
            // 
            this.ComboTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTitles.FormattingEnabled = true;
            resources.ApplyResources(this.ComboTitles, "ComboTitles");
            this.ComboTitles.Name = "ComboTitles";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboAgency
            // 
            this.comboAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgency.FormattingEnabled = true;
            resources.ApplyResources(this.comboAgency, "comboAgency");
            this.comboAgency.Name = "comboAgency";
            // 
            // txtSumDebts
            // 
            resources.ApplyResources(this.txtSumDebts, "txtSumDebts");
            this.txtSumDebts.Name = "txtSumDebts";
            this.txtSumDebts.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnPayOffAll
            // 
            resources.ApplyResources(this.btnPayOffAll, "btnPayOffAll");
            this.btnPayOffAll.Name = "btnPayOffAll";
            this.btnPayOffAll.UseVisualStyleBackColor = true;
            this.btnPayOffAll.Click += new System.EventHandler(this.btnPayOffAll_Click);
            // 
            // payOffDebts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPayOffAll);
            this.Controls.Add(this.txtSumDebts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDebt);
            this.Name = "payOffDebts";
            this.Load += new System.EventHandler(this.payOffDebts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDebt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboAgency;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboTitles;
        private System.Windows.Forms.TextBox txtSumDebts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPayOffAll;
    }
}