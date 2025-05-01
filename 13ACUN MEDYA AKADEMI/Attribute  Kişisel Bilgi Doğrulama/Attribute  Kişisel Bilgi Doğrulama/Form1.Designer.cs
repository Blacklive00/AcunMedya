namespace Attribute__Kişisel_Bilgi_Doğrulama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDogrula = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(166, 95);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(166, 132);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(166, 177);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 102);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 139);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğrenci Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 184);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci Bölümü";
            // 
            // btnDogrula
            // 
            btnDogrula.Location = new Point(485, 108);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(94, 29);
            btnDogrula.TabIndex = 6;
            btnDogrula.Text = "button1";
            btnDogrula.UseVisualStyleBackColor = true;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(394, 268);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(50, 20);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnDogrula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDogrula;
        private Label lblSonuc;
    }
}
