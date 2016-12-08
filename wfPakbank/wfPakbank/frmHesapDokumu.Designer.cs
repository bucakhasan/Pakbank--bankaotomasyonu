namespace wfPakbank
{
    partial class frmHesapDokumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapDokumu));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtHesapTuru = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTCKNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamCekilen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamYatan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnYazici = new System.Windows.Forms.Button();
            this.pDocHesapDokumu = new System.Drawing.Printing.PrintDocument();
            this.ppdHesapDokumu = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(207, 55);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(143, 26);
            this.txtHesapNo.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(356, 56);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(51, 26);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(207, 224);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.ReadOnly = true;
            this.txtHesapTuru.Size = new System.Drawing.Size(200, 26);
            this.txtHesapTuru.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hesap Türü";
            // 
            // txtTCKNo
            // 
            this.txtTCKNo.Location = new System.Drawing.Point(207, 192);
            this.txtTCKNo.Name = "txtTCKNo";
            this.txtTCKNo.ReadOnly = true;
            this.txtTCKNo.Size = new System.Drawing.Size(200, 26);
            this.txtTCKNo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "TCKNo";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(207, 160);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(200, 26);
            this.txtSoyadi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Soyadı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(207, 128);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.ReadOnly = true;
            this.txtAdi.Size = new System.Drawing.Size(200, 26);
            this.txtAdi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adı";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(207, 256);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(200, 26);
            this.txtTarih.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Açılış Tarihi";
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHareketler.GridLines = true;
            this.lvHareketler.Location = new System.Drawing.Point(13, 295);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(541, 198);
            this.lvHareketler.TabIndex = 24;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hesap No";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Tarihi";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşlem Tutarı";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem Tipi";
            this.columnHeader5.Width = 114;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(129, 566);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(130, 26);
            this.txtBakiye.TabIndex = 30;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 566);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bakiye";
            // 
            // txtToplamCekilen
            // 
            this.txtToplamCekilen.Location = new System.Drawing.Point(129, 534);
            this.txtToplamCekilen.Name = "txtToplamCekilen";
            this.txtToplamCekilen.ReadOnly = true;
            this.txtToplamCekilen.Size = new System.Drawing.Size(130, 26);
            this.txtToplamCekilen.TabIndex = 28;
            this.txtToplamCekilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 534);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Toplam Çekilen";
            // 
            // txtToplamYatan
            // 
            this.txtToplamYatan.Location = new System.Drawing.Point(129, 502);
            this.txtToplamYatan.Name = "txtToplamYatan";
            this.txtToplamYatan.ReadOnly = true;
            this.txtToplamYatan.Size = new System.Drawing.Size(130, 26);
            this.txtToplamYatan.TabIndex = 26;
            this.txtToplamYatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 502);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Toplam Yatan";
            // 
            // btnPara
            // 
            this.btnPara.Location = new System.Drawing.Point(410, 521);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(144, 33);
            this.btnPara.TabIndex = 31;
            this.btnPara.Text = "Para İşlemleri";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // btnYazici
            // 
            this.btnYazici.Location = new System.Drawing.Point(410, 563);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(144, 33);
            this.btnYazici.TabIndex = 32;
            this.btnYazici.Text = "Yazıcıya Gönder";
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // pDocHesapDokumu
            // 
            this.pDocHesapDokumu.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocHesapDokumu_PrintPage);
            // 
            // ppdHesapDokumu
            // 
            this.ppdHesapDokumu.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHesapDokumu.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHesapDokumu.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHesapDokumu.Document = this.pDocHesapDokumu;
            this.ppdHesapDokumu.Enabled = true;
            this.ppdHesapDokumu.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHesapDokumu.Icon")));
            this.ppdHesapDokumu.Name = "ppdHesapDokumu";
            this.ppdHesapDokumu.Visible = false;
            // 
            // frmHesapDokumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(566, 596);
            this.Controls.Add(this.btnYazici);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToplamCekilen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToplamYatan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvHareketler);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHesapTuru);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTCKNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHesapDokumu";
            this.Text = "Hesap Dökümü";
            this.Load += new System.EventHandler(this.frmHesapDokumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtHesapTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTCKNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamCekilen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamYatan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnYazici;
        private System.Drawing.Printing.PrintDocument pDocHesapDokumu;
        private System.Windows.Forms.PrintPreviewDialog ppdHesapDokumu;
    }
}