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
            lboxFavourites = new ListBox();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lboxFavourites
            // 
            lboxFavourites.FormattingEnabled = true;
            lboxFavourites.ItemHeight = 15;
            lboxFavourites.Location = new Point(44, 121);
            lboxFavourites.Name = "lboxFavourites";
            lboxFavourites.Size = new Size(362, 214);
            lboxFavourites.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(297, 351);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 7;
            button1.Text = "Excluir Favorito";
            button1.UseVisualStyleBackColor = true;
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
            label2.Size = new Size(417, 37);
            label2.TabIndex = 4;
            label2.Text = "Aqui você encontra a listagem de raças favoritas";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 3;
            label1.Text = "Meus Favoritos";
            // 
            // Favorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 393);
            Controls.Add(button1);
            Controls.Add(lboxFavourites);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Favorites";
            Text = "Favoritos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lboxFavourites;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}