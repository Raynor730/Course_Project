namespace Game
{
    partial class FormMenu
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
            buttonRule = new Button();
            buttonPlay = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonRule
            // 
            buttonRule.Dock = DockStyle.Right;
            buttonRule.Location = new Point(194, 0);
            buttonRule.Margin = new Padding(4);
            buttonRule.Name = "buttonRule";
            buttonRule.Size = new Size(97, 105);
            buttonRule.TabIndex = 0;
            buttonRule.Text = "Rule";
            buttonRule.UseVisualStyleBackColor = true;
            buttonRule.Click += buttonRule_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Dock = DockStyle.Right;
            buttonPlay.Location = new Point(97, 0);
            buttonPlay.Margin = new Padding(4);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(97, 105);
            buttonPlay.TabIndex = 1;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Right;
            buttonExit.Location = new Point(0, 0);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(97, 105);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(291, 105);
            Controls.Add(buttonExit);
            Controls.Add(buttonPlay);
            Controls.Add(buttonRule);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRule;
        private Button buttonPlay;
        private Button buttonExit;
    }
}