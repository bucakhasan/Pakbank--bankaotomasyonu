using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfPakbank
{
    public partial class frmParaIslemleri : Form
    {
        public frmParaIslemleri()
        {
            InitializeComponent();
        }

        private void frmParaIslemleri_Load(object sender, EventArgs e)
        {
            //frmHesapDokumu frm = new frmHesapDokumu();
            //public static tanımlanan değişkenlere New ile class'ın örneği oluşturulmadan erişilebilir. (classAdı.ozellik)
            //lblHesapID.Text = frmHesapDokumu.HesapID;
            //lblHesapNo.Text = frmHesapDokumu.HesapNo;
            lblTarih.Text = DateTime.Now.ToShortDateString();
            cbIslemTipleri.SelectedIndex = 1;
            txtTutar.Focus();
        }
        public void HesapBilgileri(string HesapID, string HesapNo)
        {
            lblHesapID.Text = HesapID;
            lblHesapNo.Text = HesapNo;
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            StreamWriter HareketYaz = new StreamWriter("HesapHareketleri.txt", true);
            HareketYaz.WriteLine(lblHesapID.Text + ";" + lblHesapNo.Text + ";" + lblTarih.Text + ";" + txtTutar.Text + ";" + cbIslemTipleri.SelectedItem.ToString());
            HareketYaz.Close();

            MessageBox.Show("Para işlemleri kayıt edildi.");
            this.Close();
        }
    }
}
