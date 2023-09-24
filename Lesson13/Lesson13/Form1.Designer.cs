namespace Lesson13
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
            username = new Label();
            password1 = new Label();
            password2 = new Label();
            textBoxuser = new TextBox();
            textBoxp1 = new TextBox();
            textBoxp2 = new TextBox();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(8, 9);
            username.Name = "username";
            username.Size = new Size(113, 20);
            username.TabIndex = 0;
            username.Text = "Enter Username";
            // 
            // password1
            // 
            password1.AutoSize = true;
            password1.Location = new Point(8, 39);
            password1.Name = "password1";
            password1.Size = new Size(108, 20);
            password1.TabIndex = 1;
            password1.Text = "Enter Password";
            // 
            // password2
            // 
            password2.AutoSize = true;
            password2.Location = new Point(8, 72);
            password2.Name = "password2";
            password2.Size = new Size(127, 20);
            password2.TabIndex = 2;
            password2.Text = "Confirm Password";
            // 
            // textBoxuser
            // 
            textBoxuser.Location = new Point(157, 6);
            textBoxuser.Name = "textBoxuser";
            textBoxuser.Size = new Size(125, 27);
            textBoxuser.TabIndex = 3;
            // 
            // textBoxp1
            // 
            textBoxp1.Location = new Point(157, 39);
            textBoxp1.Name = "textBoxp1";
            textBoxp1.Size = new Size(125, 27);
            textBoxp1.TabIndex = 4;
            // 
            // textBoxp2
            // 
            textBoxp2.Location = new Point(157, 72);
            textBoxp2.Name = "textBoxp2";
            textBoxp2.Size = new Size(125, 27);
            textBoxp2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxp2);
            Controls.Add(textBoxp1);
            Controls.Add(textBoxuser);
            Controls.Add(password2);
            Controls.Add(password1);
            Controls.Add(username);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label password1;
        private Label password2;
        private TextBox textBoxuser;
        private TextBox textBoxp1;
        private TextBox textBoxp2;
    }
}