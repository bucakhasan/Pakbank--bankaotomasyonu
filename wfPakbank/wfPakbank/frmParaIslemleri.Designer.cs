﻿namespace wfPakbank
{
    partial class frmParaIslemleri
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
            this.lblTarih = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHesapID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIslemTipleri = new System.Windows.Forms.ComboBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarih.Location = new System.Drawing.Point(151, 163);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(210, 24);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "İşlem Tarihi";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHesapNo.Location = new System.Drawing.Point(151, 95);
            this.lblHesapNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(210, 24);
            this.lblHesapNo.TabIndex = 9;
            this.lblHesapNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hesap No";
            // 
            // lblHesapID
            // 
            this.lblHesapID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHesapID.Location = new System.Drawing.Point(151, 55);
            this.lblHesapID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHesapID.Name = "lblHesapID";
            this.lblHesapID.Size = new System.Drawing.Size(210, 24);
            this.lblHesapID.TabIndex = 7;
            this.lblHesapID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hesap ID";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(151, 226);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(210, 23);
            this.txtTutar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "İşlem Tutarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "İşlem Tipi";
            // 
            // cbIslemTipleri
            // 
            this.cbIslemTipleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTipleri.FormattingEnabled = true;
            this.cbIslemTipleri.Items.AddRange(new object[] {
            "yatan",
            "cekilen"});
            this.cbIslemTipleri.Location = new System.Drawing.Point(151, 288);
            this.cbIslemTipleri.Name = "cbIslemTipleri";
            this.cbIslemTipleri.Size = new System.Drawing.Size(210, 24);
            this.cbIslemTipleri.TabIndex = 15;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(202, 353);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(99, 30);
            this.btnTamam.TabIndex = 16;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frmParaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(432, 432);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.cbIslemTipleri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHesapID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmParaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para İşlemleri";
            this.Load += new System.EventHandler(this.frmParaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIslemTipleri;
        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.Label lblHesapNo;
        public System.Windows.Forms.Label lblHesapID;
    }
}