using System.IO;
using Tyuiu.KokoulinIV.Sprint6.Task4.V18.Lib;
namespace Tyuiu.KokoulinIV.Sprint6.Task4.V18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void chart_CosX_Click(object sender, EventArgs e)
        {

        }

        private void button_Spr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ �����-24-1 �������� ���� ������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBox_Start.Text);
                int stop = Convert.ToInt32(textBox_Stop.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textBox_Res.Text = "";
                chart_CosX.Series[0].Points.Clear();
                this.chart_CosX.Titles.Add("������ �������");
                this.chart_CosX.ChartAreas[0].AxisX.Title = "��� ��";
                this.chart_CosX.ChartAreas[0].AxisY.Title = "��� �Y";

                for (int i = 0; i < len; i++)
                {
                    textBox_Res.AppendText(value[i] + Environment.NewLine);
                    this.chart_CosX.Series[0].Points.AddXY(start, value[i]);
                    start++;
                }





            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Spr_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ �����-24-1 �������� ���� ������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string pather = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask4V18.txt"); ;
                FileInfo fileInfo = new FileInfo(pather);
                bool fileExists = fileInfo.Exists;
                if (fileExists)
                {
                    File.Delete(pather);
                }
                File.WriteAllText(pather,textBox_Res.Text);
                DialogResult dialog = MessageBox.Show("����" + pather + "�������� �������\n ������� ��� � ��������?","���������" ,MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = pather;
                    txt.Start();
                }
            }
            catch 
            {
                MessageBox.Show("���� ��� ����������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
