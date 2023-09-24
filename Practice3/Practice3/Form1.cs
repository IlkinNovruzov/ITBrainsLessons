namespace Practice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void Fresh(TextBox textBox)
        {
            if (textBox.Text[0] != '+' || textBox.Text[0] != '-' || textBox.Text[0] != 'x' || textBox.Text[0] != '/')
            {
                textBox.Text = "";
            }

        }
        private void one_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }
        double n1;
        double n2;
        public string s = "";
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";

        }








        private void clean_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            textBox.Text = "";
        }
        private void sum_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "+";
            s = "+";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "/";
            s = "/";
        }

        private void time_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "x";
            s = "x";
        }
        private void dif_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "-";
            s = "-";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(textBox.Text.Remove(0, 1));
            switch (s)
            {
                case "+":
                    textBox.Text = (n1 + n2).ToString();
                    break;
                case "-":
                    textBox.Text = (n1 - n2).ToString();
                    break;
                case "x":
                    textBox.Text = (n1 * n2).ToString();
                    break;
                case "/":
                    textBox.Text = (n1 / n2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.TextLength - 1, 1);
        }
    }
}