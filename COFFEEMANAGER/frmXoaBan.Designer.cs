
namespace COFFEEMANAGER
{
    partial class frmXoaBan
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
            this.btnXoa_ban = new System.Windows.Forms.Button();
            this.cbXoa_ban = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXoa_ban
            // 
            this.btnXoa_ban.Location = new System.Drawing.Point(264, 8);
            this.btnXoa_ban.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa_ban.Name = "btnXoa_ban";
            this.btnXoa_ban.Size = new System.Drawing.Size(67, 21);
            this.btnXoa_ban.TabIndex = 5;
            this.btnXoa_ban.Text = "xóa món";
            this.btnXoa_ban.UseVisualStyleBackColor = true;
            this.btnXoa_ban.Click += new System.EventHandler(this.btnXoa_ban_Click);
            // 
            // cbXoa_ban
            // 
            this.cbXoa_ban.FormattingEnabled = true;
            this.cbXoa_ban.Location = new System.Drawing.Point(127, 8);
            this.cbXoa_ban.Margin = new System.Windows.Forms.Padding(2);
            this.cbXoa_ban.Name = "cbXoa_ban";
            this.cbXoa_ban.Size = new System.Drawing.Size(124, 21);
            this.cbXoa_ban.TabIndex = 4;
            this.cbXoa_ban.SelectedIndexChanged += new System.EventHandler(this.cbXoa_ban_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "mã cửa hàng cần xóa";
            // 
            // frmXoaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 65);
            this.Controls.Add(this.btnXoa_ban);
            this.Controls.Add(this.cbXoa_ban);
            this.Controls.Add(this.label1);
            this.Name = "frmXoaBan";
            this.Text = "frmXoaBan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa_ban;
        private System.Windows.Forms.ComboBox cbXoa_ban;
        private System.Windows.Forms.Label label1;
    }
}