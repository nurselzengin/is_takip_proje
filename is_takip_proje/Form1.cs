using is_takip_proje.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class Form1 : Form
    {
        private Formlar.FrmDepartmanlar frmDepartmanlar;
        Formlar.FrmPersoneller frm2 = new Formlar.FrmPersoneller();

        public Form1()
        {
            InitializeComponent();
            frmDepartmanlar = new Formlar.FrmDepartmanlar();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDepartmanlar != null && !frmDepartmanlar.Visible)
            {
                frmDepartmanlar.MdiParent = this;
                frmDepartmanlar.Show();
            }
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 != null && !frm2.Visible)
            {
               
                frm2.MdiParent = this;
                frm2.Show();

            }

        }
    }
}
