namespace Game
{
    partial class FormDefeat
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
            TopTextBoxDefeat = new TextBox();
            FillButtonDefeat = new Button();
            SuspendLayout();
            // 
            // TopTextBoxDefeat
            // 
            TopTextBoxDefeat.Dock = DockStyle.Top;
            TopTextBoxDefeat.Location = new Point(0, 0);
            TopTextBoxDefeat.Margin = new Padding(4);
            TopTextBoxDefeat.Name = "TopTextBoxDefeat";
            TopTextBoxDefeat.Size = new Size(191, 29);
            TopTextBoxDefeat.TabIndex = 0;
            TopTextBoxDefeat.Text = "Поражение";
            TopTextBoxDefeat.TextAlign = HorizontalAlignment.Center;
            // 
            // FillButtonDefeat
            // 
            FillButtonDefeat.Dock = DockStyle.Fill;
            FillButtonDefeat.Location = new Point(0, 29);
            FillButtonDefeat.Margin = new Padding(2, 3, 2, 3);
            FillButtonDefeat.Name = "FillButtonDefeat";
            FillButtonDefeat.Size = new Size(191, 59);
            FillButtonDefeat.TabIndex = 1;
            FillButtonDefeat.Text = "Выход";
            FillButtonDefeat.UseVisualStyleBackColor = true;
            FillButtonDefeat.Click += FillButtonDefeat_Click;
            // 
            // FormDefeat
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(191, 88);
            Controls.Add(FillButtonDefeat);
            Controls.Add(TopTextBoxDefeat);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormDefeat";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TopTextBoxDefeat;
        private Button FillButtonDefeat;
    }
}