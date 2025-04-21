namespace _11ACUN_MEDYA_AKADEMI
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
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(12, 410);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(157, 72);
            this.btnKlasorSec.TabIndex = 0;
            this.btnKlasorSec.Text = "Klasör Seç";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // lstClasses
            // 
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.ItemHeight = 16;
            this.lstClasses.Location = new System.Drawing.Point(3, 1);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(300, 388);
            this.lstClasses.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 542);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstClasses);
            this.Controls.Add(this.btnKlasorSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

