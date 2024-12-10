using System.Drawing;
using System.IO;
using Tyuiu.KokoulinIV.Sprint6.Task5.V7.Lib;
namespace Tyuiu.KokoulinIV.Sprint6.Task5.V7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button_Go_Click(object sender, EventArgs e)
        {
            try
            {
                chart_Res.Series[0].Points.Clear();
                string path = "C:\\Users\\wolff\\source\\repos\\Tyuiu.KokoulinIV.Sprint6\\Tyuiu.KokoulinIV.Sprint6.Task5.V7\\InPutDataFileTask5V7.txt.txt";
                double[] res = ds.LoadFromDataFile(path);
                int len = res.Length;
                this.chart_Res.Titles.Add("Диаграмма значений");
                for (int i = 0; i < len; i++)
                {
                    this.dataGridView_Res.Rows.Add(Convert.ToString(res[i]));
                    this.chart_Res.Series[0].Points.AddXY(i, res[i]);

                }
            }
            catch
            {
                MessageBox.Show("ОЙ! Что то пошло не так , переделывай!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Spr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-24-1 Кокоулин Иван Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\wolff\\source\\repos\\Tyuiu.KokoulinIV.Sprint6\\Tyuiu.KokoulinIV.Sprint6.Task5.V7\\InPutDataFileTask5V7.txt.txt";
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
