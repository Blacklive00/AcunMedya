namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    partial class SiparisForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMasaBilgi;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblMiktar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMasaBilgi = new Label();
            cmbUrunler = new ComboBox();
            nudMiktar = new NumericUpDown();
            btnEkle = new Button();
            dgvSiparisler = new DataGridView();
            lblToplamTutar = new Label();
            btnOdeme = new Button();
            btnKapat = new Button();
            lblMiktar = new Label();
            cmbUrunGruplari = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            SuspendLayout();
            // 
            // lblMasaBilgi
            // 
            lblMasaBilgi.AutoSize = true;
            lblMasaBilgi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMasaBilgi.Location = new Point(20, 15);
            lblMasaBilgi.Name = "lblMasaBilgi";
            lblMasaBilgi.Size = new Size(227, 32);
            lblMasaBilgi.TabIndex = 0;
            lblMasaBilgi.Text = "Masa No: X, Kat: Y";
            // 
            // cmbUrunler
            // 
            cmbUrunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrunler.FormattingEnabled = true;
            cmbUrunler.Location = new Point(20, 60);
            cmbUrunler.Name = "cmbUrunler";
            cmbUrunler.Size = new Size(200, 28);
            cmbUrunler.TabIndex = 1;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(290, 58);
            nudMiktar.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(50, 27);
            nudMiktar.TabIndex = 3;
            nudMiktar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(371, 61);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 25);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.AllowUserToAddRows = false;
            dgvSiparisler.AllowUserToDeleteRows = false;
            dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Location = new Point(20, 100);
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.ReadOnly = true;
            dgvSiparisler.RowHeadersWidth = 51;
            dgvSiparisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisler.Size = new Size(600, 250);
            dgvSiparisler.TabIndex = 5;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblToplamTutar.Location = new Point(20, 365);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(151, 28);
            lblToplamTutar.TabIndex = 6;
            lblToplamTutar.Text = "Toplam: 0,00 ₺";
            // 
            // btnOdeme
            // 
            btnOdeme.Location = new Point(540, 360);
            btnOdeme.Name = "btnOdeme";
            btnOdeme.Size = new Size(80, 30);
            btnOdeme.TabIndex = 7;
            btnOdeme.Text = "Ödeme";
            btnOdeme.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(630, 360);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(80, 30);
            btnKapat.TabIndex = 8;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(230, 63);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(54, 20);
            lblMiktar.TabIndex = 2;
            lblMiktar.Text = "Miktar:";
            // 
            // cmbUrunGruplari
            // 
            cmbUrunGruplari.FormattingEnabled = true;
            cmbUrunGruplari.Location = new Point(469, 66);
            cmbUrunGruplari.Name = "cmbUrunGruplari";
            cmbUrunGruplari.Size = new Size(151, 28);
            cmbUrunGruplari.TabIndex = 9;
            // 
            // SiparisForm
            // 
            ClientSize = new Size(841, 452);
            Controls.Add(cmbUrunGruplari);
            Controls.Add(lblMasaBilgi);
            Controls.Add(cmbUrunler);
            Controls.Add(lblMiktar);
            Controls.Add(nudMiktar);
            Controls.Add(btnEkle);
            Controls.Add(dgvSiparisler);
            Controls.Add(lblToplamTutar);
            Controls.Add(btnOdeme);
            Controls.Add(btnKapat);
            Name = "SiparisForm";
            Text = "Sipariş";
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private ComboBox cmbUrunGruplari;
    }
}
