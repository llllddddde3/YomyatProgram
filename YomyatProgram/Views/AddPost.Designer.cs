
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPost));
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
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.Name = "txtPrice";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            // 
            // btnAddPost
            // 
            resources.ApplyResources(this.btnAddPost, "btnAddPost");
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // checkIsDebt
            // 
            resources.ApplyResources(this.checkIsDebt, "checkIsDebt");
            this.checkIsDebt.Name = "checkIsDebt";
            this.checkIsDebt.UseVisualStyleBackColor = true;
            // 
            // checkIsAgency
            // 
            resources.ApplyResources(this.checkIsAgency, "checkIsAgency");
            this.checkIsAgency.Name = "checkIsAgency";
            this.checkIsAgency.UseVisualStyleBackColor = true;
            this.checkIsAgency.CheckedChanged += new System.EventHandler(this.checkIsAgency_CheckedChanged);
            // 
            // comboAgency
            // 
            resources.ApplyResources(this.comboAgency, "comboAgency");
            this.comboAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgency.FormattingEnabled = true;
            this.comboAgency.Name = "comboAgency";
            // 
            // lblAgency
            // 
            resources.ApplyResources(this.lblAgency, "lblAgency");
            this.lblAgency.Name = "lblAgency";
            // 
            // AddPost
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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