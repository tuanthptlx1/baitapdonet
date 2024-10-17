namespace WinFormsApp3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nhapuser = new TextBox();
            nhapemail = new TextBox();
            nhappass = new TextBox();
            button1 = new Button();
            dongydieukhoan = new CheckBox();
            anhien = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(334, 32);
            label1.Name = "label1";
            label1.Size = new Size(163, 46);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 121);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 174);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 226);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Pasword :";
            // 
            // nhapuser
            // 
            nhapuser.Location = new Point(291, 121);
            nhapuser.Name = "nhapuser";
            nhapuser.Size = new Size(308, 27);
            nhapuser.TabIndex = 4;
            nhapuser.TextChanged += nhapuser_TextChanged;
            // 
            // nhapemail
            // 
            nhapemail.Location = new Point(291, 171);
            nhapemail.Name = "nhapemail";
            nhapemail.Size = new Size(308, 27);
            nhapemail.TabIndex = 5;
            nhapemail.TextChanged += nhapemail_TextChanged;
            // 
            // nhappass
            // 
            nhappass.Location = new Point(291, 226);
            nhappass.Name = "nhappass";
            nhappass.Size = new Size(308, 27);
            nhappass.TabIndex = 6;
            nhappass.TextChanged += nhappass_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(361, 293);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dongydieukhoan
            // 
            dongydieukhoan.AutoSize = true;
            dongydieukhoan.Location = new Point(292, 266);
            dongydieukhoan.Name = "dongydieukhoan";
            dongydieukhoan.Size = new Size(60, 24);
            dongydieukhoan.TabIndex = 8;
            dongydieukhoan.Text = "trust";
            dongydieukhoan.UseVisualStyleBackColor = true;
            dongydieukhoan.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // anhien
            // 
            anhien.AutoSize = true;
            anhien.Location = new Point(605, 229);
            anhien.Name = "anhien";
            anhien.Size = new Size(81, 24);
            anhien.TabIndex = 9;
            anhien.Text = "ẩn/hiện";
            anhien.UseVisualStyleBackColor = true;
            anhien.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(anhien);
            Controls.Add(dongydieukhoan);
            Controls.Add(button1);
            Controls.Add(nhappass);
            Controls.Add(nhapemail);
            Controls.Add(nhapuser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nhapuser;
        private TextBox nhapemail;
        private TextBox nhappass;
        private Button button1;
        private CheckBox dongydieukhoan;
        private CheckBox anhien;
    }
}
