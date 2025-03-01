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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRule
            // 
            buttonRule.Location = new Point(177, 19);
            buttonRule.Margin = new Padding(4);
            buttonRule.Name = "buttonRule";
            buttonRule.Size = new Size(150, 50);
            buttonRule.TabIndex = 0;
            buttonRule.Text = "Правила";
            buttonRule.UseVisualStyleBackColor = true;
            buttonRule.Click += buttonRule_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(19, 19);
            buttonPlay.Margin = new Padding(4);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(150, 50);
            buttonPlay.TabIndex = 1;
            buttonPlay.Text = "Играть";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(335, 19);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(150, 50);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonPlay);
            flowLayoutPanel1.Controls.Add(buttonRule);
            flowLayoutPanel1.Controls.Add(buttonExit);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15);
            flowLayoutPanel1.Size = new Size(504, 86);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 86);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRule;
        private Button buttonPlay;
        private Button buttonExit;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}