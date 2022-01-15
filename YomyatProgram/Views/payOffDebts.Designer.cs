
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
            ((System.ComponentModel.ISupportInitialize)(this.grdDebt)).BeginInit();
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
            this.grdDebt.Size = new System.Drawing.Size(640, 359);
            this.grdDebt.TabIndex = 0;
            this.grdDebt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDebt_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 111);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "العنوان";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(11, 129);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(244, 23);
            this.txtTitle.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(54, 241);
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
            this.label2.Location = new System.Drawing.Point(94, 171);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "القيمة المسددة";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue.Location = new System.Drawing.Point(11, 189);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValue.Size = new System.Drawing.Size(244, 23);
            this.txtValue.TabIndex = 26;
            // 
            // payOffDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.grdDebt);
            this.Name = "payOffDebts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسديد دين";
            this.Load += new System.EventHandler(this.payOffDebts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDebt)).EndInit();
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
    }
}