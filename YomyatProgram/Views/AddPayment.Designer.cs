
namespace YomyatProgram.Views
{
    partial class AddPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.checkIsSal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "عنوان الدفعة";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue.Location = new System.Drawing.Point(77, 82);
            this.txtValue.Name = "txtValue";
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValue.Size = new System.Drawing.Size(244, 23);
            this.txtValue.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(77, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(244, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPayment.Location = new System.Drawing.Point(136, 206);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(134, 23);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "اضافة دفعة";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 86);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "قيمة الدفعة";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 140);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "تفاصيل";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Location = new System.Drawing.Point(77, 116);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDesc.Size = new System.Drawing.Size(244, 67);
            this.txtDesc.TabIndex = 9;
            // 
            // checkIsSal
            // 
            this.checkIsSal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIsSal.AutoSize = true;
            this.checkIsSal.Location = new System.Drawing.Point(267, 57);
            this.checkIsSal.Name = "checkIsSal";
            this.checkIsSal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsSal.Size = new System.Drawing.Size(54, 19);
            this.checkIsSal.TabIndex = 19;
            this.checkIsSal.Text = "رواتب";
            this.checkIsSal.UseVisualStyleBackColor = true;
            this.checkIsSal.CheckedChanged += new System.EventHandler(this.checkIsSal_CheckedChanged);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.checkIsSal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnAddPayment);
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة دفعة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.CheckBox checkIsSal;
    }
}