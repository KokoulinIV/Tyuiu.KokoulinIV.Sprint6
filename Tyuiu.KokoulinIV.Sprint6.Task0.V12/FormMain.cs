using Tyuiu.KokoulinIV.Sprint6.Task0.V12.Lib;

namespace Tyuiu.KokoulinIV.Sprint6.Task0.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                DataService ds = new DataService();
                int a;
                a = Convert.ToInt32(textBox1.Text);
                double b = ds.Calculate(a);
                textBox2.Text = b.ToString();
            }
            else MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

      
    }
}
