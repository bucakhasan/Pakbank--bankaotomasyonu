using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakbank
{
    public partial class frmHesapDokumu : Form
    {
        public frmHesapDokumu()
        {
            InitializeComponent();
        }
        public static string HesapID = "";
        public static string HesapNo = "";
        Font fntBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntDetay = new Font("Times New Roman", 12, FontStyle.Regular);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void frmHesapDokumu_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 20;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if(txtHesapNo.Text.Trim() != "")
            {
                HesapBilgileriGoster();
                HesapHareketleriGoster();
                ToplamlariGoster();
            }
        }
        private void HesapBilgileriGoster()
        {
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunansatir = DosyaOku.ReadLine();
            while (okunansatir != null)
            {
                string[] Degerler = okunansatir.Split(';');
                if (txtHesapNo.Text == Degerler[1])
                {
                    txtAdi.Text = Degerler[3];
                    txtSoyadi.Text = Degerler[4];
                    txtTCKNo.Text = Degerler[5];
                    txtHesapTuru.Text = Degerler[7];
                    txtTarih.Text = Degerler[2];
                    break;
                }
                okunansatir = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
        private void HesapHareketleriGoster()
        {
            lvHareketler.Items.Clear();
            StreamReader DosyaOku = new StreamReader("HesapHareketleri.txt");
            string okunansatir = DosyaOku.ReadLine();
            int i = 0;
            while (okunansatir != null)
            {
                string[] Degerler = okunansatir.Split(';');
                if (txtHesapNo.Text == Degerler[1])
                {
                    lvHareketler.Items.Add(Degerler[0]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[1]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[2]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[3]);
                    lvHareketler.Items[i].SubItems.Add(Degerler[4]);
                    i++;
                }
                okunansatir = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
        }
        private void ToplamlariGoster()
        {
            double ToplamYatan = 0;
            double ToplamCekilen = 0;
            for (int i = 0; i < lvHareketler.Items.Count; i++)
            {
                if (lvHareketler.Items[i].SubItems[4].Text == "yatan")
                    ToplamYatan += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
                else if (lvHareketler.Items[i].SubItems[4].Text == "cekilen")
                    ToplamCekilen += Convert.ToDouble(lvHareketler.Items[i].SubItems[3].Text);
            }
            txtToplamYatan.Text = ToplamYatan.ToString();
            txtToplamCekilen.Text = ToplamCekilen.ToString();
            txtBakiye.Text = (ToplamYatan - ToplamCekilen).ToString();
        }
        private void btnPara_Click(object sender, EventArgs e)
        {
            //HesapID = lvHareketler.Items[0].SubItems[0].Text;
            //HesapNo = txtHesapNo.Text;
            frmParaIslemleri frm = new frmParaIslemleri();
            //Formlardaki kontroller default olarak private tanımlanırlar. Erişim belirleyicileri (modifiers) public yapılarak o formun kontrollerine başka formlardan (class) erişilebilir.
            //frm.lblHesapID.Text = lvHareketler.Items[0].SubItems[0].Text;
            //frm.lblHesapNo.Text = lvHareketler.Items[0].SubItems[1].Text;
            frm.HesapBilgileri(lvHareketler.Items[0].SubItems[0].Text, lvHareketler.Items[0].SubItems[1].Text);
            frm.ShowDialog();
            //ParaIslemleri formu kapatıldıktan sonra program burdan çalışmaya devam eder.
            HesapHareketleriGoster();
            ToplamlariGoster();
            //btnBul_Click(sender, e);
        }
        private void btnYazici_Click(object sender, EventArgs e)
        {
            ppdHesapDokumu.ShowDialog();          
        }
        int k = 0;
        private void pDocHesapDokumu_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntDetay, sb, 700, 100, fmt);
            e.Graphics.DrawString("Müşteri : " + txtAdi.Text + " " + txtSoyadi.Text, fntDetay, sb, 100, 100, fmt);
            e.Graphics.DrawString("Hesap No: " + txtHesapNo.Text, fntDetay, sb, 100, 120, fmt);
            e.Graphics.DrawString("HESAP DÖKÜMÜ", fntBaslik, sb, 300, 140, fmt);
            e.Graphics.DrawString("  ID    Hesap No      İşlem Tarihi      İşlem Tutarı     İşlem Tipi", fntBaslik, sb, 100, 180, fmt);
            e.Graphics.DrawString("_______________________________________________________", fntBaslik, sb, 100, 190, fmt);
            int j = 0;
            for (int i = k; i < lvHareketler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[0].Text, fntDetay, sb, 112, 220 + j * 25, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[1].Text, fntDetay, sb, 177, 220 + j * 25, fmt);
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[2].Text, fntDetay, sb, 300, 220 + j * 25, fmt);
                fmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[3].Text, fntDetay, sb, 530, 220 + j * 25, fmt);
                fmt.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(lvHareketler.Items[i].SubItems[4].Text, fntDetay, sb, 600, 220 + j * 25, fmt);
                k++;
                j++;
                if (i % 30 == 0 && i !=0)
                {
                    e.HasMorePages = true; //yeni sayfaya geçer.
                    return;
                }
                else
                    e.HasMorePages = false; //aynı sayfaya yazar.
            }
            e.Graphics.DrawString("_______________________________________________________", fntBaslik, sb, 100, 220 + j * 25, fmt);
            j++;
            e.Graphics.DrawString("Toplam Yatan  ", fntBaslik, sb, 300, 220 + j * 25, fmt);
            fmt.Alignment = StringAlignment.Far;
            //e.Graphics.DrawString(string.Format("{0:C}", Convert.ToDouble(txtToplamYatan.Text)), fntBaslik, sb, 530, 220 + j * 25, fmt);
            //e.Graphics.DrawString(string.Format("{0:#,##0.00}", Convert.ToDouble(txtToplamYatan.Text)), fntBaslik, sb, 530, 220 + j * 25, fmt);
            e.Graphics.DrawString(string.Format("{0:#,##0}", Convert.ToDouble(txtToplamYatan.Text)), fntBaslik, sb, 530, 220 + j * 25, fmt);
            fmt.Alignment = StringAlignment.Near;
            j++;
            e.Graphics.DrawString("Toplam Çekilen ", fntBaslik, sb, 300, 220 + j * 25, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(string.Format("{0:#,##0}", Convert.ToDouble(txtToplamCekilen.Text)), fntBaslik, sb, 530, 220 + j * 25, fmt);
            fmt.Alignment = StringAlignment.Near;
            j++;
            e.Graphics.DrawString("Bakiye ", fntBaslik, sb, 300, 220 + j * 25, fmt);
            fmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(string.Format("{0:#,##0}", Convert.ToDouble(txtBakiye.Text)), fntBaslik, sb, 530, 220 + j * 25, fmt);
            fmt.Alignment = StringAlignment.Near;
            k = 0;
        }


    }
}
