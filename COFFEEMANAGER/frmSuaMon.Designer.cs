
namespace COFFEEMANAGER
{
    partial class frmSuaMon
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
            this.btnSua_mon = new System.Windows.Forms.Button();
            this.txtSua_Gia = new System.Windows.Forms.TextBox();
            this.txtSua_Tenmon = new System.Windows.Forms.TextBox();
            this.cbSua_Madm = new System.Windows.Forms.ComboBox();
            this.cbSua_Mamon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSua_mon
            // 
            this.btnSua_mon.Location = new System.Drawing.Point(13, 158);
            this.btnSua_mon.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua_mon.Name = "btnSua_mon";
            this.btnSua_mon.Size = new System.Drawing.Size(144, 19);
            this.btnSua_mon.TabIndex = 14;
            this.btnSua_mon.Text = "Cập nhật món";
            this.btnSua_mon.UseVisualStyleBackColor = true;
            this.btnSua_mon.Click += new System.EventHandler(this.btnSua_mon_Click);
            // 
            // txtSua_Gia
            // 
            this.txtSua_Gia.Location = new System.Drawing.Point(48, 81);
            this.txtSua_Gia.Margin = new System.Windows.Forms.Padding(2);
            this.txtSua_Gia.Name = "txtSua_Gia";
            this.txtSua_Gia.Size = new System.Drawing.Size(92, 20);
            this.txtSua_Gia.TabIndex = 13;
            // 
            // txtSua_Tenmon
            // 
            this.txtSua_Tenmon.Location = new System.Drawing.Point(109, 40);
            this.txtSua_Tenmon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSua_Tenmon.Name = "txtSua_Tenmon";
            this.txtSua_Tenmon.Size = new System.Drawing.Size(215, 20);
            this.txtSua_Tenmon.TabIndex = 12;
            // 
            // cbSua_Madm
            // 
            this.cbSua_Madm.FormattingEnabled = true;
            this.cbSua_Madm.Location = new System.Drawing.Point(91, 111);
            this.cbSua_Madm.Margin = new System.Windows.Forms.Padding(2);
            this.cbSua_Madm.Name = "cbSua_Madm";
            this.cbSua_Madm.Size = new System.Drawing.Size(113, 21);
            this.cbSua_Madm.TabIndex = 11;
            // 
            // cbSua_Mamon
            // 
            this.cbSua_Mamon.FormattingEnabled = true;
            this.cbSua_Mamon.Location = new System.Drawing.Point(91, 6);
            this.cbSua_Mamon.Margin = new System.Windows.Forms.Padding(2);
            this.cbSua_Mamon.Name = "cbSua_Mamon";
            this.cbSua_Mamon.Size = new System.Drawing.Size(113, 21);
            this.cbSua_Mamon.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên món cần sửa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chọn mã món";
            // 
            // frmSuaMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.btnSua_mon);
            this.Controls.Add(this.txtSua_Gia);
            this.Controls.Add(this.txtSua_Tenmon);
            this.Controls.Add(this.cbSua_Madm);
            this.Controls.Add(this.cbSua_Mamon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSuaMon";
            this.Text = "frmSuaMon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua_mon;
        private System.Windows.Forms.TextBox txtSua_Gia;
        private System.Windows.Forms.TextBox txtSua_Tenmon;
        private System.Windows.Forms.ComboBox cbSua_Madm;
        private System.Windows.Forms.ComboBox cbSua_Mamon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}