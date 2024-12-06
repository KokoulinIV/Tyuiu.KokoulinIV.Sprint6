using Tyuiu.KokoulinIV.Sprint6.Task3.V21.Lib;
namespace Tyuiu.KokoulinIV.Sprint6.Task3.V21
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
            int[,] mTR = new int [5,5]
            {
                { 26, -15, 7, 1, -4 },
                { 14, 26, 22,17,27 },
                { -8, 31, 22,34,4 },
                { -18, 16, -2,16,27 },
                { 5, 2, -4, 16,15}
            };
            int row = mTR.GetUpperBound(0)+1;
            int colm = mTR.Length / row;

            dataGridView_mrx.RowCount = row;
            dataGridView_mrx.ColumnCount = colm;


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView_mrx.Rows[i].Cells[j].Value = Convert.ToString(mTR[i, j]);
                }
            }







            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Convert.ToInt32(dataGridView_mrx.Rows[i].Cells[j].Value);
                }
            }
            int[,] res = ds.Calculate(matrix);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView_mrx.Rows[i].Cells[j].Value = Convert.ToString(res[i,j]);
                }
            }
        }

        private void dataGridView_mrx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
