namespace Game
{
    partial class FormMain
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
            panelPicture = new Panel();
            picture = new PictureBox();
            panelMatchingLetters = new Panel();
            labelOutMatchingLetters = new Label();
            labelMatchingLetters = new Label();
            panelNoMatchingLetters = new Panel();
            labelOutNoMatchingLetters = new Label();
            label2 = new Label();
            panel1 = new Panel();
            CountingErrors = new TextBox();
            InputWord = new TextBox();
            buttonCheck = new Button();
            SecretWord = new TextBox();
            panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            panelMatchingLetters.SuspendLayout();
            panelNoMatchingLetters.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPicture
            // 
            panelPicture.BorderStyle = BorderStyle.Fixed3D;
            panelPicture.Controls.Add(picture);
            panelPicture.Dock = DockStyle.Top;
            panelPicture.Location = new Point(0, 0);
            panelPicture.Margin = new Padding(4);
            panelPicture.Name = "panelPicture";
            panelPicture.Padding = new Padding(20);
            panelPicture.Size = new Size(984, 465);
            panelPicture.TabIndex = 0;
            // 
            // picture
            // 
            picture.Dock = DockStyle.Fill;
            picture.Image = Properties.Resources._11;
            picture.Location = new Point(20, 20);
            picture.Margin = new Padding(4);
            picture.Name = "picture";
            picture.Size = new Size(940, 421);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // panelMatchingLetters
            // 
            panelMatchingLetters.Controls.Add(labelOutMatchingLetters);
            panelMatchingLetters.Controls.Add(labelMatchingLetters);
            panelMatchingLetters.Dock = DockStyle.Left;
            panelMatchingLetters.Location = new Point(0, 465);
            panelMatchingLetters.Margin = new Padding(4);
            panelMatchingLetters.Name = "panelMatchingLetters";
            panelMatchingLetters.Padding = new Padding(20);
            panelMatchingLetters.Size = new Size(300, 196);
            panelMatchingLetters.TabIndex = 1;
            // 
            // labelOutMatchingLetters
            // 
            labelOutMatchingLetters.AutoSize = true;
            labelOutMatchingLetters.Dock = DockStyle.Fill;
            labelOutMatchingLetters.Location = new Point(20, 60);
            labelOutMatchingLetters.Name = "labelOutMatchingLetters";
            labelOutMatchingLetters.Size = new Size(0, 21);
            labelOutMatchingLetters.TabIndex = 2;
            // 
            // labelMatchingLetters
            // 
            labelMatchingLetters.Dock = DockStyle.Top;
            labelMatchingLetters.Location = new Point(20, 20);
            labelMatchingLetters.Margin = new Padding(4, 0, 4, 0);
            labelMatchingLetters.Name = "labelMatchingLetters";
            labelMatchingLetters.Padding = new Padding(0, 0, 0, 20);
            labelMatchingLetters.Size = new Size(260, 40);
            labelMatchingLetters.TabIndex = 0;
            labelMatchingLetters.Text = "Совпавшие буквы";
            labelMatchingLetters.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelNoMatchingLetters
            // 
            panelNoMatchingLetters.Controls.Add(labelOutNoMatchingLetters);
            panelNoMatchingLetters.Controls.Add(label2);
            panelNoMatchingLetters.Dock = DockStyle.Right;
            panelNoMatchingLetters.Location = new Point(684, 465);
            panelNoMatchingLetters.Margin = new Padding(4);
            panelNoMatchingLetters.Name = "panelNoMatchingLetters";
            panelNoMatchingLetters.Padding = new Padding(20);
            panelNoMatchingLetters.Size = new Size(300, 196);
            panelNoMatchingLetters.TabIndex = 3;
            // 
            // labelOutNoMatchingLetters
            // 
            labelOutNoMatchingLetters.AutoSize = true;
            labelOutNoMatchingLetters.Dock = DockStyle.Fill;
            labelOutNoMatchingLetters.Location = new Point(20, 60);
            labelOutNoMatchingLetters.Name = "labelOutNoMatchingLetters";
            labelOutNoMatchingLetters.Size = new Size(0, 21);
            labelOutNoMatchingLetters.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(20, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 20);
            label2.Size = new Size(260, 40);
            label2.TabIndex = 0;
            label2.Text = "Не совпавшие буквы";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CountingErrors);
            panel1.Controls.Add(InputWord);
            panel1.Controls.Add(buttonCheck);
            panel1.Controls.Add(SecretWord);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(300, 465);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(384, 196);
            panel1.TabIndex = 2;
            // 
            // CountingErrors
            // 
            CountingErrors.Location = new Point(20, 98);
            CountingErrors.Name = "CountingErrors";
            CountingErrors.Size = new Size(193, 29);
            CountingErrors.TabIndex = 3;
            // 
            // InputWord
            // 
            InputWord.Dock = DockStyle.Fill;
            InputWord.Location = new Point(20, 49);
            InputWord.Margin = new Padding(4);
            InputWord.Name = "InputWord";
            InputWord.Size = new Size(246, 29);
            InputWord.TabIndex = 1;
            InputWord.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCheck
            // 
            buttonCheck.Dock = DockStyle.Right;
            buttonCheck.Location = new Point(266, 49);
            buttonCheck.Margin = new Padding(4);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(96, 125);
            buttonCheck.TabIndex = 2;
            buttonCheck.Text = "Проверка";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += ButtonCheck_Click;
            // 
            // SecretWord
            // 
            SecretWord.Dock = DockStyle.Top;
            SecretWord.Enabled = false;
            SecretWord.Location = new Point(20, 20);
            SecretWord.Margin = new Padding(4);
            SecretWord.Name = "SecretWord";
            SecretWord.ReadOnly = true;
            SecretWord.Size = new Size(342, 29);
            SecretWord.TabIndex = 0;
            SecretWord.Text = "_ _ _ _ _ _ _";
            SecretWord.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Controls.Add(panelNoMatchingLetters);
            Controls.Add(panelMatchingLetters);
            Controls.Add(panelPicture);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            panelMatchingLetters.ResumeLayout(false);
            panelMatchingLetters.PerformLayout();
            panelNoMatchingLetters.ResumeLayout(false);
            panelNoMatchingLetters.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPicture;
        private PictureBox picture;
        private Panel panelMatchingLetters;
        private Panel panelNoMatchingLetters;
        private Label labelMatchingLetters;
        private Label label2;
        private Panel panel1;
        private TextBox SecretWord;
        private TextBox InputWord;
        private Button buttonCheck;
        private Label labelOutMatchingLetters;
        private Label labelOutNoMatchingLetters;
        private TextBox CountingErrors;
    }
}
