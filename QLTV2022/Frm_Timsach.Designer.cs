
namespace QLTV2022
{
    partial class Frm_Timsach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.rabtnTensach = new System.Windows.Forms.RadioButton();
            this.rabtnMasach = new System.Windows.Forms.RadioButton();
            this.comMaphieumuon = new System.Windows.Forms.ComboBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM SÁCH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTensach);
            this.groupBox1.Controls.Add(this.comMaphieumuon);
            this.groupBox1.Controls.Add(this.rabtnTensach);
            this.groupBox1.Controls.Add(this.rabtnMasach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(642, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(455, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(855, 338);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 29);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rabtnTensach
            // 
            this.rabtnTensach.AutoSize = true;
            this.rabtnTensach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnTensach.Location = new System.Drawing.Point(32, 113);
            this.rabtnTensach.Margin = new System.Windows.Forms.Padding(2);
            this.rabtnTensach.Name = "rabtnTensach";
            this.rabtnTensach.Size = new System.Drawing.Size(101, 26);
            this.rabtnTensach.TabIndex = 1;
            this.rabtnTensach.TabStop = true;
            this.rabtnTensach.Text = "Tên sách";
            this.rabtnTensach.UseVisualStyleBackColor = true;
            // 
            // rabtnMasach
            // 
            this.rabtnMasach.AutoSize = true;
            this.rabtnMasach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnMasach.Location = new System.Drawing.Point(32, 51);
            this.rabtnMasach.Margin = new System.Windows.Forms.Padding(2);
            this.rabtnMasach.Name = "rabtnMasach";
            this.rabtnMasach.Size = new System.Drawing.Size(97, 26);
            this.rabtnMasach.TabIndex = 0;
            this.rabtnMasach.TabStop = true;
            this.rabtnMasach.Text = "Mã sách";
            this.rabtnMasach.UseVisualStyleBackColor = true;
            // 
            // comMaphieumuon
            // 
            this.comMaphieumuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comMaphieumuon.FormattingEnabled = true;
            this.comMaphieumuon.Location = new System.Drawing.Point(175, 49);
            this.comMaphieumuon.Margin = new System.Windows.Forms.Padding(2);
            this.comMaphieumuon.Name = "comMaphieumuon";
            this.comMaphieumuon.Size = new System.Drawing.Size(247, 30);
            this.comMaphieumuon.TabIndex = 13;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(175, 112);
            this.txtTensach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(247, 30);
            this.txtTensach.TabIndex = 14;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(991, 338);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 29);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Frm_Timsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 680);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Name = "Frm_Timsach";
            this.Text = "Frm_Timsach";
            this.Load += new System.EventHandler(this.Frm_Timsach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton rabtnTensach;
        private System.Windows.Forms.RadioButton rabtnMasach;
        private System.Windows.Forms.ComboBox comMaphieumuon;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.Button btnThoat;
    }
}