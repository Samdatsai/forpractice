namespace fortest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans = 0;
            for (int i = 1; i < 101; i++)
            {
                ans = ans + i;//ans+=i
            }
            textBox1.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int start = int.Parse(textBox2.Text);
            int end = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);
            int ans = 0;
            for (int i = start; i <= end; i = i + d)
            {
                ans = ans + i;//ans+=i
            }
            textBox1.Text = ans.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ans = 0;
            for (int i = 11; 1 <= i; i = i - 2)
            {
                ans = ans + i;//ans+=i
            }
            textBox1.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ans = 0;
            for (double i = 0.5; i <= 10; i = i + 0.5)
            {
                ans = ans + i;//ans+=i
            }
            textBox1.Text = ans.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int start = int.Parse(textBox5.Text);
            int ans = 1;
            for (int i = start; 1 <= i; i = i - 1)
            {
                ans = ans * i;//ans+=i
            }
            textBox1.Text = ans.ToString();
        }
    }
}