namespace KafeOtomasyon.KafeOtomasyon.UI.Forms.stok
{
    partial class StokEkleForm
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
            nudStokMiktar = new NumericUpDown();
            lblStokMiktar = new Label();
            dgvUrunler = new DataGridView();
            btnStokEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStokMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // nudStokMiktar
            // 
            nudStokMiktar.Location = new Point(104, 240);
            nudStokMiktar.Name = "nudStokMiktar";
            nudStokMiktar.Size = new Size(150, 27);
            nudStokMiktar.TabIndex = 18;
            nudStokMiktar.ValueChanged += nudStokMiktar_ValueChanged;
            // 
            // lblStokMiktar
            // 
            lblStokMiktar.AutoSize = true;
            lblStokMiktar.Location = new Point(140, 150);
            lblStokMiktar.Name = "lblStokMiktar";
            lblStokMiktar.Size = new Size(85, 20);
            lblStokMiktar.TabIndex = 17;
            lblStokMiktar.Text = "lblStokArtis";
            lblStokMiktar.Click += lblStokMiktar_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(260, 26);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(437, 399);
            dgvUrunler.TabIndex = 16;
            dgvUrunler.CellContentClick += dgvUrunler_CellContentClick;
            // 
            // btnStokEkle
            // 
            btnStokEkle.Location = new Point(93, 309);
            btnStokEkle.Name = "btnStokEkle";
            btnStokEkle.Size = new Size(132, 98);
            btnStokEkle.TabIndex = 19;
            btnStokEkle.Text = "StokEkle";
            btnStokEkle.UseVisualStyleBackColor = true;
            btnStokEkle.Click += button1_Click;
            // 
            // StokEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStokEkle);
            Controls.Add(nudStokMiktar);
            Controls.Add(lblStokMiktar);
            Controls.Add(dgvUrunler);
            Name = "StokEkleForm";
            Text = "StokEkleForm";
            Load += StokEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudStokMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudStokMiktar;
        private Label lblStokMiktar;
        private DataGridView dgvUrunler;
        private Button btnStokEkle;
    }
}