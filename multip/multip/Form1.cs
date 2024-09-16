namespace multip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int a, b, resultado = 0;

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

    
            for (int i = 0; i < b; i++)
            {
                resultado += a;
            }

           
            textBox3.Text = Convert.ToString(resultado);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
