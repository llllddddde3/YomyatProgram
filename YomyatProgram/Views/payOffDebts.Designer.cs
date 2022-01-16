
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
            this.grdDebt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDebt.Location = new System.Drawing.Point(261, 16);
            this.grdDebt.Name = "grdDebt";
            this.grdDebt.ReadOnly = true;
            this.grdDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdDebt.RowTemplate.Height = 25;
            this.grdDebt.Size = new System.Drawing.Size(640, 315);
            this.grdDebt.TabIndex = 0;
            this.grdDebt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDebt_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "العنوان";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(10, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(216, 23);
            this.txtTitle.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(52, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "تسديد";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 70);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "القيمة المسددة";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue.Location = new System.Drawing.Point(10, 88);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValue.Size = new System.Drawing.Size(216, 23);
            this.txtValue.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(232, 169);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تسديد دفعة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComboTitles);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboAgency);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(232, 169);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فلترة";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(52, 130);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(134, 23);
            this.btnFilter.TabIndex = 28;
            this.btnFilter.Text = "فلترة";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 70);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "العنوان";
            // 
            // ComboTitles
            // 
            this.ComboTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTitles.FormattingEnabled = true;
            this.ComboTitles.Location = new System.Drawing.Point(10, 88);
            this.ComboTitles.Name = "ComboTitles";
            this.ComboTitles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboTitles.Size = new System.Drawing.Size(216, 23);
            this.ComboTitles.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "الوكيل";
            // 
            // comboAgency
            // 
            this.comboAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgency.FormattingEnabled = true;
            this.comboAgency.Location = new System.Drawing.Point(10, 37);
            this.comboAgency.Name = "comboAgency";
            this.comboAgency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAgency.Size = new System.Drawing.Size(216, 23);
            this.comboAgency.TabIndex = 28;
            // 
            // txtSumDebts
            // 
            this.txtSumDebts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSumDebts.Location = new System.Drawing.Point(518, 347);
            this.txtSumDebts.Name = "txtSumDebts";
            this.txtSumDebts.ReadOnly = true;
            this.txtSumDebts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSumDebts.Size = new System.Drawing.Size(216, 23);
            this.txtSumDebts.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 349);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "مجموع الديون :";
            // 
            // btnPayOffAll
            // 
            this.btnPayOffAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPayOffAll.Enabled = false;
            this.btnPayOffAll.Location = new System.Drawing.Point(367, 347);
            this.btnPayOffAll.Name = "btnPayOffAll";
            this.btnPayOffAll.Size = new System.Drawing.Size(134, 23);
            this.btnPayOffAll.TabIndex = 31;
            this.btnPayOffAll.Text = "تسديد الكل";
            this.btnPayOffAll.UseVisualStyleBackColor = true;
            this.btnPayOffAll.Click += new System.EventHandler(this.btnPayOffAll_Click);
            // 
            // payOffDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 387);
            this.Controls.Add(this.btnPayOffAll);
            this.Controls.Add(this.txtSumDebts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdDebt);
            this.Name = "payOffDebts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسديد دين";
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