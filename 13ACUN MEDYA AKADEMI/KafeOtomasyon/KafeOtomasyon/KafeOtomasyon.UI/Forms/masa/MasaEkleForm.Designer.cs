namespace KafeOtomasyon.KafeOtomasyon.UI.Forms.masa
{
    partial class MasaEkleForm
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
            btnMasaSil = new System.Windows.Forms.Button();
            btnMasaGuncelle = new System.Windows.Forms.Button();
            dgvMasalar = new System.Windows.Forms.DataGridView();
            btnMasaEkle = new System.Windows.Forms.Button();
            cmbKat = new System.Windows.Forms.ComboBox();
            cmbDurum = new System.Windows.Forms.ComboBox();
            txtmasano = new System.Windows.Forms.TextBox();
            labelMasaNo = new System.Windows.Forms.Label();
            labelKat = new System.Windows.Forms.Label();
            labelDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(dgvMasalar)).BeginInit();
            SuspendLayout();
            // 
            // btnMasaSil
            // 
            btnMasaSil.Location = new System.Drawing.Point(137, 312);
            btnMasaSil.Name = "btnMasaSil";
            btnMasaSil.Size = new System.Drawing.Size(140, 64);
            btnMasaSil.TabIndex = 20;
            btnMasaSil.Text = "Sil";
            btnMasaSil.UseVisualStyleBackColor = true;
            btnMasaSil.Click += btnMasaSil_Click;
            // 
            // btnMasaGuncelle
            // 
            btnMasaGuncelle.Location = new System.Drawing.Point(25, 330);
            btnMasaGuncelle.Name = "btnMasaGuncelle";
            btnMasaGuncelle.Size = new System.Drawing.Size(94, 29);
            btnMasaGuncelle.TabIndex = 19;
            btnMasaGuncelle.Text = "Güncelle";
            btnMasaGuncelle.UseVisualStyleBackColor = true;
            btnMasaGuncelle.Click += btnMasaGuncelle_Click;
            // 
            // dgvMasalar
            // 
            dgvMasalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasalar.Location = new System.Drawing.Point(340, 26);
            dgvMasalar.Name = "dgvMasalar";
            dgvMasalar.RowHeadersWidth = 51;
            dgvMasalar.Size = new System.Drawing.Size(437, 399);
            dgvMasalar.TabIndex = 18;
            dgvMasalar.CellClick += DgvMasalar_CellClick;
            // 
            // btnMasaEkle
            // 
            btnMasaEkle.Location = new System.Drawing.Point(25, 237);
            btnMasaEkle.Name = "btnMasaEkle";
            btnMasaEkle.Size = new System.Drawing.Size(140, 64);
            btnMasaEkle.TabIndex = 17;
            btnMasaEkle.Text = "Masa Ekle";
            btnMasaEkle.UseVisualStyleBackColor = true;
            btnMasaEkle.Click += btnMasaEkle_Click;
            // 
            // cmbKat
            // 
            cmbKat.FormattingEnabled = true;
            cmbKat.Items.AddRange(new object[] { "0", "1", "2", "3" });
            cmbKat.Location = new System.Drawing.Point(25, 163);
            cmbKat.Name = "cmbKat";
            cmbKat.Size = new System.Drawing.Size(170, 28);
            cmbKat.TabIndex = 16;
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Bos", "Dolu", "Rezerve" });
            cmbDurum.Location = new System.Drawing.Point(25, 111);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new System.Drawing.Size(170, 28);
            cmbDurum.TabIndex = 15;
            // 
            // txtmasano
            // 
            txtmasano.Location = new System.Drawing.Point(25, 55);
            txtmasano.Name = "txtmasano";
            txtmasano.Size = new System.Drawing.Size(170, 27);
            txtmasano.TabIndex = 14;
            // 
            // labelMasaNo
            // 
            labelMasaNo.AutoSize = true;
            labelMasaNo.Location = new System.Drawing.Point(25, 32);
            labelMasaNo.Name = "labelMasaNo";
            labelMasaNo.Size = new System.Drawing.Size(68, 20);
            labelMasaNo.TabIndex = 21;
            labelMasaNo.Text = "Masa No:";
            // 
            // labelDurum
            // 
            labelDurum.AutoSize = true;
            labelDurum.Location = new System.Drawing.Point(25, 88);
            labelDurum.Name = "labelDurum";
            labelDurum.Size = new System.Drawing.Size(55, 20);
            labelDurum.TabIndex = 22;
            labelDurum.Text = "Durum:";
            // 
            // labelKat
            // 
            labelKat.AutoSize = true;
            labelKat.Location = new System.Drawing.Point(25, 140);
            labelKat.Name = "labelKat";
            labelKat.Size = new System.Drawing.Size(32, 20);
            labelKat.TabIndex = 23;
            labelKat.Text = "Kat:";
            // 
            // MasaEkleForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(labelKat);
            Controls.Add(labelDurum);
            Controls.Add(labelMasaNo);
            Controls.Add(btnMasaSil);
            Controls.Add(btnMasaGuncelle);
            Controls.Add(dgvMasalar);
            Controls.Add(btnMasaEkle);
            Controls.Add(cmbKat);
            Controls.Add(cmbDurum);
            Controls.Add(txtmasano);
            Name = "MasaEkleForm";
            Text = "Masa Ekleme";
            Load += MasaEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)(dgvMasalar)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnMasaSil;
        private System.Windows.Forms.Button btnMasaGuncelle;
        private System.Windows.Forms.DataGridView dgvMasalar;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox txtmasano;
        private System.Windows.Forms.Label labelMasaNo;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Label labelKat;
    }
}
