namespace Practice3
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
            one = new Button();
            textBox = new TextBox();
            two = new Button();
            three = new Button();
            five = new Button();
            six = new Button();
            eight = new Button();
            seven = new Button();
            four = new Button();
            nine = new Button();
            divide = new Button();
            time = new Button();
            equal = new Button();
            button6 = new Button();
            clean = new Button();
            dif = new Button();
            sum = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // one
            // 
            one.Location = new Point(215, 45);
            one.Name = "one";
            one.Size = new Size(94, 29);
            one.TabIndex = 0;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(215, 12);
            textBox.Name = "textBox";
            textBox.Size = new Size(294, 27);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // two
            // 
            two.Location = new Point(315, 45);
            two.Name = "two";
            two.Size = new Size(94, 29);
            two.TabIndex = 2;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // three
            // 
            three.Location = new Point(415, 45);
            three.Name = "three";
            three.Size = new Size(94, 29);
            three.TabIndex = 3;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // five
            // 
            five.Location = new Point(315, 80);
            five.Name = "five";
            five.Size = new Size(94, 29);
            five.TabIndex = 5;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // six
            // 
            six.Location = new Point(415, 80);
            six.Name = "six";
            six.Size = new Size(94, 29);
            six.TabIndex = 6;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // eight
            // 
            eight.Location = new Point(315, 115);
            eight.Name = "eight";
            eight.Size = new Size(94, 29);
            eight.TabIndex = 8;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Location = new Point(215, 115);
            seven.Name = "seven";
            seven.Size = new Size(94, 29);
            seven.TabIndex = 7;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // four
            // 
            four.Location = new Point(215, 80);
            four.Name = "four";
            four.Size = new Size(94, 29);
            four.TabIndex = 4;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // nine
            // 
            nine.Location = new Point(415, 115);
            nine.Name = "nine";
            nine.Size = new Size(94, 29);
            nine.TabIndex = 9;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // divide
            // 
            divide.Location = new Point(515, 150);
            divide.Name = "divide";
            divide.Size = new Size(94, 29);
            divide.TabIndex = 10;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // time
            // 
            time.Location = new Point(515, 115);
            time.Name = "time";
            time.Size = new Size(94, 29);
            time.TabIndex = 13;
            time.Text = "x";
            time.UseVisualStyleBackColor = true;
            time.Click += time_Click;
            // 
            // equal
            // 
            equal.Location = new Point(415, 150);
            equal.Name = "equal";
            equal.Size = new Size(94, 29);
            equal.TabIndex = 14;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // button6
            // 
            button6.Location = new Point(315, 150);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "0";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // clean
            // 
            clean.Location = new Point(215, 150);
            clean.Name = "clean";
            clean.Size = new Size(94, 29);
            clean.TabIndex = 16;
            clean.Text = "C";
            clean.UseVisualStyleBackColor = true;
            clean.Click += clean_Click;
            // 
            // dif
            // 
            dif.Location = new Point(515, 80);
            dif.Name = "dif";
            dif.Size = new Size(94, 29);
            dif.TabIndex = 18;
            dif.Text = "-";
            dif.UseVisualStyleBackColor = true;
            dif.Click += dif_Click;
            // 
            // sum
            // 
            sum.Location = new Point(515, 45);
            sum.Name = "sum";
            sum.Size = new Size(94, 29);
            sum.TabIndex = 19;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // delete
            // 
            delete.Location = new Point(515, 12);
            delete.Name = "delete";
            delete.Size = new Size(94, 27);
            delete.TabIndex = 20;
            delete.Text = "Del";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 450);
            Controls.Add(delete);
            Controls.Add(sum);
            Controls.Add(dif);
            Controls.Add(clean);
            Controls.Add(button6);
            Controls.Add(equal);
            Controls.Add(time);
            Controls.Add(divide);
            Controls.Add(nine);
            Controls.Add(four);
            Controls.Add(seven);
            Controls.Add(eight);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(textBox);
            Controls.Add(one);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button one;
        private TextBox textBox;
        private Button two;
        private Button three;
        private Button five;
        private Button six;
        private Button eight;
        private Button seven;
        private Button four;
        private Button nine;
        private Button divide;
        private Button time;
        private Button equal;
        private Button button6;
        private Button clean;
        private Button dif;
        private Button sum;
        private Button delete;
    }
}