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


namespace _11ACUN_MEDYA_AKADEMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnKlasorSec.Click += btnKlasorSec_Click;
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            lstClasses.Items.Clear();

            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                return;

            string anaKlasor = folderBrowserDialog1.SelectedPath;
            lstClasses.Items.Add("📁 " + Path.GetFileName(anaKlasor));

            foreach (string klasor in Directory.GetDirectories(anaKlasor))
            {
                string klasorAdi = Path.GetFileName(klasor);
                lstClasses.Items.Add("📁 " + klasorAdi);

                foreach (string dosya in Directory.GetFiles(klasor, "*.cs"))
                {

                    foreach (string satir in File.ReadAllLines(dosya))
                    {
                        string trim = satir.Trim();
                   
                        if (trim.StartsWith("class "))
                        {
                        
                            string[] parçalar = trim.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                            if (parçalar.Length >= 2)
                            {
                                string classAdi = parçalar[1];
                                lstClasses.Items.Add("   📄 " + classAdi);
                            }
                            break; 
                        }
                    }
                }
            }

        }
    }
}
