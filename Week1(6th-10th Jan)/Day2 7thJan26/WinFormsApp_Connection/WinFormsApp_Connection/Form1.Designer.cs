namespace WinFormsApp_Connection
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
            ConBtn = new Button();
            SuspendLayout();
            // 
            // ConBtn
            // 
            ConBtn.Location = new Point(457, 252);
            ConBtn.Name = "ConBtn";
            ConBtn.Size = new Size(150, 46);
            ConBtn.TabIndex = 0;
            ConBtn.Text = "Connection";
            ConBtn.UseVisualStyleBackColor = true;
            ConBtn.Click += ConBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 831);
            Controls.Add(ConBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ConBtn;
    }
}
