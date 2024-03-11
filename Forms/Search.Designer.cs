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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbListSpecies = new ComboBox();
            button1 = new Button();
            button2 = new Button();
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
            // label7
            // 
            label7.Location = new Point(198, 210);
            label7.Name = "label7";
            label7.Size = new Size(121, 40);
            label7.TabIndex = 3;
            label7.Text = "Resultado";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(198, 250);
            label8.Name = "label8";
            label8.Size = new Size(121, 40);
            label8.TabIndex = 3;
            label8.Text = "Resultado";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(198, 287);
            label9.Name = "label9";
            label9.Size = new Size(121, 40);
            label9.TabIndex = 3;
            label9.Text = "Resultado";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbListSpecies
            // 
            cbListSpecies.FormattingEnabled = true;
            cbListSpecies.Items.AddRange(new object[] { "Selecione uma Raça", "Abyssinian", "Aegean", "American Bobtail", "American Curl", "American Shorthair", "American Wirehair", "Arabian Mau", "Australian Mist", "Balinese" });
            cbListSpecies.Location = new Point(198, 157);
            cbListSpecies.Name = "cbListSpecies";
            cbListSpecies.Size = new Size(121, 23);
            cbListSpecies.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(266, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(347, 347);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Favoritar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 393);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbListSpecies);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label7);
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
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbListSpecies;
        private Button button1;
        private Button button2;
    }
}