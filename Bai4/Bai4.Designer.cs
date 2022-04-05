
namespace Bai4
{
    partial class Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.MaCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Mã CD";
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(163, 69);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(256, 26);
            this.txtMaCD.TabIndex = 1;
            // 
            // txtTenCD
            // 
            this.txtTenCD.Location = new System.Drawing.Point(163, 130);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(256, 26);
            this.txtTenCD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = " Tên CD";
            // 
            // dgvCD
            // 
            this.dgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCD,
            this.TenCD,
            this.CMND,
            this.GioiTinh,
            this.NamSinh,
            this.SoDienThoai});
            this.dgvCD.Location = new System.Drawing.Point(451, 57);
            this.dgvCD.Name = "dgvCD";
            this.dgvCD.RowHeadersWidth = 62;
            this.dgvCD.RowTemplate.Height = 28;
            this.dgvCD.Size = new System.Drawing.Size(701, 362);
            this.dgvCD.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaCD
            // 
            this.MaCD.DataPropertyName = "MaCD";
            this.MaCD.HeaderText = "Mã CD";
            this.MaCD.MinimumWidth = 8;
            this.MaCD.Name = "MaCD";
            this.MaCD.Width = 150;
            // 
            // TenCD
            // 
            this.TenCD.DataPropertyName = "TenCD";
            this.TenCD.HeaderText = "Tên CD";
            this.TenCD.MinimumWidth = 8;
            this.TenCD.Name = "TenCD";
            this.TenCD.Width = 150;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 8;
            this.CMND.Name = "CMND";
            this.CMND.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm Sinh";
            this.NamSinh.MinimumWidth = 8;
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Width = 150;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "SDT";
            this.SoDienThoai.MinimumWidth = 8;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 150;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCD);
            this.Controls.Add(this.txtTenCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaCD);
            this.Controls.Add(this.label1);
            this.Name = "Bai4";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.TextBox txtTenCD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
    }
}

