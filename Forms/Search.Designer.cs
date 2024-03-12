namespace cat_search.Forms
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbTemperament = new Label();
            lbOrigin = new Label();
            lbDescription = new Label();
            cbListBreeds = new ComboBox();
            btnSearch = new Button();
            btnFavorite = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 30);
            label1.TabIndex = 0;
            label1.Text = "Encontre Sua Raça Favorita";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(429, 45);
            label2.TabIndex = 1;
            label2.Text = "Utilize a caixa de seleção de raças para buscar características sobre determinado gatinho e descobrir qual é a sua raça favorita";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 1);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 160);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 3;
            label3.Text = "Raça do Gato";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(103, 210);
            label4.Name = "label4";
            label4.Size = new Size(89, 40);
            label4.TabIndex = 3;
            label4.Text = "Temperamento";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(103, 250);
            label5.Name = "label5";
            label5.Size = new Size(89, 40);
            label5.TabIndex = 3;
            label5.Text = "Origem";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(103, 287);
            label6.Name = "label6";
            label6.Size = new Size(89, 40);
            label6.TabIndex = 3;
            label6.Text = "Descrição";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTemperament
            // 
            lbTemperament.Location = new Point(198, 210);
            lbTemperament.Name = "lbTemperament";
            lbTemperament.Size = new Size(224, 40);
            lbTemperament.TabIndex = 3;
            lbTemperament.Text = "Resultado";
            lbTemperament.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbOrigin
            // 
            lbOrigin.Location = new Point(198, 247);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(224, 40);
            lbOrigin.TabIndex = 3;
            lbOrigin.Text = "Resultado";
            lbOrigin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDescription
            // 
            lbDescription.Location = new Point(198, 287);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(224, 40);
            lbDescription.TabIndex = 3;
            lbDescription.Text = "Resultado";
            lbDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbListBreeds
            // 
            cbListBreeds.DropDownHeight = 96;
            cbListBreeds.FormattingEnabled = true;
            cbListBreeds.IntegralHeight = false;
            cbListBreeds.Location = new Point(198, 157);
            cbListBreeds.Name = "cbListBreeds";
            cbListBreeds.Size = new Size(121, 23);
            cbListBreeds.TabIndex = 4;
            cbListBreeds.SelectedValueChanged += cbListBreeds_SelectedValueChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(266, 347);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(347, 347);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(75, 23);
            btnFavorite.TabIndex = 5;
            btnFavorite.Text = "Favoritar";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 393);
            Controls.Add(btnFavorite);
            Controls.Add(btnSearch);
            Controls.Add(cbListBreeds);
            Controls.Add(lbDescription);
            Controls.Add(label6);
            Controls.Add(lbOrigin);
            Controls.Add(label5);
            Controls.Add(lbTemperament);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Search";
            Text = "Buscar uma Raça";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbTemperament;
        private Label lbOrigin;
        private Label lbDescription;
        private ComboBox cbListBreeds;
        private Button btnSearch;
        private Button btnFavorite;
    }
}