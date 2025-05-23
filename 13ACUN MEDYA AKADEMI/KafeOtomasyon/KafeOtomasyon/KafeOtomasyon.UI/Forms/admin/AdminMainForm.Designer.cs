namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    partial class AdminMainForm
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
            menuStrip1 = new MenuStrip();
            kişiEkleToolStripMenuItem = new ToolStripMenuItem();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            masalarToolStripMenuItem = new ToolStripMenuItem();
            raporToolStripMenuItem = new ToolStripMenuItem();
            ürünStokEkleToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanelMasalar = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kişiEkleToolStripMenuItem, ürünlerToolStripMenuItem, masalarToolStripMenuItem, raporToolStripMenuItem, ürünStokEkleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(944, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kişiEkleToolStripMenuItem
            // 
            kişiEkleToolStripMenuItem.Name = "kişiEkleToolStripMenuItem";
            kişiEkleToolStripMenuItem.Size = new Size(75, 24);
            kişiEkleToolStripMenuItem.Text = "kişi ekle";
            kişiEkleToolStripMenuItem.Click += kişiEkleToolStripMenuItem_Click;
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(73, 24);
            ürünlerToolStripMenuItem.Text = "ürünler ";
            ürünlerToolStripMenuItem.Click += ürünlerToolStripMenuItem_Click;
            // 
            // masalarToolStripMenuItem
            // 
            masalarToolStripMenuItem.Name = "masalarToolStripMenuItem";
            masalarToolStripMenuItem.Size = new Size(75, 24);
            masalarToolStripMenuItem.Text = "masalar";
            masalarToolStripMenuItem.Click += masalarToolStripMenuItem_Click;
            // 
            // raporToolStripMenuItem
            // 
            raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            raporToolStripMenuItem.Size = new Size(59, 24);
            raporToolStripMenuItem.Text = "rapor";
            raporToolStripMenuItem.Click += raporToolStripMenuItem_Click;
            // 
            // ürünStokEkleToolStripMenuItem
            // 
            ürünStokEkleToolStripMenuItem.Name = "ürünStokEkleToolStripMenuItem";
            ürünStokEkleToolStripMenuItem.Size = new Size(114, 24);
            ürünStokEkleToolStripMenuItem.Text = "ürün stok ekle";
            ürünStokEkleToolStripMenuItem.Click += ürünStokEkleToolStripMenuItem_Click;
            // 
            // flowLayoutPanelMasalar
            // 
            flowLayoutPanelMasalar.Location = new Point(0, 31);
            flowLayoutPanelMasalar.Name = "flowLayoutPanelMasalar";
            flowLayoutPanelMasalar.Size = new Size(944, 427);
            flowLayoutPanelMasalar.TabIndex = 1;
            flowLayoutPanelMasalar.Paint += flowLayoutPanelMasalar_Paint;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 461);
            Controls.Add(flowLayoutPanelMasalar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kişiEkleToolStripMenuItem;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem masalarToolStripMenuItem;
        private ToolStripMenuItem raporToolStripMenuItem;
        private ToolStripMenuItem ürünStokEkleToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanelMasalar;
    }
}