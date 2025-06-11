namespace Odev.OgrenciDosyası {
    partial class OgrenciListele {
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
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
            // 
            // ıstatistiklerToolStripMenuItem
            // 
            ıstatistiklerToolStripMenuItem.Name = "ıstatistiklerToolStripMenuItem";
            ıstatistiklerToolStripMenuItem.Size = new Size(224, 26);
            ıstatistiklerToolStripMenuItem.Text = "Istatistikler";
            ıstatistiklerToolStripMenuItem.Click += ıstatistiklerToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(573, 381);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(624, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBoxFilter_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(660, 98);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Filtre";
            // 
            // OgrenciListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "OgrenciListele";
            Text = "OgrenciListele";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkleToolStripMenuItem;
        private ToolStripMenuItem ogrenciListeleToolStripMenuItem;
        private ToolStripMenuItem ıstatistiklerToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
    }
}