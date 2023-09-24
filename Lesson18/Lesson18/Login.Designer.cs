namespace Lesson18
{
    partial class Login
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
            buttonLogin = new Button();
            dontHaveAcount = new Button();
            label1 = new Label();
            label2 = new Label();
            loginUser = new TextBox();
            loginPass = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(109, 145);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // dontHaveAcount
            // 
            dontHaveAcount.Location = new Point(50, 189);
            dontHaveAcount.Name = "dontHaveAcount";
            dontHaveAcount.Size = new Size(212, 29);
            dontHaveAcount.TabIndex = 1;
            dontHaveAcount.Text = "Don't have Account? Sign Up";
            dontHaveAcount.UseVisualStyleBackColor = true;
            dontHaveAcount.Click += dontHaveAcount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter Password";
            // 
            // loginUser
            // 
            loginUser.Location = new Point(131, 32);
            loginUser.Name = "loginUser";
            loginUser.Size = new Size(186, 27);
            loginUser.TabIndex = 4;
            // 
            // loginPass
            // 
            loginPass.Location = new Point(131, 74);
            loginPass.Name = "loginPass";
            loginPass.Size = new Size(186, 27);
            loginPass.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 276);
            Controls.Add(loginPass);
            Controls.Add(loginUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dontHaveAcount);
            Controls.Add(buttonLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button dontHaveAcount;
        private Label label1;
        private Label label2;
        private TextBox loginUser;
        private TextBox loginPass;
    }
}