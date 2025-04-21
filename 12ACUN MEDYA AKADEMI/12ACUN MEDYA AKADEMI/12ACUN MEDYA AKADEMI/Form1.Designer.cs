namespace _12ACUN_MEDYA_AKADEMI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbOdemeYontemleri = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOdemeYontemleri
            // 
            this.cmbOdemeYontemleri.FormattingEnabled = true;
            this.cmbOdemeYontemleri.Location = new System.Drawing.Point(287, 85);
            this.cmbOdemeYontemleri.Name = "cmbOdemeYontemleri";
            this.cmbOdemeYontemleri.Size = new System.Drawing.Size(121, 24);
            this.cmbOdemeYontemleri.TabIndex = 0;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(104, 85);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 1;
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(147, 227);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(156, 90);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("MS PGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(108, 167);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(300, 16);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "label1";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cmbOdemeYontemleri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdemeYontemleri;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label lblSonuc;
    }
}

