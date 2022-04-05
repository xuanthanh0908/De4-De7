
namespace Bai4
{
    partial class bai6
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
            this.txtMACD = new System.Windows.Forms.TextBox();
            this.dgvCD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ CD";
            // 
            // txtMACD
            // 
            this.txtMACD.Location = new System.Drawing.Point(135, 68);
            this.txtMACD.Name = "txtMACD";
            this.txtMACD.Size = new System.Drawing.Size(189, 26);
            this.txtMACD.TabIndex = 1;
            // 
            // dgvCD
            // 
            this.dgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCD.Location = new System.Drawing.Point(402, 23);
            this.dgvCD.Name = "dgvCD";
            this.dgvCD.RowHeadersWidth = 62;
            this.dgvCD.RowTemplate.Height = 28;
            this.dgvCD.Size = new System.Drawing.Size(720, 421);
            this.dgvCD.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCD);
            this.Controls.Add(this.txtMACD);
            this.Controls.Add(this.label1);
            this.Name = "bai6";
            this.Text = "bai6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMACD;
        private System.Windows.Forms.DataGridView dgvCD;
        private System.Windows.Forms.Button button1;
    }
}