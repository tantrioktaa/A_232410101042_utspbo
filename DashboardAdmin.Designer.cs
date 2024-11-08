namespace A_232410101042_utspbo.View
{
    partial class DashboardAdmin
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
            label3 = new Label();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            txtNoHP = new TextBox();
            btnKontakBaru = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 148);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 203);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 256);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "NoHP:";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(204, 145);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(449, 27);
            txtNama.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(204, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(449, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(204, 253);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(449, 27);
            txtNoHP.TabIndex = 5;
            // 
            // btnKontakBaru
            // 
            btnKontakBaru.Location = new Point(559, 354);
            btnKontakBaru.Name = "btnKontakBaru";
            btnKontakBaru.Size = new Size(94, 29);
            btnKontakBaru.TabIndex = 6;
            btnKontakBaru.Text = "Tambah";
            btnKontakBaru.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(283, 45);
            label4.Name = "label4";
            label4.Size = new Size(223, 38);
            label4.TabIndex = 7;
            label4.Text = "Tambah Kontak";
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnKontakBaru);
            Controls.Add(txtNoHP);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNama;
        private TextBox txtEmail;
        private TextBox txtNoHP;
        private Button btnKontakBaru;
        private Label label4;
    }
}