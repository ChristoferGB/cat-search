using cat_search.Forms;

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
            menu = new MenuStrip();
            searchBreedsToolStripMenuItem = new ToolStripMenuItem();
            myFavoritesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu.SuspendLayout();
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
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 270);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Cat Search";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { searchBreedsToolStripMenuItem, myFavoritesToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(452, 24);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            // 
            // searchBreedsToolStripMenuItem
            // 
            searchBreedsToolStripMenuItem.Name = "searchBreedsToolStripMenuItem";
            searchBreedsToolStripMenuItem.Size = new Size(92, 20);
            searchBreedsToolStripMenuItem.Text = "Search Breeds";
            searchBreedsToolStripMenuItem.Click += searchBreedsToolStripMenuItem_Click;
            // 
            // myFavoritesToolStripMenuItem
            // 
            myFavoritesToolStripMenuItem.Name = "myFavoritesToolStripMenuItem";
            myFavoritesToolStripMenuItem.Size = new Size(86, 20);
            myFavoritesToolStripMenuItem.Text = "My Favorites";
            myFavoritesToolStripMenuItem.Click += myFavoritesToolStripMenuItem_Click;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 393);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "FirstWindow";
            Text = "Cat Search";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private MenuStrip menu;
        private ToolStripMenuItem searchBreedsToolStripMenuItem;
        private ToolStripMenuItem myFavoritesToolStripMenuItem;
    }
}