using Tyuiu.KokoulinIV.Sprint6.Task1.V9.Lib;
namespace Tyuiu.KokoulinIV.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button_Go_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox_Start.Text);
                int stop = Convert.ToInt32(textBox_Stop.Text);
                string str;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textBox_Res.Text = "";
                textBox_Res.AppendText("+-----------+----------+" + Environment.NewLine);
                textBox_Res.AppendText("+    X      +    F(x)  +" + Environment.NewLine);
                textBox_Res.AppendText("+-----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {

                    str = String.Format("|{0,7:d}   ||{1, 7:f2}   |", start, value[i]);
                    textBox_Res.AppendText(str + Environment.NewLine);
                    start++;
                }
                textBox_Res.AppendText("+-----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Spr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-24-1 Кокоулин Иван Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
