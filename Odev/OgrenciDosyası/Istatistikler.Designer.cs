namespace Odev.OgrenciDosyası {
    partial class Istatistikler {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            ogrenciListeleToolStripMenuItem = new ToolStripMenuItem();
            ıstatistiklerToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            progressBarErkek = new ProgressBar();
            progressBarKadin = new ProgressBar();
            listBoxDogumYili = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogrenciEkleToolStripMenuItem, ogrenciListeleToolStripMenuItem, ıstatistiklerToolStripMenuItem });
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(60, 24);
            ToolStripMenuItem.Text = "Menu";
            // 
            // ogrenciEkleToolStripMenuItem
            // 
            ogrenciEkleToolStripMenuItem.Name = "ogrenciEkleToolStripMenuItem";
            ogrenciEkleToolStripMenuItem.Size = new Size(224, 26);
            ogrenciEkleToolStripMenuItem.Text = "Ogrenci Ekle";
            ogrenciEkleToolStripMenuItem.Click += ogrenciEkleToolStripMenuItem_Click;
            // 
            // ogrenciListeleToolStripMenuItem
            // 
            ogrenciListeleToolStripMenuItem.Name = "ogrenciListeleToolStripMenuItem";
            ogrenciListeleToolStripMenuItem.Size = new Size(224, 26);
            ogrenciListeleToolStripMenuItem.Text = "Ogrenci Listele";
            ogrenciListeleToolStripMenuItem.Click += ogrenciListeleToolStripMenuItem_Click;
            // 
            // ıstatistiklerToolStripMenuItem
            // 
            ıstatistiklerToolStripMenuItem.Name = "ıstatistiklerToolStripMenuItem";
            ıstatistiklerToolStripMenuItem.Size = new Size(224, 26);
            ıstatistiklerToolStripMenuItem.Text = "Istatistikler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 67);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // progressBarErkek
            // 
            progressBarErkek.Location = new Point(504, 58);
            progressBarErkek.Name = "progressBarErkek";
            progressBarErkek.Size = new Size(192, 29);
            progressBarErkek.TabIndex = 2;
            // 
            // progressBarKadin
            // 
            progressBarKadin.Location = new Point(504, 126);
            progressBarKadin.Name = "progressBarKadin";
            progressBarKadin.Size = new Size(192, 30);
            progressBarKadin.TabIndex = 3;
            // 
            // listBoxDogumYili
            // 
            listBoxDogumYili.FormattingEnabled = true;
            listBoxDogumYili.Location = new Point(131, 201);
            listBoxDogumYili.Name = "listBoxDogumYili";
            listBoxDogumYili.Size = new Size(283, 164);
            listBoxDogumYili.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 67);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 5;
            label2.Text = "Erkek oranı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 136);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 6;
            label3.Text = "Kadin Orani:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 269);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 7;
            label4.Text = "Dogum Gunleri:";
            // 
            // Istatistikler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxDogumYili);
            Controls.Add(progressBarKadin);
            Controls.Add(progressBarErkek);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Istatistikler";
            Text = "Istatistikler";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkleToolStripMenuItem;
        private ToolStripMenuItem ogrenciListeleToolStripMenuItem;
        private ToolStripMenuItem ıstatistiklerToolStripMenuItem;
        private Label label1;
        private ProgressBar progressBarErkek;
        private ProgressBar progressBarKadin;
        private ListBox listBoxDogumYili;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}