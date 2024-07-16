namespace zmeyka
{
    partial class Form2
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
            buttonstart = new Button();
            buttontable = new Button();
            buttonclose = new Button();
            listBoxlevel = new ListBox();
            label1 = new Label();
            listBoxspeed = new ListBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonstart
            // 
            buttonstart.Location = new Point(261, 89);
            buttonstart.Name = "buttonstart";
            buttonstart.Size = new Size(75, 23);
            buttonstart.TabIndex = 0;
            buttonstart.Text = "Старт";
            buttonstart.UseVisualStyleBackColor = true;
            buttonstart.Click += buttonstart_Click;
            // 
            // buttontable
            // 
            buttontable.Location = new Point(262, 172);
            buttontable.Name = "buttontable";
            buttontable.Size = new Size(75, 23);
            buttontable.TabIndex = 1;
            buttontable.Text = "Таблица";
            buttontable.UseVisualStyleBackColor = true;
            buttontable.Click += buttontable_Click;
            // 
            // buttonclose
            // 
            buttonclose.Location = new Point(261, 224);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(75, 23);
            buttonclose.TabIndex = 2;
            buttonclose.Text = "Выход";
            buttonclose.UseVisualStyleBackColor = true;
            buttonclose.Click += buttonclose_Click;
            // 
            // listBoxlevel
            // 
            listBoxlevel.FormattingEnabled = true;
            listBoxlevel.ItemHeight = 15;
            listBoxlevel.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            listBoxlevel.Location = new Point(502, 101);
            listBoxlevel.Name = "listBoxlevel";
            listBoxlevel.Size = new Size(120, 94);
            listBoxlevel.TabIndex = 3;
            listBoxlevel.SelectedIndexChanged += listBoxlevel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 59);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 4;
            label1.Text = "Уровень \r\n(число препятствий)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxspeed
            // 
            listBoxspeed.FormattingEnabled = true;
            listBoxspeed.ItemHeight = 15;
            listBoxspeed.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            listBoxspeed.Location = new Point(499, 268);
            listBoxspeed.Name = "listBoxspeed";
            listBoxspeed.Size = new Size(120, 94);
            listBoxspeed.TabIndex = 5;
            listBoxspeed.SelectedIndexChanged += listBoxspeed_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 232);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Скорость змейки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(697, 161);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 7;
            label3.Text = "1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBoxspeed);
            Controls.Add(label1);
            Controls.Add(listBoxlevel);
            Controls.Add(buttonclose);
            Controls.Add(buttontable);
            Controls.Add(buttonstart);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonstart;
        private Button buttontable;
        private Button buttonclose;
        private ListBox listBoxlevel;
        private Label label1;
        public ListBox listBoxspeed;
        private Label label2;
        private Label label3;
    }
}