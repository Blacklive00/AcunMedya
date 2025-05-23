namespace KafeOtomasyon.KafeOtomasyon.UI.Forms.Urun
{
    partial class UrunEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUrunSil = new Button();
            btnUrunGuncelle = new Button();
            dgvUrunler = new DataGridView();
            btnUrunEkle = new Button();
            cmbUrunGrubu = new ComboBox();
            txtFiyat = new TextBox();
            txtUrunAdi = new TextBox();
            lblStokArtis = new Label();
            numStokArtis = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStokArtis).BeginInit();
            SuspendLayout();
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(137, 312);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(140, 64);
            btnUrunSil.TabIndex = 13;
            btnUrunSil.Text = "sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.Location = new Point(25, 330);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(94, 29);
            btnUrunGuncelle.TabIndex = 12;
            btnUrunGuncelle.Text = "güncelle";
            btnUrunGuncelle.UseVisualStyleBackColor = true;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(340, 26);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(437, 399);
            dgvUrunler.TabIndex = 11;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(25, 237);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(140, 64);
            btnUrunEkle.TabIndex = 10;
            btnUrunEkle.Text = "UrunEkle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // cmbUrunGrubu
            // 
            cmbUrunGrubu.FormattingEnabled = true;
            cmbUrunGrubu.Items.AddRange(new object[] { "Admin", "Personel" });
            cmbUrunGrubu.Location = new Point(25, 163);
            cmbUrunGrubu.Name = "cmbUrunGrubu";
            cmbUrunGrubu.Size = new Size(170, 28);
            cmbUrunGrubu.TabIndex = 9;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(25, 111);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(169, 27);
            txtFiyat.TabIndex = 8;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(24, 55);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(170, 27);
            txtUrunAdi.TabIndex = 7;
            // 
            // lblStokArtis
            // 
            lblStokArtis.AutoSize = true;
            lblStokArtis.Location = new Point(247, 181);
            lblStokArtis.Name = "lblStokArtis";
            lblStokArtis.Size = new Size(85, 20);
            lblStokArtis.TabIndex = 14;
            lblStokArtis.Text = "lblStokArtis";
            // 
            // numStokArtis
            // 
            numStokArtis.Location = new Point(184, 240);
            numStokArtis.Name = "numStokArtis";
            numStokArtis.Size = new Size(150, 27);
            numStokArtis.TabIndex = 15;
            // 
            // UrunEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numStokArtis);
            Controls.Add(lblStokArtis);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunGuncelle);
            Controls.Add(dgvUrunler);
            Controls.Add(btnUrunEkle);
            Controls.Add(cmbUrunGrubu);
            Controls.Add(txtFiyat);
            Controls.Add(txtUrunAdi);
            Name = "UrunEkleForm";
            Text = "UrunEkleForm";
            Load += UrunEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStokArtis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUrunSil;
        private Button btnUrunGuncelle;
        private DataGridView dgvUrunler;
        private Button btnUrunEkle;
        private ComboBox cmbUrunGrubu;
        private TextBox txtFiyat;
        private TextBox txtUrunAdi;
        private Label lblStokArtis;
        private NumericUpDown numStokArtis;
    }
}