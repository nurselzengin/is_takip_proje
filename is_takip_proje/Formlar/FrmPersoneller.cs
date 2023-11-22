using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        Dbis_TakipEntities1 db = new Dbis_TakipEntities1();
        void Personeller() 
        {
            var degerler = from x in db.TblPersonel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               x.Departman
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Personeller();

            var departmanlar = (from x in db.TblDepartmanlar
                                select new
                                {
                                    x.ID,
                                    x.Ad
                                }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }
    }
}
