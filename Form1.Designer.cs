namespace CatchButton
{
    partial class Form1
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
            target = new Button();
            SuspendLayout();
            // 
            // target
            // 
            target.BackColor = SystemColors.ScrollBar;
            target.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            target.ForeColor = Color.DarkRed;
            target.Location = new Point(182, 152);
            target.Name = "target";
            target.Size = new Size(426, 134);
            target.TabIndex = 0;
            target.Text = "나를 잡아봐";
            target.UseVisualStyleBackColor = false;
            target.Click += target_Click;
            target.MouseClick += target_MouseClick;
            target.MouseEnter += target_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(target);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button target;
    }
}
