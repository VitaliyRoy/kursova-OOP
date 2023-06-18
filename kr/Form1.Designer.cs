namespace kr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clock_PictureBox = new System.Windows.Forms.PictureBox();
            this.SetAlarmButton = new System.Windows.Forms.Button();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.TurnOffAlarmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.image1Button = new System.Windows.Forms.Button();
            this.image3Button = new System.Windows.Forms.Button();
            this.image2Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clock_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clock_PictureBox
            // 
            this.clock_PictureBox.ErrorImage = null;
            this.clock_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clock_PictureBox.Image")));
            this.clock_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.clock_PictureBox.Name = "clock_PictureBox";
            this.clock_PictureBox.Size = new System.Drawing.Size(500, 500);
            this.clock_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clock_PictureBox.TabIndex = 0;
            this.clock_PictureBox.TabStop = false;
            this.clock_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clock_PictureBox_MouseDown);
            // 
            // SetAlarmButton
            // 
            this.SetAlarmButton.Location = new System.Drawing.Point(12, 525);
            this.SetAlarmButton.Name = "SetAlarmButton";
            this.SetAlarmButton.Size = new System.Drawing.Size(130, 23);
            this.SetAlarmButton.TabIndex = 1;
            this.SetAlarmButton.Text = "Встановити будильник";
            this.SetAlarmButton.UseVisualStyleBackColor = true;
            this.SetAlarmButton.Click += new System.EventHandler(this.SetAlarmButton_Click);
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Location = new System.Drawing.Point(148, 555);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(64, 20);
            this.minuteTextBox.TabIndex = 2;
            // 
            // hourTextBox
            // 
            this.hourTextBox.Location = new System.Drawing.Point(148, 525);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(64, 20);
            this.hourTextBox.TabIndex = 3;
            // 
            // TurnOffAlarmButton
            // 
            this.TurnOffAlarmButton.Location = new System.Drawing.Point(12, 552);
            this.TurnOffAlarmButton.Name = "TurnOffAlarmButton";
            this.TurnOffAlarmButton.Size = new System.Drawing.Size(130, 23);
            this.TurnOffAlarmButton.TabIndex = 4;
            this.TurnOffAlarmButton.Text = "Вимкнути будильник";
            this.TurnOffAlarmButton.UseVisualStyleBackColor = true;
            this.TurnOffAlarmButton.Click += new System.EventHandler(this.TurnOffAlarmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Години";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Хвилини";
            // 
            // image1Button
            // 
            this.image1Button.Location = new System.Drawing.Point(286, 525);
            this.image1Button.Name = "image1Button";
            this.image1Button.Size = new System.Drawing.Size(102, 23);
            this.image1Button.TabIndex = 8;
            this.image1Button.Text = "Циферблат №1";
            this.image1Button.UseVisualStyleBackColor = true;
            this.image1Button.Click += new System.EventHandler(this.image1Button_Click);
            // 
            // image3Button
            // 
            this.image3Button.Location = new System.Drawing.Point(394, 525);
            this.image3Button.Name = "image3Button";
            this.image3Button.Size = new System.Drawing.Size(95, 23);
            this.image3Button.TabIndex = 9;
            this.image3Button.Text = "Цифербалт №3";
            this.image3Button.UseVisualStyleBackColor = true;
            this.image3Button.Click += new System.EventHandler(this.image3Button_Click);
            // 
            // image2Button
            // 
            this.image2Button.Location = new System.Drawing.Point(286, 552);
            this.image2Button.Name = "image2Button";
            this.image2Button.Size = new System.Drawing.Size(102, 23);
            this.image2Button.TabIndex = 10;
            this.image2Button.Text = "Циферблат №2";
            this.image2Button.UseVisualStyleBackColor = true;
            this.image2Button.Click += new System.EventHandler(this.image2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 587);
            this.Controls.Add(this.image2Button);
            this.Controls.Add(this.image3Button);
            this.Controls.Add(this.image1Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TurnOffAlarmButton);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.minuteTextBox);
            this.Controls.Add(this.SetAlarmButton);
            this.Controls.Add(this.clock_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clock_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox clock_PictureBox;
        private System.Windows.Forms.Button SetAlarmButton;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.Button TurnOffAlarmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button image1Button;
        private System.Windows.Forms.Button image3Button;
        private System.Windows.Forms.Button image2Button;
    }
}

