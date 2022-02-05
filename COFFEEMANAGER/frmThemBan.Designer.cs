
namespace COFFEEMANAGER
{
    partial class frmThemBan
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
            this.button_thembanmoi = new System.Windows.Forms.Button();
            this.txtThem_Mamon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThem_Mach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_thembanmoi
            // 
            this.button_thembanmoi.Location = new System.Drawing.Point(11, 83);
            this.button_thembanmoi.Margin = new System.Windows.Forms.Padding(2);
            this.button_thembanmoi.Name = "button_thembanmoi";
            this.button_thembanmoi.Size = new System.Drawing.Size(182, 25);
            this.button_thembanmoi.TabIndex = 7;
            this.button_thembanmoi.Text = "Them Mon Duoc Ban";
            this.button_thembanmoi.UseVisualStyleBackColor = true;
            this.button_thembanmoi.Click += new System.EventHandler(this.button_thembanmoi_Click);
            // 
            // txtThem_Mamon
            // 
            this.txtThem_Mamon.Location = new System.Drawing.Point(94, 48);
            this.txtThem_Mamon.Margin = new System.Windows.Forms.Padding(2);
            this.txtThem_Mamon.Name = "txtThem_Mamon";
            this.txtThem_Mamon.Size = new System.Drawing.Size(99, 20);
            this.txtThem_Mamon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "mã món";
            // 
            // txtThem_Mach
            // 
            this.txtThem_Mach.Location = new System.Drawing.Point(94, 9);
            this.txtThem_Mach.Margin = new System.Windows.Forms.Padding(2);
            this.txtThem_Mach.Name = "txtThem_Mach";
            this.txtThem_Mach.Size = new System.Drawing.Size(99, 20);
            this.txtThem_Mach.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "mã cửa hàng";
            // 
            // frmThemBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 143);
            this.Controls.Add(this.button_thembanmoi);
            this.Controls.Add(this.txtThem_Mamon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThem_Mach);
            this.Controls.Add(this.label1);
            this.Name = "frmThemBan";
            this.Text = "frmThemBan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_thembanmoi;
        private System.Windows.Forms.TextBox txtThem_Mamon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThem_Mach;
        private System.Windows.Forms.Label label1;
    }
}