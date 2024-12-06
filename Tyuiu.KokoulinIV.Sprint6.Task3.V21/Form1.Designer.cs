namespace Tyuiu.KokoulinIV.Sprint6.Task3.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            button_Go = new Button();
            button_Spr = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            dataGridView_mrx = new DataGridView();
            id1 = new DataGridViewTextBoxColumn();
            id2 = new DataGridViewTextBoxColumn();
            id3 = new DataGridViewTextBoxColumn();
            id4 = new DataGridViewTextBoxColumn();
            id5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_mrx).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 18;
            label3.Text = "Условие";
            // 
            // button_Go
            // 
            button_Go.BackColor = Color.Green;
            button_Go.FlatStyle = FlatStyle.Flat;
            button_Go.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Go.ForeColor = SystemColors.ControlText;
            button_Go.Location = new Point(938, 549);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(94, 49);
            button_Go.TabIndex = 20;
            button_Go.Text = "ВЫПОЛНИТЬ";
            button_Go.UseVisualStyleBackColor = false;
            button_Go.Click += button_Go_Click;
            // 
            // button_Spr
            // 
            button_Spr.BackColor = Color.FromArgb(192, 192, 0);
            button_Spr.Location = new Point(843, 574);
            button_Spr.Name = "button_Spr";
            button_Spr.Size = new Size(72, 24);
            button_Spr.TabIndex = 19;
            button_Spr.Text = "Справка";
            button_Spr.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 296);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(665, 9);
            label6.Name = "label6";
            label6.Size = new Size(110, 22);
            label6.TabIndex = 23;
            label6.Text = "Результат:";
            // 
            // dataGridView_mrx
            // 
            dataGridView_mrx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_mrx.Columns.AddRange(new DataGridViewColumn[] { id1, id2, id3, id4, id5 });
            dataGridView_mrx.EnableHeadersVisualStyles = false;
            dataGridView_mrx.Location = new Point(665, 90);
            dataGridView_mrx.Name = "dataGridView_mrx";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "1";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_mrx.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_mrx.RowHeadersVisible = false;
            dataGridView_mrx.Size = new Size(341, 412);
            dataGridView_mrx.TabIndex = 24;
            dataGridView_mrx.CellContentClick += dataGridView_mrx_CellContentClick;
            // 
            // id1
            // 
            id1.HeaderText = "1";
            id1.Name = "id1";
            id1.Width = 45;
            // 
            // id2
            // 
            id2.HeaderText = "2";
            id2.Name = "id2";
            id2.Width = 45;
            // 
            // id3
            // 
            id3.HeaderText = "3";
            id3.Name = "id3";
            id3.Width = 45;
            // 
            // id4
            // 
            id4.HeaderText = "4";
            id4.Name = "id4";
            id4.Width = 45;
            // 
            // id5
            // 
            id5.HeaderText = "5";
            id5.Name = "id5";
            id5.Width = 45;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 610);
            Controls.Add(dataGridView_mrx);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(button_Go);
            Controls.Add(button_Spr);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Спринт 6 | Таск 1 | Вариант 9 | Кокоулин И.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_mrx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button_Go;
        private Button button_Spr;
        private PictureBox pictureBox1;
        private Label label6;
        private DataGridView dataGridView_mrx;
        private DataGridViewTextBoxColumn id1;
        private DataGridViewTextBoxColumn id2;
        private DataGridViewTextBoxColumn id3;
        private DataGridViewTextBoxColumn id4;
        private DataGridViewTextBoxColumn id5;
    }
}
