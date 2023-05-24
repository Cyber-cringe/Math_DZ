namespace DZtask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double variable = Convert.ToDouble(textBox1.Text);
            if (variable <= 2)
            {
                double numa = Convert.ToDouble(textBox1.Text);
                double res1 = (Math.Pow(numa, 2) + (4*numa) + 5);
                MessageBox.Show("Результат:" + res1);
            }else
            {
                double numb = Convert.ToDouble(textBox1.Text);
                double res2 = (1/(Math.Pow(numb, 2) + (4*numb) + 5));
                MessageBox.Show("Результат:" + res2);
            }

        }
    }
}