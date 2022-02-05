
namespace COFFEEMANAGER
{
    partial class frmXoaMon
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
            this.cbXoa_mon = new System.Windows.Forms.ComboBox();
            this.btnXoa_mon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbXoa_mon
            // 
            this.cbXoa_mon.FormattingEnabled = true;
            this.cbXoa_mon.Location = new System.Drawing.Point(95, 12);
            this.cbXoa_mon.Margin = new System.Windows.Forms.Padding(2);
            this.cbXoa_mon.Name = "cbXoa_mon";
            this.cbXoa_mon.Size = new System.Drawing.Size(144, 21);
            this.cbXoa_mon.TabIndex = 6;
            // 
            // btnXoa_mon
            // 
            this.btnXoa_mon.Location = new System.Drawing.Point(252, 13);
            this.btnXoa_mon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa_mon.Name = "btnXoa_mon";
            this.btnXoa_mon.Size = new System.Drawing.Size(92, 19);
            this.btnXoa_mon.TabIndex = 5;
            this.btnXoa_mon.Text = "Xóa món";
            this.btnXoa_mon.UseVisualStyleBackColor = true;
            this.btnXoa_mon.Click += new System.EventHandler(this.btnXoa_mon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã món cần xóa";
            // 
            // frmXoaMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 98);
            this.Controls.Add(this.cbXoa_mon);
            this.Controls.Add(this.btnXoa_mon);
            this.Controls.Add(this.label1);
            this.Name = "frmXoaMon";
            this.Text = "frmXoaMon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbXoa_mon;
        private System.Windows.Forms.Button btnXoa_mon;
        private System.Windows.Forms.Label label1;
    }
}