namespace Tyuiu.KokoulinIV.Sprint6.Task1.V9
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            label1 = new Label();
            label2 = new Label();
            textBox_Start = new TextBox();
            textBox_Stop = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox_Res = new TextBox();
            button_Spr = new Button();
            button_Go = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 377);
            label1.Name = "label1";
            label1.Size = new Size(120, 44);
            label1.TabIndex = 0;
            label1.Text = "Ввод данных\r\nСтарт шага:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(189, 399);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 1;
            label2.Text = "Конец шага:";
            // 
            // textBox_Start
            // 
            textBox_Start.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Start.Location = new Point(39, 453);
            textBox_Start.Name = "textBox_Start";
            textBox_Start.Size = new Size(100, 30);
            textBox_Start.TabIndex = 2;
            // 
            // textBox_Stop
            // 
            textBox_Stop.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Stop.Location = new Point(189, 453);
            textBox_Stop.Name = "textBox_Stop";
            textBox_Stop.Size = new Size(100, 30);
            textBox_Stop.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "Условие";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(730, 17);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 6;
            label5.Text = "Вывод данных";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(730, 51);
            label6.Name = "label6";
            label6.Size = new Size(110, 22);
            label6.TabIndex = 7;
            label6.Text = "Результат:";
            // 
            // textBox_Res
            // 
            textBox_Res.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox_Res.Location = new Point(730, 88);
            textBox_Res.Multiline = true;
            textBox_Res.Name = "textBox_Res";
            textBox_Res.Size = new Size(250, 333);
            textBox_Res.TabIndex = 8;
            // 
            // button_Spr
            // 
            button_Spr.BackColor = Color.FromArgb(192, 192, 0);
            button_Spr.Location = new Point(364, 434);
            button_Spr.Name = "button_Spr";
            button_Spr.Size = new Size(114, 49);
            button_Spr.TabIndex = 9;
            button_Spr.Text = "Справка";
            button_Spr.UseVisualStyleBackColor = false;
            button_Spr.Click += button_Spr_Click;
            // 
            // button_Go
            // 
            button_Go.BackColor = Color.Green;
            button_Go.FlatStyle = FlatStyle.Flat;
            button_Go.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Go.ForeColor = SystemColors.ControlText;
            button_Go.Location = new Point(509, 399);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(146, 86);
            button_Go.TabIndex = 10;
            button_Go.Text = "ВЫПОЛНИТЬ";
            button_Go.UseVisualStyleBackColor = false;
            button_Go.Click += button_Go_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(643, 214);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1004, 520);
            Controls.Add(pictureBox1);
            Controls.Add(button_Go);
            Controls.Add(button_Spr);
            Controls.Add(textBox_Res);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox_Stop);
            Controls.Add(textBox_Start);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 9 | Кокоулин И.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_Start;
        private TextBox textBox_Stop;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox_Res;
        private Button button_Spr;
        private Button button_Go;
        private PictureBox pictureBox1;
    }
}
