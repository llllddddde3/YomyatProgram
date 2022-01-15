
namespace YomyatProgram.Views
{
    partial class AddPackage
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 133);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "السعر";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 66);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "العنوان";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(84, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(244, 23);
            this.txtPrice.TabIndex = 21;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(84, 63);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(244, 23);
            this.txtTitle.TabIndex = 20;
            // 
            // btnAddPost
            // 
            this.btnAddPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPost.Location = new System.Drawing.Point(149, 171);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(134, 23);
            this.btnAddPost.TabIndex = 19;
            this.btnAddPost.Text = "اضافة";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 100);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "عدد المنشورات";
            // 
            // txtCount
            // 
            this.txtCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCount.Location = new System.Drawing.Point(84, 97);
            this.txtCount.Name = "txtCount";
            this.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCount.Size = new System.Drawing.Size(244, 23);
            this.txtCount.TabIndex = 24;
            // 
            // AddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnAddPost);
            this.Name = "AddPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة باقة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCount;
    }
}