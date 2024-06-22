namespace _28._06._28__V4_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxComputer;
        private System.Windows.Forms.Label labelResult;

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
            buttonRock = new Button();
            buttonPaper = new Button();
            buttonScissors = new Button();
            pictureBoxUser = new PictureBox();
            pictureBoxComputer = new PictureBox();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).BeginInit();
            SuspendLayout();
            // 
            // buttonRock
            // 
            buttonRock.Location = new Point(12, 12);
            buttonRock.Name = "buttonRock";
            buttonRock.Size = new Size(100, 50);
            buttonRock.TabIndex = 0;
            buttonRock.Text = "Rock";
            buttonRock.UseVisualStyleBackColor = true;
            buttonRock.Click += buttonRock_Click;
            // 
            // buttonPaper
            // 
            buttonPaper.Location = new Point(118, 12);
            buttonPaper.Name = "buttonPaper";
            buttonPaper.Size = new Size(100, 50);
            buttonPaper.TabIndex = 1;
            buttonPaper.Text = "Paper";
            buttonPaper.UseVisualStyleBackColor = true;
            buttonPaper.Click += buttonPaper_Click;
            // 
            // buttonScissors
            // 
            buttonScissors.Location = new Point(224, 12);
            buttonScissors.Name = "buttonScissors";
            buttonScissors.Size = new Size(100, 50);
            buttonScissors.TabIndex = 2;
            buttonScissors.Text = "Scissors";
            buttonScissors.UseVisualStyleBackColor = true;
            buttonScissors.Click += buttonScissors_Click;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.BackColor = SystemColors.Control;
            pictureBoxUser.Location = new Point(12, 68);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(100, 100);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 3;
            pictureBoxUser.TabStop = false;
            // 
            // pictureBoxComputer
            // 
            pictureBoxComputer.Location = new Point(224, 68);
            pictureBoxComputer.Name = "pictureBoxComputer";
            pictureBoxComputer.Size = new Size(100, 100);
            pictureBoxComputer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxComputer.TabIndex = 4;
            pictureBoxComputer.TabStop = false;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(118, 190);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(45, 15);
            labelResult.TabIndex = 5;
            labelResult.Text = "Result: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 220);
            Controls.Add(labelResult);
            Controls.Add(pictureBoxComputer);
            Controls.Add(pictureBoxUser);
            Controls.Add(buttonScissors);
            Controls.Add(buttonPaper);
            Controls.Add(buttonRock);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
