namespace MemoTest
{
    partial class Menu
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
            panelMenu = new Panel();
            btExit = new Button();
            btPlay = new Button();
            label1 = new Label();
            panelCategories = new Panel();
            btCountries = new Button();
            btBibleCaracters = new Button();
            btFootball = new Button();
            label3 = new Label();
            btAnimals = new Button();
            label2 = new Label();
            panelMenu.SuspendLayout();
            panelCategories.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btExit);
            panelMenu.Controls.Add(btPlay);
            panelMenu.Controls.Add(label1);
            panelMenu.Location = new Point(1, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(544, 595);
            panelMenu.TabIndex = 0;
            // 
            // btExit
            // 
            btExit.BackColor = Color.Black;
            btExit.BackgroundImageLayout = ImageLayout.None;
            btExit.FlatStyle = FlatStyle.Popup;
            btExit.Font = new Font("Viner Hand ITC", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btExit.ForeColor = Color.LightSteelBlue;
            btExit.Location = new Point(165, 348);
            btExit.Name = "btExit";
            btExit.Size = new Size(217, 82);
            btExit.TabIndex = 2;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // btPlay
            // 
            btPlay.BackColor = Color.Black;
            btPlay.BackgroundImageLayout = ImageLayout.None;
            btPlay.FlatStyle = FlatStyle.Popup;
            btPlay.Font = new Font("Viner Hand ITC", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btPlay.ForeColor = Color.LightSteelBlue;
            btPlay.Location = new Point(165, 213);
            btPlay.Name = "btPlay";
            btPlay.Size = new Size(217, 82);
            btPlay.TabIndex = 1;
            btPlay.Text = "Play";
            btPlay.UseVisualStyleBackColor = false;
            btPlay.Click += btCategories_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PowderBlue;
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 60);
            label1.TabIndex = 0;
            label1.Text = "Memorium";
            // 
            // panelCategories
            // 
            panelCategories.BackColor = Color.Black;
            panelCategories.Controls.Add(btCountries);
            panelCategories.Controls.Add(btBibleCaracters);
            panelCategories.Controls.Add(btFootball);
            panelCategories.Controls.Add(label3);
            panelCategories.Controls.Add(btAnimals);
            panelCategories.Controls.Add(label2);
            panelCategories.Location = new Point(0, 2);
            panelCategories.Name = "panelCategories";
            panelCategories.Size = new Size(542, 595);
            panelCategories.TabIndex = 3;
            // 
            // btCountries
            // 
            btCountries.BackColor = Color.Black;
            btCountries.BackgroundImageLayout = ImageLayout.None;
            btCountries.FlatStyle = FlatStyle.Popup;
            btCountries.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btCountries.ForeColor = Color.LightSteelBlue;
            btCountries.Location = new Point(165, 446);
            btCountries.Name = "btCountries";
            btCountries.Size = new Size(217, 82);
            btCountries.TabIndex = 6;
            btCountries.Text = "Countries";
            btCountries.UseVisualStyleBackColor = false;
            // 
            // btBibleCaracters
            // 
            btBibleCaracters.BackColor = Color.Black;
            btBibleCaracters.BackgroundImageLayout = ImageLayout.None;
            btBibleCaracters.FlatStyle = FlatStyle.Popup;
            btBibleCaracters.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btBibleCaracters.ForeColor = Color.LightSteelBlue;
            btBibleCaracters.Location = new Point(165, 330);
            btBibleCaracters.Name = "btBibleCaracters";
            btBibleCaracters.Size = new Size(217, 110);
            btBibleCaracters.TabIndex = 5;
            btBibleCaracters.Text = "Bible Caracters";
            btBibleCaracters.UseVisualStyleBackColor = false;
            // 
            // btFootball
            // 
            btFootball.BackColor = Color.Black;
            btFootball.BackgroundImageLayout = ImageLayout.None;
            btFootball.FlatStyle = FlatStyle.Popup;
            btFootball.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btFootball.ForeColor = Color.LightSteelBlue;
            btFootball.Location = new Point(165, 242);
            btFootball.Name = "btFootball";
            btFootball.Size = new Size(217, 82);
            btFootball.TabIndex = 4;
            btFootball.Text = "Football";
            btFootball.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.PowderBlue;
            label3.Location = new Point(189, 69);
            label3.Name = "label3";
            label3.Size = new Size(172, 47);
            label3.TabIndex = 3;
            label3.Text = "Categories:";
            // 
            // btAnimals
            // 
            btAnimals.BackColor = Color.Black;
            btAnimals.BackgroundImageLayout = ImageLayout.None;
            btAnimals.FlatStyle = FlatStyle.Popup;
            btAnimals.Font = new Font("Viner Hand ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btAnimals.ForeColor = Color.LightSteelBlue;
            btAnimals.Location = new Point(165, 154);
            btAnimals.Name = "btAnimals";
            btAnimals.Size = new Size(217, 82);
            btAnimals.TabIndex = 2;
            btAnimals.Text = "Animals";
            btAnimals.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.PowderBlue;
            label2.Location = new Point(165, 9);
            label2.Name = "label2";
            label2.Size = new Size(217, 60);
            label2.TabIndex = 0;
            label2.Text = "Memorium";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 595);
            Controls.Add(panelCategories);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelCategories.ResumeLayout(false);
            panelCategories.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Label label1;
        private Button btPlay;
        private Button btExit;
        private Panel panelCategories;
        private Label label3;
        private Button btAnimals;
        private Label label2;
        private Button btCountries;
        private Button btBibleCaracters;
        private Button btFootball;
    }
}