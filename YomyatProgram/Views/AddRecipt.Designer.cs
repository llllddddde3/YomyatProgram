
namespace YomyatProgram.Views
{
    partial class AddRecipt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.lbl22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 90);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "السعر :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "العنوان :";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(74, 87);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(244, 23);
            this.txtPrice.TabIndex = 32;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(74, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(244, 23);
            this.txtTitle.TabIndex = 31;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPost.Location = new System.Drawing.Point(150, 183);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(134, 23);
            this.btnAddPost.TabIndex = 30;
            this.btnAddPost.Text = "اضافة";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // comboType
            // 
            this.comboType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(74, 126);
            this.comboType.Name = "comboType";
            this.comboType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboType.Size = new System.Drawing.Size(244, 23);
            this.comboType.TabIndex = 36;
            // 
            // lbl22
            // 
            this.lbl22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl22.AutoSize = true;
            this.lbl22.Location = new System.Drawing.Point(324, 129);
            this.lbl22.Name = "lbl22";
            this.lbl22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl22.Size = new System.Drawing.Size(37, 15);
            this.lbl22.TabIndex = 35;
            this.lbl22.Text = "النوع :";
            // 
            // AddRecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnAddPost);
            this.Name = "AddRecipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قبض مبلغ";
            this.Load += new System.EventHandler(this.AddRecipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label lbl22;
    }
}