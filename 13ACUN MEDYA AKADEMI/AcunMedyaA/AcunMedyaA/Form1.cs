using System.Xml.Serialization;
using Newtonsoft.Json;

namespace AcunMedyaA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Employe emp = new Employe
            {
                Name = txtad.Text,
                Phone = texttel.Text,
                DoB = dt1.Value,
                Department = txtdepartman.Text,
                Salary = Convert.ToInt32(txtmaas.Text),
                AdditionalInfo = "serileþme istiyoruz "



            };

            XmlSerializer xs = new XmlSerializer(typeof(Employe));
            FileStream fsout = new FileStream("deneme.xml", FileMode.Create, FileAccess.Write, FileShare.None);


            try
            {
                using (fsout)
                {
                    //serileþtirme iþlemi burada 
                    xs.Serialize(fsout, emp);
                    txtad.Text = "";
                    texttel.Text = "";
                    txtdepartman.Text = "";
                    txtmaas.Text = "";
                    dt1.Value = DateTime.Now;
                    MessageBox.Show("Kayýt Baþarýlý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fsout.Close();
            }




        }

        private void btnxmldeserialize_Click(object sender, EventArgs e)
        {
            Employe emp = new Employe();
            XmlSerializer xs = new XmlSerializer(typeof(Employe));
            FileStream fsin = new FileStream("deneme.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    emp = (Employe)xs.Deserialize(fsin);
                    txtad.Text = emp.Name;
                    texttel.Text = emp.Phone;
                    txtdepartman.Text = emp.Department;
                    txtmaas.Text = emp.Salary.ToString();
                    dt1.Value = emp.DoB;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fsin.Close();
            }

        }

        private void btnjsonoluþtur_Click(object sender, EventArgs e)
        {



        }
    }
}