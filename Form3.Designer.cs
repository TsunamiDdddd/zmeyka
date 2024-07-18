namespace zmeyka
{
    partial class Form3
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            labelLevel = new Label();
            label4 = new Label();
            labelSpeed = new Label();
            label6 = new Label();
            labelScore = new Label();
            label8 = new Label();
            labelTime = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 320);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 0;
            button1.Text = "Новая игра";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 45);
            label1.Name = "label1";
            label1.Size = new Size(241, 54);
            label1.TabIndex = 1;
            label1.Text = "GAME OVER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 131);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Уровень";
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Location = new Point(395, 131);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(59, 15);
            labelLevel.TabIndex = 3;
            labelLevel.Text = "labelLevel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 173);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Скорость";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(395, 173);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(38, 15);
            labelSpeed.TabIndex = 5;
            labelSpeed.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 213);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 6;
            label6.Text = "Счёт";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(395, 213);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(38, 15);
            labelScore.TabIndex = 7;
            labelScore.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(298, 250);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 8;
            label8.Text = "Время";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(395, 250);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(38, 15);
            labelTime.TabIndex = 9;
            labelTime.Text = "label9";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTime);
            Controls.Add(label8);
            Controls.Add(labelScore);
            Controls.Add(label6);
            Controls.Add(labelSpeed);
            Controls.Add(label4);
            Controls.Add(labelLevel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label labelLevel;
        private Label label4;
        private Label labelSpeed;
        private Label label6;
        private Label labelScore;
        private Label label8;
        private Label labelTime;
    }
}