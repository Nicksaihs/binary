namespace binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int d = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);
        }
    }
}