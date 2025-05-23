namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    partial class RaporlarForm
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
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            dgvRaporlar = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).BeginInit();
            SuspendLayout();
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(27, 251);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 0;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(27, 186);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 1;
            // 
            // dgvRaporlar
            // 
            dgvRaporlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaporlar.Location = new Point(340, 26);
            dgvRaporlar.Name = "dgvRaporlar";
            dgvRaporlar.RowHeadersWidth = 51;
            dgvRaporlar.Size = new Size(433, 397);
            dgvRaporlar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 158);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "BAŞLANGIÇ TARİHİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 228);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "BİTİŞTARİHİ";
            // 
            // button1
            // 
            button1.Location = new Point(62, 306);
            button1.Name = "button1";
            button1.Size = new Size(174, 64);
            button1.TabIndex = 2;
            button1.Text = "btnRaporGetir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RaporlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRaporlar);
            Controls.Add(button1);
            Controls.Add(dtpBaslangic);
            Controls.Add(dtpBitis);
            Name = "RaporlarForm";
            Text = "RaporlarForm";
            Load += RaporlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private DataGridView dgvRaporlar;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}