using Tyuiu.KokoulinIV.Sprint6.Task6.V20.Lib;
namespace Tyuiu.KokoulinIV.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button_Imput_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            openFilePath.Text = fileName;
            textBox_Imput.Text = File.ReadAllText(fileName);
            button_Go.Enabled = true;

        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            string str = " ";
            string path = Convert.ToString(openFilePath.Text);
            textBox_Res.Text = ds.CollectTextFromFile( path);
        }

        private void button_Spr_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
        }
    }
}
