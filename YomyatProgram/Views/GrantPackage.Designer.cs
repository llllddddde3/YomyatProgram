
namespace YomyatProgram.Views
{
    partial class GrantPackage
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
            this.checkIsDebt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnGrant = new System.Windows.Forms.Button();
            this.comboPackages = new System.Windows.Forms.ComboBox();
            this.comboAgency = new System.Windows.Forms.ComboBox();
            this.lblAgency = new System.Windows.Forms.Label();
            this.checkIsAgency = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkIsDebt
            // 
            this.checkIsDebt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIsDebt.AutoSize = true;
            this.checkIsDebt.Location = new System.Drawing.Point(233, 155);
            this.checkIsDebt.Name = "checkIsDebt";
            this.checkIsDebt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsDebt.Size = new System.Drawing.Size(88, 19);
            this.checkIsDebt.TabIndex = 24;
            this.checkIsDebt.Text = "على الحساب";
            this.checkIsDebt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 81);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "الباقة :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "العنوان :";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(77, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTitle.Size = new System.Drawing.Size(244, 23);
            this.txtTitle.TabIndex = 20;
            // 
            // btnGrant
            // 
            this.btnGrant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrant.Location = new System.Drawing.Point(144, 193);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(134, 23);
            this.btnGrant.TabIndex = 19;
            this.btnGrant.Text = "منح";
            this.btnGrant.UseVisualStyleBackColor = true;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // comboPackages
            // 
            this.comboPackages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPackages.FormattingEnabled = true;
            this.comboPackages.Location = new System.Drawing.Point(77, 78);
            this.comboPackages.Name = "comboPackages";
            this.comboPackages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboPackages.Size = new System.Drawing.Size(244, 23);
            this.comboPackages.TabIndex = 25;
            // 
            // comboAgency
            // 
            this.comboAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAgency.Enabled = false;
            this.comboAgency.FormattingEnabled = true;
            this.comboAgency.Location = new System.Drawing.Point(77, 110);
            this.comboAgency.Name = "comboAgency";
            this.comboAgency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboAgency.Size = new System.Drawing.Size(244, 23);
            this.comboAgency.TabIndex = 27;
            // 
            // lblAgency
            // 
            this.lblAgency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgency.AutoSize = true;
            this.lblAgency.Enabled = false;
            this.lblAgency.Location = new System.Drawing.Point(327, 113);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAgency.Size = new System.Drawing.Size(62, 15);
            this.lblAgency.TabIndex = 26;
            this.lblAgency.Text = "من الوكيل :";
            // 
            // checkIsAgency
            // 
            this.checkIsAgency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIsAgency.AutoSize = true;
            this.checkIsAgency.Location = new System.Drawing.Point(112, 155);
            this.checkIsAgency.Name = "checkIsAgency";
            this.checkIsAgency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsAgency.Size = new System.Drawing.Size(68, 19);
            this.checkIsAgency.TabIndex = 28;
            this.checkIsAgency.Text = "من وكيل";
            this.checkIsAgency.UseVisualStyleBackColor = true;
            this.checkIsAgency.CheckedChanged += new System.EventHandler(this.checkIsAgency_CheckedChanged);
            // 
            // GrantPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.checkIsAgency);
            this.Controls.Add(this.comboAgency);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.comboPackages);
            this.Controls.Add(this.checkIsDebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnGrant);
            this.Name = "GrantPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منح باقة";
            this.Load += new System.EventHandler(this.GrantPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkIsDebt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.ComboBox comboPackages;
        private System.Windows.Forms.ComboBox comboAgency;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.CheckBox checkIsAgency;
    }
}