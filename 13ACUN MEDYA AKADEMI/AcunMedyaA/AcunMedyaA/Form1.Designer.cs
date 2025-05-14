namespace AcunMedyaA
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dt1 = new DateTimePicker();
            txtad = new TextBox();
            texttel = new TextBox();
            txtdepartman = new TextBox();
            txtmaas = new TextBox();
            btnxmlserialize = new Button();
            btnxmldeserialize = new Button();
            button1 = new Button();
            btnjsonoluştur = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 59);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 112);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 182);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Departman";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 245);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Dogum Tarih";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 305);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 4;
            label5.Text = "Maaş";
            label5.Click += label5_Click;
            // 
            // dt1
            // 
            dt1.Location = new Point(356, 240);
            dt1.Name = "dt1";
            dt1.Size = new Size(210, 27);
            dt1.TabIndex = 10;
            // 
            // txtad
            // 
            txtad.Location = new Point(356, 59);
            txtad.Name = "txtad";
            txtad.Size = new Size(125, 27);
            txtad.TabIndex = 11;
            // 
            // texttel
            // 
            texttel.Location = new Point(356, 105);
            texttel.Name = "texttel";
            texttel.Size = new Size(125, 27);
            texttel.TabIndex = 12;
            // 
            // txtdepartman
            // 
            txtdepartman.Location = new Point(356, 175);
            txtdepartman.Name = "txtdepartman";
            txtdepartman.Size = new Size(125, 27);
            txtdepartman.TabIndex = 13;
            // 
            // txtmaas
            // 
            txtmaas.Location = new Point(356, 298);
            txtmaas.Name = "txtmaas";
            txtmaas.Size = new Size(125, 27);
            txtmaas.TabIndex = 13;
            // 
            // btnxmlserialize
            // 
            btnxmlserialize.Location = new Point(158, 404);
            btnxmlserialize.Name = "btnxmlserialize";
            btnxmlserialize.Size = new Size(123, 42);
            btnxmlserialize.TabIndex = 14;
            btnxmlserialize.Text = "xmlserialize";
            btnxmlserialize.UseVisualStyleBackColor = true;
            btnxmlserialize.Click += button1_Click;
            // 
            // btnxmldeserialize
            // 
            btnxmldeserialize.Location = new Point(431, 404);
            btnxmldeserialize.Name = "btnxmldeserialize";
            btnxmldeserialize.Size = new Size(135, 42);
            btnxmldeserialize.TabIndex = 15;
            btnxmldeserialize.Text = "xmldeserialize";
            btnxmldeserialize.UseVisualStyleBackColor = true;
            btnxmldeserialize.Click += btnxmldeserialize_Click;
            // 
            // button1
            // 
            button1.Location = new Point(433, 454);
            button1.Name = "button1";
            button1.Size = new Size(133, 46);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnjsonoluştur
            // 
            btnjsonoluştur.Location = new Point(158, 454);
            btnjsonoluştur.Name = "btnjsonoluştur";
            btnjsonoluştur.Size = new Size(123, 46);
            btnjsonoluştur.TabIndex = 17;
            btnjsonoluştur.Text = "jeson oluştur";
            btnjsonoluştur.UseVisualStyleBackColor = true;
            btnjsonoluştur.Click += btnjsonoluştur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 546);
            Controls.Add(btnjsonoluştur);
            Controls.Add(button1);
            Controls.Add(btnxmldeserialize);
            Controls.Add(btnxmlserialize);
            Controls.Add(txtmaas);
            Controls.Add(txtdepartman);
            Controls.Add(texttel);
            Controls.Add(txtad);
            Controls.Add(dt1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dt1;
        private TextBox txtad;
        private TextBox texttel;
        private TextBox txtdepartman;
        private TextBox txtmaas;
        private Button btnxmlserialize;
        private Button btnxmldeserialize;
        private Button button1;
        private Button btnjsonoluştur;
    }
}
