namespace Tyuiu.KokoulinIV.Sprint6.Task4.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel2 = new Panel();
            label1 = new Label();
            textBox_Res = new TextBox();
            panel3 = new Panel();
            chart_CosX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            button1 = new Button();
            button_Go = new Button();
            button_Spr = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox_Stop = new TextBox();
            textBox_Start = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_CosX).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox_Res);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 494);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(56, 17);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 1;
            label1.Text = "Вывод:";
            // 
            // textBox_Res
            // 
            textBox_Res.Location = new Point(41, 70);
            textBox_Res.Multiline = true;
            textBox_Res.Name = "textBox_Res";
            textBox_Res.Size = new Size(198, 386);
            textBox_Res.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(chart_CosX);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(303, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(760, 494);
            panel3.TabIndex = 1;
            // 
            // chart_CosX
            // 
            chartArea1.Name = "ChartArea1";
            chart_CosX.ChartAreas.Add(chartArea1);
            legend1.Name = "График функции";
            chart_CosX.Legends.Add(legend1);
            chart_CosX.Location = new Point(34, 17);
            chart_CosX.Name = "chart_CosX";
            chart_CosX.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "График функции";
            series1.Name = "Series1";
            chart_CosX.Series.Add(series1);
            chart_CosX.Size = new Size(684, 453);
            chart_CosX.TabIndex = 0;
            chart_CosX.Text = "График функции F(x)";
            chart_CosX.Click += chart_CosX_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button_Go);
            panel1.Controls.Add(button_Spr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox_Stop);
            panel1.Controls.Add(textBox_Start);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 90);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(672, 20);
            button1.Name = "button1";
            button1.Size = new Size(106, 51);
            button1.TabIndex = 21;
            button1.Text = "СОХРАНИТЬ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_Go
            // 
            button_Go.BackColor = Color.Green;
            button_Go.FlatStyle = FlatStyle.Flat;
            button_Go.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Go.ForeColor = SystemColors.ControlText;
            button_Go.Location = new Point(540, 20);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(106, 51);
            button_Go.TabIndex = 20;
            button_Go.Text = "ВЫПОЛНИТЬ";
            button_Go.UseVisualStyleBackColor = false;
            button_Go.Click += button_Go_Click;
            // 
            // button_Spr
            // 
            button_Spr.BackColor = Color.FromArgb(192, 192, 0);
            button_Spr.Location = new Point(1009, 41);
            button_Spr.Name = "button_Spr";
            button_Spr.Size = new Size(42, 39);
            button_Spr.TabIndex = 19;
            button_Spr.Text = "?";
            button_Spr.UseVisualStyleBackColor = false;
            button_Spr.Click += button_Spr_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(282, 44);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 18;
            label2.Text = "Конец шага:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(13, 27);
            label3.Name = "label3";
            label3.Size = new Size(120, 44);
            label3.TabIndex = 17;
            label3.Text = "Ввод данных\r\nСтарт шага:";
            // 
            // textBox_Stop
            // 
            textBox_Stop.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Stop.Location = new Point(408, 36);
            textBox_Stop.Name = "textBox_Stop";
            textBox_Stop.Size = new Size(100, 30);
            textBox_Stop.TabIndex = 16;
            // 
            // textBox_Start
            // 
            textBox_Start.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Start.Location = new Point(148, 41);
            textBox_Start.Name = "textBox_Start";
            textBox_Start.Size = new Size(100, 30);
            textBox_Start.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1063, 584);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 18 | Кокоулин И.В.";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_CosX).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Label label1;
        private TextBox textBox_Res;
        private TextBox textBox_Stop;
        private TextBox textBox_Start;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_CosX;
        private Button button_Go;
        private Button button_Spr;
        private Button button1;
    }
}
