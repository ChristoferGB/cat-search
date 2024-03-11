namespace cat_search
{
    partial class FirstWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstWindow));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            buscarRaçasToolStripMenuItem = new ToolStripMenuItem();
            meusFavoritosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gato;
            pictureBox1.Location = new Point(134, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 277);
            label1.Name = "label1";
            label1.Size = new Size(259, 30);
            label1.TabIndex = 1;
            label1.Text = "Bem-vindo ao Cat Search";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscarRaçasToolStripMenuItem, meusFavoritosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(452, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            buscarRaçasToolStripMenuItem.Size = new Size(87, 20);
            buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            buscarRaçasToolStripMenuItem.Click += buscarRaçasToolStripMenuItem_Click;
            // 
            // meusFavoritosToolStripMenuItem
            // 
            meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            meusFavoritosToolStripMenuItem.Size = new Size(99, 20);
            meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            meusFavoritosToolStripMenuItem.Click += meusFavoritosToolStripMenuItem_Click;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 393);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FirstWindow";
            Text = "Cat Search";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private ToolStripMenuItem meusFavoritosToolStripMenuItem;
    }
}