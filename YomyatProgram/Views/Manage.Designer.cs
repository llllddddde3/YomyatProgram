namespace YomyatProgram.Views
{
    partial class Manage
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
            this.lblDesOrType = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesOrType
            // 
            this.lblDesOrType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesOrType.AutoSize = true;
            this.lblDesOrType.Location = new System.Drawing.Point(349, 130);
            this.lblDesOrType.Name = "lblDesOrType";
            this.lblDesOrType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDesOrType.Size = new System.Drawing.Size(44, 15);
            this.lblDesOrType.TabIndex = 26;
            this.lblDesOrType.Text = "تفاصيل";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Location = new System.Drawing.Point(86, 109);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDesc.Size = new System.Drawing.Size(244, 67);
            this.txtDesc.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "القيمة";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "العنوان";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValue.Location = new System.Drawing.Point(86, 75);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValue.Size = new System.Drawing.Size(244, 23);
            this.txtValue.TabIndex = 22;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(86, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(244, 23);
            this.txtTitle.TabIndex = 21;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Location = new System.Drawing.Point(145, 199);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 23);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "حذف";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.lblDesOrType);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnRemove);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف منتج";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesOrType;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnRemove;
    }
}