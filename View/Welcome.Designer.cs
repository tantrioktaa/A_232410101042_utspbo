namespace A_232410101042_utspbo.View
{
    partial class Welcome
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
            label1 = new Label();
            label2 = new Label();
            cbWelcome = new ComboBox();
            btnWelcome = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 35);
            label1.Name = "label1";
            label1.Size = new Size(271, 62);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 128);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 1;
            label2.Text = "Pilih untuk melanjutkan:";
            // 
            // cbWelcome
            // 
            cbWelcome.BackColor = Color.WhiteSmoke;
            cbWelcome.FormattingEnabled = true;
            cbWelcome.Location = new Point(280, 167);
            cbWelcome.Name = "cbWelcome";
            cbWelcome.Size = new Size(217, 28);
            cbWelcome.TabIndex = 2;
            // 
            // btnWelcome
            // 
            btnWelcome.Location = new Point(633, 237);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(94, 29);
            btnWelcome.TabIndex = 3;
            btnWelcome.Text = "Lanjut";
            btnWelcome.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 304);
            Controls.Add(btnWelcome);
            Controls.Add(cbWelcome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Welcome";
            Text = "Welcome";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbWelcome;
        private Button btnWelcome;
    }
}