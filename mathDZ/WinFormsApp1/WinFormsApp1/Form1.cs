namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double xcircle = 0;
            double ycircle = 0;
            double R = 1;
            double res;

            res = (Math.Pow((x - xcircle), 2) + Math.Pow((y - ycircle), 2));

            if ((((x <= 0 && y >= Math.Abs(x))) || (y >= 0 && x >= 0) || (y < 0 && Math.Abs(y) <= x)) && res < Math.Pow(R, 2))
            {
                MessageBox.Show("Точка попадает в круг");
            }
            else
            {
                MessageBox.Show("Точка не попадает в круг");
            }
        }
    }
}