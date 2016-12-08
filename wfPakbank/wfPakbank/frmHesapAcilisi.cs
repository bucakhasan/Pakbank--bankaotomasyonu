using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace wfPakbank
{
    public partial class frmHesapAcilisi : Form
    {
        public frmHesapAcilisi()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void frmHesapAcilisi_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 20;
            lblTarih.Text = DateTime.Now.ToShortDateString();
            cbHesapTurleri.SelectedIndex = 0;
            SonIDBul();
            HesapNumarasiOlustur();
        }
        private void SonIDBul()
        {
            StreamWriter DosyaOlustur = new StreamWriter("HesapKartlari.txt", true);
            DosyaOlustur.Close();

            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunansatir = DosyaOku.ReadLine();
            if (okunansatir == null)
                lblHesapID.Text = "1";
            else
            {
                //string[] Degerler = new string[okunansatir.Split(';').Length];
                while (okunansatir != null)
                {
                    string[] Degerler = okunansatir.Split(';'); //Her bir müşteri kaydındaki bilgileri ; sembolüne göre parçalara ayırır, herbir parçayı string bir diziye atar.
                    lblHesapID.Text = (Convert.ToInt32(Degerler[0]) + 1).ToString();
                    okunansatir = DosyaOku.ReadLine();
                }
                   
            }DosyaOku.Close(); 
        }
        private void HesapNumarasiOlustur()
        {
            bool Varmi = false;
            do
            {
                Varmi = HesapVarmi();
            } while (Varmi);
        }
        private bool HesapVarmi()
        {
            lblHesapNo.Text = "ACC" + rnd.Next(1000, 10000);
            StreamReader DosyaOku = new StreamReader("HesapKartlari.txt");
            string okunansatir = DosyaOku.ReadLine();
            while (okunansatir != null)
            {
                string[] Degerler = okunansatir.Split(';'); 
                if(lblHesapNo.Text == Degerler[1])
                {
                    DosyaOku.Close();
                    ///*HesapNumarasiOlustur(); /*//recursive methods (kendini çağıran metotlar)
                    return true;
                }
                okunansatir = DosyaOku.ReadLine();
            }
            DosyaOku.Close();
            return false;
        }
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            StreamWriter HesapAc = new StreamWriter("HesapKartlari.txt", true);
            HesapAc.WriteLine(lblHesapID.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtAdi.Text + ";" + txtSoyadi.Text + ";" + txtTCKNo.Text + ";" + txtBakiye.Text + ";" + cbHesapTurleri.SelectedItem.ToString());
            HesapAc.Close();

            StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
            HareketYaz.WriteLine(lblHesapID.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtBakiye.Text + ";" + "yatan");
            HareketYaz.Close();

            MessageBox.Show("Hesap Bilgileri oluşturuldu.");
            Temizle();
            SonIDBul();
            HesapNumarasiOlustur();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCKNo.Clear();
            txtBakiye.Clear();
            txtAdi.Focus();
        }
    }
}
