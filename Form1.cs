namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        string input1 = "";
        string input2 = "";
        int num1 = 0;
        int num2 = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            input1 += button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            input1 += button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            input1 += button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            input1 += button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            input1 += button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            input1 += button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            input1 += button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            input1 += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            input1 += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            input1 += button0.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(input1);
            MessageBox.Show(num1.ToString());
            input1 = "";
        }
        private void button1__Click(object sender, EventArgs e)
        {
            input2 += button1_.Text;
        }
        private void button2__Click(object sender, EventArgs e)
        {
            input2 += button2_.Text;
        }
        private void button3__Click(object sender, EventArgs e)
        {
            input2 += button3_.Text;
        }
        private void button4__Click(object sender, EventArgs e)
        {
            input2 += button4_.Text;
        }
        private void button5__Click(object sender, EventArgs e)
        {
            input2 += button5_.Text;
        }
        private void button6__Click(object sender, EventArgs e)
        {
            input2 += button6_.Text;
        }
        private void button7__Click(object sender, EventArgs e)
        {
            input2 += button7_.Text;
        }
        private void button8__Click(object sender, EventArgs e)
        {
            input2 += button8_.Text;
        }
        private void button9__Click(object sender, EventArgs e)
        {
            input2 += button9_.Text;
        }
        private void button10__Click(object sender, EventArgs e)
        {
            input2 += button0_.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(input2);
            MessageBox.Show(num2.ToString());
            input2 = "";
        }

        private void Add(object sender, EventArgs e)
        {
            int result = num1 + num2;
            textBoxResult.Text = result.ToString();

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int result = num1 - num2;
            textBoxResult.Text = result.ToString();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            long result = num1 * num2;
            textBoxResult.Text = result.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            double result = num1 / num2;
            textBoxResult.Text = result.ToString();
        }
    }
}