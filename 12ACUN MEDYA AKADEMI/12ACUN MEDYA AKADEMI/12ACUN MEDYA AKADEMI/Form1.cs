using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

namespace _12ACUN_MEDYA_AKADEMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {

            lblSonuc.Text = "";

            if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                lblSonuc.Text = "Lütfen geçerli bir tutar girin.";
                return;
            }
            if (cmbOdemeYontemleri.SelectedItem == null)
            {
                lblSonuc.Text = "Lütfen bir yöntem seçin.";
                return;
            }

            string secilenTipAdi = cmbOdemeYontemleri.SelectedItem.ToString();
            // Tipi al
            Type tip = Type.GetType(secilenTipAdi);
            if (tip == null)
            {
                lblSonuc.Text = "Tür bulunamadı.";
                return;
            }
            // Nesneyi yarat
            var nesne = Activator.CreateInstance(tip) as IOdemeYontemi;
            if (nesne == null)
            {
                lblSonuc.Text = "Ödeme yöntemi oluşturulamadı.";
                return;
            }

            // Öde metodunu çağır
            string sonuc = nesne.Ode(tutar);
            lblSonuc.Text = sonuc;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bu assembly içindeki tüm tipleri tara
            var odemeTipleri = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t)
                            && t.IsClass && !t.IsAbstract)
                .ToList();

            foreach (var tip in odemeTipleri)
            {
                // İstersen FullName yerine sadece tip.Name kullan
                cmbOdemeYontemleri.Items.Add(tip.FullName);
            }
        }
    }
}
