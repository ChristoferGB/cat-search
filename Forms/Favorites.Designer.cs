namespace cat_search.Forms
{
    partial class Favorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorites));
            lboxFavorites = new ListBox();
            btnDeleteFavorite = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lboxFavorites
            // 
            lboxFavorites.FormattingEnabled = true;
            lboxFavorites.ItemHeight = 15;
            lboxFavorites.Location = new Point(44, 121);
            lboxFavorites.Name = "lboxFavorites";
            lboxFavorites.Size = new Size(362, 214);
            lboxFavorites.TabIndex = 6;
            // 
            // btnDeleteFavorite
            // 
            btnDeleteFavorite.Location = new Point(297, 351);
            btnDeleteFavorite.Name = "btnDeleteFavorite";
            btnDeleteFavorite.Size = new Size(109, 30);
            btnDeleteFavorite.TabIndex = 7;
            btnDeleteFavorite.Text = "Delete Favorite";
            btnDeleteFavorite.UseVisualStyleBackColor = true;
            btnDeleteFavorite.Click += btnDeleteFavorite_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 1);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(429, 37);
            label2.TabIndex = 4;
            label2.Text = "Here you'll find a list of your favorite breeds";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 3;
            label1.Text = "My Favorites";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(44, 351);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(95, 30);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Go to Search";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // Favorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 393);
            Controls.Add(btnReturn);
            Controls.Add(btnDeleteFavorite);
            Controls.Add(lboxFavorites);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Favorites";
            Text = "Favorites";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lboxFavorites;
        private Button btnDeleteFavorite;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnReturn;
    }
}