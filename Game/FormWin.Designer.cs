namespace Game
{
    partial class FormWin
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
            textBoxTop = new TextBox();
            buttonFill = new Button();
            SuspendLayout();
            // 
            // textBoxTop
            // 
            textBoxTop.Dock = DockStyle.Top;
            textBoxTop.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTop.Location = new Point(0, 0);
            textBoxTop.Margin = new Padding(0);
            textBoxTop.Multiline = true;
            textBoxTop.Name = "textBoxTop";
            textBoxTop.Size = new Size(237, 70);
            textBoxTop.TabIndex = 0;
            textBoxTop.Text = "Победил";
            textBoxTop.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonFill
            // 
            buttonFill.Dock = DockStyle.Fill;
            buttonFill.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFill.Location = new Point(0, 70);
            buttonFill.Name = "buttonFill";
            buttonFill.Size = new Size(237, 88);
            buttonFill.TabIndex = 1;
            buttonFill.Text = "Выход";
            buttonFill.UseVisualStyleBackColor = true;
            buttonFill.Click += buttonFill_Click;
            // 
            // FormWin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(237, 158);
            Controls.Add(buttonFill);
            Controls.Add(textBoxTop);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormWin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormWin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTop;
        private Button buttonFill;
    }
}