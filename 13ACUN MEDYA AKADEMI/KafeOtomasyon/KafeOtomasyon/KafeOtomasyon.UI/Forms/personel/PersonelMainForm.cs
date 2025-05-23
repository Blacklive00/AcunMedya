using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KafeOtomasyon.KafeOtomasyon.UI.Forms.masa;
using KafeOtomasyon.KafeOtomasyon.UI.Forms.stok;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    public partial class PersonelMainForm : Form
    {
        public PersonelMainForm()
        {
            InitializeComponent();
        }

        private void ürünStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form stok= Application.OpenForms["StokEkleForm"];

            if (stok == null)
            {
                stok = new StokEkleForm();
                stok.Show();
            }
            else
            {
                stok.BringToFront();
                stok.WindowState = FormWindowState.Normal;
                stok.Show();
            }

            this.Hide();

            stok.FormClosed += (s, args) => this.Show();
        }
    }
}
