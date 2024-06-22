namespace _28._06._24__V3_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            trackBar1 = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(trackBar1)).BeginInit();
            SuspendLayout();

            // trackBar1
            trackBar1.Location = new System.Drawing.Point(12, 12);
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 20; // Ограничиваем до 20 для предотвращения переполнения
            trackBar1.Value = 0;
            trackBar1.Size = new System.Drawing.Size(776, 45);
            trackBar1.Scroll += new System.EventHandler(trackBar1_Scroll);

            // label1
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.Text = "Число n: 0";

            // textBox1
            textBox1.Location = new System.Drawing.Point(12, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(776, 23);
            textBox1.ReadOnly = true;

            // button1
            button1.Location = new System.Drawing.Point(12, 114);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(776, 23);
            button1.Text = "Расчет";
            button1.Click += new System.EventHandler(button1_Click);

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 150);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Factorial Calculator";
            ((System.ComponentModel.ISupportInitialize)(trackBar1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
