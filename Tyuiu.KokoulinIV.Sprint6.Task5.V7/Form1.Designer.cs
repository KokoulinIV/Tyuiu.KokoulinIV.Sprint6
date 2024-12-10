namespace Tyuiu.KokoulinIV.Sprint6.Task5.V7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            button_OpenFile = new Button();
            button_Go = new Button();
            button_Spr = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView_Res = new DataGridView();
            Result = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            chart_Res = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Res).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_Res).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(button_OpenFile);
            panel1.Controls.Add(button_Go);
            panel1.Controls.Add(button_Spr);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 94);
            panel1.TabIndex = 0;
            // 
            // button_OpenFile
            // 
            button_OpenFile.BackColor = Color.SlateGray;
            button_OpenFile.FlatStyle = FlatStyle.Flat;
            button_OpenFile.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_OpenFile.ForeColor = SystemColors.ControlText;
            button_OpenFile.Location = new Point(597, 21);
            button_OpenFile.Name = "button_OpenFile";
            button_OpenFile.Size = new Size(106, 51);
            button_OpenFile.TabIndex = 24;
            button_OpenFile.Text = "ОТКРЫТЬ\r\nфайл\r\n";
            button_OpenFile.UseVisualStyleBackColor = false;
            button_OpenFile.Click += button_OpenFile_Click;
            // 
            // button_Go
            // 
            button_Go.BackColor = Color.SeaGreen;
            button_Go.FlatStyle = FlatStyle.Flat;
            button_Go.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Go.ForeColor = SystemColors.ControlText;
            button_Go.Location = new Point(465, 21);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(106, 51);
            button_Go.TabIndex = 23;
            button_Go.Text = "ВЫПОЛНИТЬ";
            button_Go.UseVisualStyleBackColor = false;
            button_Go.Click += button_Go_Click;
            // 
            // button_Spr
            // 
            button_Spr.BackColor = Color.FromArgb(192, 192, 0);
            button_Spr.Location = new Point(934, 42);
            button_Spr.Name = "button_Spr";
            button_Spr.Size = new Size(42, 39);
            button_Spr.TabIndex = 22;
            button_Spr.Text = "?";
            button_Spr.UseVisualStyleBackColor = false;
            button_Spr.Click += button_Spr_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView_Res);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 567);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(82, 3);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 2;
            label1.Text = "Вывод:";
            // 
            // dataGridView_Res
            // 
            dataGridView_Res.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Res.Columns.AddRange(new DataGridViewColumn[] { Result });
            dataGridView_Res.Location = new Point(31, 54);
            dataGridView_Res.Name = "dataGridView_Res";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "1";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_Res.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Res.RowHeadersVisible = false;
            dataGridView_Res.Size = new Size(195, 491);
            dataGridView_Res.TabIndex = 0;
            // 
            // Result
            // 
            Result.HeaderText = "Значения";
            Result.Name = "Result";
            Result.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(chart_Res);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(269, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(715, 567);
            panel3.TabIndex = 2;
            // 
            // chart_Res
            // 
            chartArea1.Name = "ChartArea1";
            chart_Res.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_Res.Legends.Add(legend1);
            chart_Res.Location = new Point(26, 38);
            chart_Res.Name = "chart_Res";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_Res.Series.Add(series1);
            chart_Res.Size = new Size(660, 507);
            chart_Res.TabIndex = 0;
            chart_Res.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(850, 400);
            Name = "Form1";
            Text = "Спринт 6 | Таск 5 | Вариант 7 | Кокоулин И.В.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Res).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_Res).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button_OpenFile;
        private Button button_Go;
        private Button button_Spr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Res;
        private DataGridView dataGridView_Res;
        private Label label1;
        private DataGridViewTextBoxColumn Result;
    }
}
