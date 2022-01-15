
namespace YomyatProgram.Views
{
    partial class AddPost
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
            this.checkIsDebt = new System.Windows.Forms.CheckBox();
            this.checkIsAgency = new System.Windows.Forms.CheckBox();
            this.comboAgency = new System.Windows.Forms.ComboBox();
            this.lblAgency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 79);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "السعر :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 46);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "العنوان :";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(84, 76);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(244, 23);
            this.txtPrice.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(84, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(244, 23);
            this.txtTitle.TabIndex = 12;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPost.Location = new System.Drawing.Point(155, 186);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(134, 23);
            this.btnAddPost.TabIndex = 11;
            this.btnAddPost.Text = "اضافة";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // checkIsDebt
            // 
            this.checkIsDebt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIsDebt.AutoSize = true;
            this.checkIsDebt.Location = new System.Drawing.Point(227, 147);
            this.checkIsDebt.Name = "checkIsDebt";
            this.checkIsDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsDebt.Size = new System.Drawing.Size(88, 19);
            this.checkIsDebt.TabIndex = 18;
            this.checkIsDebt.Text = "على الحساب";
            this.checkIsDebt.UseVisualStyleBackColor = true;
            // 
            // checkIsAgency
            // 
            this.checkIsAgency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIsAgency.AutoSize = true;
            this.checkIsAgency.Location = new System.Drawing.Point(119, 147);
            this.checkIsAgency.Name = "checkIsAgency";
            this.checkIsAgency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsAgency.Size = new System.Drawing.Size(68, 19);
            this.checkIsAgency.TabIndex = 19;
            this.checkIsAgency.Text = "من وكيل";
            this.checkIsAgency.UseVisualStyleBackColor = true;
            this.checkIsAgency.CheckedChanged += new System.EventHandler(this.checkIsAgency_CheckedChanged);
            // 
            // comboAgency
            // 
            this.comboAgency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgency.Enabled = false;
            this.comboAgency.FormattingEnabled = true;
            this.comboAgency.Location = new System.Drawing.Point(84, 114);
            this.comboAgency.Name = "comboAgency";
            this.comboAgency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAgency.Size = new System.Drawing.Size(244, 23);
            this.comboAgency.TabIndex = 29;
            // 
            // lblAgency
            // 
            this.lblAgency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgency.AutoSize = true;
            this.lblAgency.Enabled = false;
            this.lblAgency.Location = new System.Drawing.Point(334, 117);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgency.Size = new System.Drawing.Size(62, 15);
            this.lblAgency.TabIndex = 28;
            this.lblAgency.Text = "من الوكيل :";
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.comboAgency);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.checkIsAgency);
            this.Controls.Add(this.checkIsDebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnAddPost);
            this.Name = "AddPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة إعلان";
            this.Load += new System.EventHandler(this.AddPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.CheckBox checkIsDebt;
        private System.Windows.Forms.CheckBox checkIsAgency;
        private System.Windows.Forms.ComboBox comboAgency;
        private System.Windows.Forms.Label lblAgency;
    }
}