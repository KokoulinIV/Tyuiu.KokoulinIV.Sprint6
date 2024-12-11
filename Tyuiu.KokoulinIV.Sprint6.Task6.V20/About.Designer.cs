namespace Tyuiu.KokoulinIV.Sprint6.Task6.V20
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 87);
            label1.Name = "label1";
            label1.Size = new Size(286, 105);
            label1.TabIndex = 0;
            label1.Text = "Разработчик : Кокоулин И.В.\r\nГруппа : ИБКСб-24-1\r\n\r\nТИУ 2024\r\nВШЦТ 2024\r\n\r\nВнутреннее имя : Tyuiu.KokoulinIV.Sprint6.Task6.V20\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 285);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 357);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "About";
            Text = "Info";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
    }
}