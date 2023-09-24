namespace Lesson18
{
    partial class Registration
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
            username = new Label();
            pass1 = new Label();
            pass2 = new Label();
            textBoxUser = new TextBox();
            textBoxPass1 = new TextBox();
            textBoxPass2 = new TextBox();
            buttonrg = new Button();
            haveacoount = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(12, 30);
            username.Name = "username";
            username.Size = new Size(113, 20);
            username.TabIndex = 0;
            username.Text = "Enter Username";
            // 
            // pass1
            // 
            pass1.AutoSize = true;
            pass1.Location = new Point(12, 64);
            pass1.Name = "pass1";
            pass1.Size = new Size(108, 20);
            pass1.TabIndex = 1;
            pass1.Text = "Enter Password";
            // 
            // pass2
            // 
            pass2.AutoSize = true;
            pass2.Location = new Point(12, 98);
            pass2.Name = "pass2";
            pass2.Size = new Size(127, 20);
            pass2.TabIndex = 2;
            pass2.Text = "Confirm Password";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(163, 27);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(196, 27);
            textBoxUser.TabIndex = 3;
            // 
            // textBoxPass1
            // 
            textBoxPass1.Location = new Point(163, 61);
            textBoxPass1.Name = "textBoxPass1";
            textBoxPass1.Size = new Size(196, 27);
            textBoxPass1.TabIndex = 4;
            // 
            // textBoxPass2
            // 
            textBoxPass2.Location = new Point(163, 95);
            textBoxPass2.Name = "textBoxPass2";
            textBoxPass2.Size = new Size(196, 27);
            textBoxPass2.TabIndex = 5;
            // 
            // buttonrg
            // 
            buttonrg.Location = new Point(119, 178);
            buttonrg.Name = "buttonrg";
            buttonrg.Size = new Size(115, 29);
            buttonrg.TabIndex = 6;
            buttonrg.Text = "Register Now";
            buttonrg.UseVisualStyleBackColor = true;
            buttonrg.Click += buttonrg_Click;
            // 
            // haveacoount
            // 
            haveacoount.Location = new Point(77, 213);
            haveacoount.Name = "haveacoount";
            haveacoount.Size = new Size(195, 29);
            haveacoount.TabIndex = 7;
            haveacoount.Text = "Have Account? Login Now";
            haveacoount.UseVisualStyleBackColor = true;
            haveacoount.Click += haveacoount_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 299);
            Controls.Add(haveacoount);
            Controls.Add(buttonrg);
            Controls.Add(textBoxPass2);
            Controls.Add(textBoxPass1);
            Controls.Add(textBoxUser);
            Controls.Add(pass2);
            Controls.Add(pass1);
            Controls.Add(username);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label pass1;
        private Label pass2;
        private TextBox textBoxUser;
        private TextBox textBoxPass1;
        private TextBox textBoxPass2;
        private Button buttonrg;
        private Button haveacoount;
    }
}