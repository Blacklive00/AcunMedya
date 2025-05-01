namespace Attribute__Kişisel_Bilgi_Doğrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> OgrenciKontrolEt(Ogrenci ogrenci)
        {
            var hatalar = new List<string>();
            var ozellikler = ogrenci.GetType().GetProperties();

            foreach (var ozellik in ozellikler)
            {
                var attribute = (GerekliAlanAttribute)Attribute.GetCustomAttribute(ozellik, typeof(GerekliAlanAttribute));

                if (attribute != null)
                {
                    string deger = ozellik.GetValue(ogrenci) as string;

                    if (string.IsNullOrWhiteSpace(deger))
                    {
                        hatalar.Add(attribute.HataMesaji);
                    }
                }
            }

            return hatalar;
        }


        private void btnDogrula_Click(object sender, EventArgs e)
        {
            var ogrenci = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            var hatalar = OgrenciKontrolEt(ogrenci);

            if (hatalar.Count > 0)
            {
                MessageBox.Show(string.Join("\n", hatalar), "Doğrulama Hataları");
            }
            else
            {
                lblSonuc.Text = $"Öğrenci Bilgileri:\nAd: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nBölüm: {ogrenci.Bolum}";
            }
        }
    }
}

