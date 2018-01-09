using A8CFManyToMany.DAL;
using A8CFManyToMany.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A8CFManyToMany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = Enum.GetNames(typeof(Cinsiyetler));
            VerileriGetir();
        }
        void VerileriGetir()
        {
            try
            {
                MyContext db = new MyContext();
                lstOgrenci.DataSource = db.Ogrenciler.ToList();
                lstDersler.DataSource = db.Dersler.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                db.Ogrenciler.Add(new Ogrenci
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString())
                });
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOgrenci.SelectedItem == null) return;

            var seciliOgrenci = lstOgrenci.SelectedItem as Ogrenci;
            txtAd.Text = seciliOgrenci.Ad;
            txtSoyad.Text = seciliOgrenci.Soyad;
            dtpDogumTarihi.Value = seciliOgrenci.DogumTarihi;
            cmbCinsiyet.SelectedIndex = (byte)seciliOgrenci.Cinsiyet;
            OgrenciDersleriDoldur(seciliOgrenci.OgrenciID);
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MyContext db = new MyContext();
                db.Dersler.Add(new Ders()
                {
                    DersAdi = txtDersAdi.Text,
                    Kredi = Convert.ToByte(nKredi.Value)
                });
                db.SaveChanges();
                VerileriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDersler.SelectedItem == null) return;
            var seciliDers = lstDersler.SelectedItem as Ders;
            txtDersAdi.Text = seciliDers.DersAdi;
            nKredi.Value = seciliDers.Kredi;
        }
        void OgrenciDersleriDoldur(int ogrenciID)
        {
            try
            {
                MyContext db = new MyContext();
                clstOgrenciDersleri.Items.Clear();
                db.Dersler.ToList().ForEach(x => clstOgrenciDersleri.Items.Add(x));
                var ogrencininDersleri = db.DersOgrenciler.Where(x => x.OgrenciID == ogrenciID).ToList();
                lblToplamKredi.Text = "Toplam Kredi: " + ogrencininDersleri.Sum(x => x.Ders.Kredi);

                if (ogrencininDersleri.Count == 0) return;

                foreach (var ogrDers in ogrencininDersleri)
                {
                    for (int i = 0; i < clstOgrenciDersleri.Items.Count; i++)
                    {
                        Ders ders = clstOgrenciDersleri.Items[i] as Ders;
                        if (ders.DersID == ogrDers.DersID)
                            clstOgrenciDersleri.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDersOnayla_Click(object sender, EventArgs e)
        {
            if (lstOgrenci.SelectedItem == null)
            {
                MessageBox.Show("Önce öğrenciyi seçiniz");
                return;
            }
            var ogrenciId = (lstOgrenci.SelectedItem as Ogrenci).OgrenciID;

            if (clstOgrenciDersleri.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bu işlemi yapabilmek için öncelikle ders seçmelisiniz");
                return;
            }
            try
            {
                MyContext db = new MyContext();
                var mevcutDersler = db.DersOgrenciler.Where(x => x.OgrenciID == ogrenciId).ToList();
                var secilenDersler = new List<Ders>();
                foreach (Ders item in clstOgrenciDersleri.CheckedItems)
                {
                    secilenDersler.Add(item);
                }
                foreach (Ders secilenDers in secilenDersler)
                {
                    if (!mevcutDersler.Any(x => x.DersID == secilenDers.DersID))
                    {
                        db.DersOgrenciler.Add(new DersOgrenci()
                        {
                            DersID = secilenDers.DersID,
                            OgrenciID = ogrenciId
                        });
                    }
                }
                foreach (DersOgrenci item in mevcutDersler)
                {
                    if (!secilenDersler.Any(x => x.DersID == item.DersID))
                    {
                        db.DersOgrenciler.Remove(item);
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Ders kayıt işlemi başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clstOgrenciDersleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Ders item in clstOgrenciDersleri.CheckedItems)
            {
                total += item.Kredi;
            }
            lblToplamKredi.Text = "Toplam Kredi: " + total;
        }
    }
}
