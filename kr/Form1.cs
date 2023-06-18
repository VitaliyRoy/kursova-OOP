using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace kr
{
    public partial class Form1 : Form
    {
        // Підключення функцій з бібліотеки user32.dll, що допоможуть переміщувати вікно мишкою
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        // Положення та розміри стрілок
        int center_x = 250, center_y = 250;
        int second_hand_size = 140, minute_hand_size = 130, hour_hand_size = 115;

        private bool alarmSet = false; // Змінна для відстеження статусу будильника
        private int alarmHour; // Змінна для збереження години будильника
        private int alarmMinute; // Змінна для збереження хвилини будильника

        // Налаштування таймера для запуску функції t_Tick кожної секунди
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.main);
            t.Start();
        }

        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        // Функція, що дозволяє при натисканні на PictureBox переміщувати вікно програми
        private void clock_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            const uint WM_SYSCOMMAND = 0x0112;
            const uint DOMOVE = 0xF012;

            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        // Функція для обрахунку координат секундної та хвилинної стрілок
        private int[] second_and_minute_coordinate(int value, int hands_lenght)
        {
            int[] coord = new int[2];
            value *= 6;

            if (value >= 0 && value <= 180)
            {
                coord[0] = center_x + (int)(hands_lenght * Math.Sin(Math.PI * value / 180));
                coord[1] = center_y - (int)(hands_lenght * Math.Cos(Math.PI * value / 180));
            }
            else
            {
                coord[0] = center_x - (int)(hands_lenght * -Math.Sin(Math.PI * value / 180));
                coord[1] = center_y - (int)(hands_lenght * Math.Cos(Math.PI * value / 180));
            }
            return coord;
        }

        // Функція обрахунк координат годинної стрілки
        private int[] hour_coordinate(int hour_value, int minute_value, int hand_lenght)
        {
            int[] coord = new int[2];
            int val = (int)((hour_value * 30) + (minute_value * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = center_x + (int)(hand_lenght * Math.Sin(Math.PI * val / 180));
                coord[1] = center_y - (int)(hand_lenght * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = center_x - (int)(hand_lenght * -Math.Sin(Math.PI * val / 180));
                coord[1] = center_y - (int)(hand_lenght * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        // Основна функція
        private void main(object sender, EventArgs e)
        {
            // Отримуємо системний час
            int second = DateTime.Now.Second;
            int minute = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            int[] handCoord = new int[2];

            Graphics f = clock_PictureBox.CreateGraphics();

            this.Text = "Аналоговий годинник " + hour + ":" + minute + ":" + second;

            // Стираємо попереднє положення стрілок годинника
            handCoord = second_and_minute_coordinate(second, second_hand_size + 4);
            f.DrawLine(new Pen(Color.White, 45f), new Point(center_x, center_y), new Point(handCoord[0], handCoord[1]));

            handCoord = second_and_minute_coordinate(minute, minute_hand_size + 4);
            f.DrawLine(new Pen(Color.White, 40f), new Point(center_x, center_y), new Point(handCoord[0], handCoord[1]));

            handCoord = hour_coordinate(hour % 12, minute, hour_hand_size + 4);
            f.DrawLine(new Pen(Color.White, 20f), new Point(center_x, center_y), new Point(handCoord[0], handCoord[1]));

            // Малюємо стрілки годинника
            handCoord = hour_coordinate(hour % 12, minute, hour_hand_size);
            f.DrawLine(new Pen(Color.Black, 6f), new Point(center_x, center_y), new Point(handCoord[0], handCoord[1]));

            handCoord = second_and_minute_coordinate(minute, minute_hand_size);
            f.DrawLine(new Pen(Color.Red, 5f), new Point(center_x, center_y), new Point(handCoord[0], handCoord[1]));

            handCoord = second_and_minute_coordinate(second, second_hand_size);
            f.DrawLine(new Pen(Color.Blue, 4f), new Point(center_x, center_y), new Point(handCoord[0], handCoord[1]));

            // Відображення статусу будильника
            if (alarmSet)
            {
                if (hour == alarmHour && minute == alarmMinute)
                {
                    // Спрацювання будильника
                    MessageBox.Show("Будильник спрацював!");
                    alarmSet = false;
                }
                else
                {
                    this.Text += " (Будильник заведено)";
                }
            }
            else
            {
                this.Text += " (Будильник не заведено)";
            }
        }

        // Функція для встановлення будильника з перевіркою введеного часу
        private void SetAlarm(int hour, int minute)
        {
            // Перевірка введеного часу
            if (hour < 0 || hour > 23)
            {
                MessageBox.Show("Некоректно введена година!");
                return;
            }

            if (minute < 0 || minute > 59)
            {
                MessageBox.Show("Некоректно введена хвилина!");
                return;
            }

            alarmHour = hour;
            alarmMinute = minute;
            alarmSet = true;
            this.Text += " (Будильник заведено)";
        }

        // Обробник події натискання кнопки "Завести будильник"
        private void SetAlarmButton_Click(object sender, EventArgs e)
        {
            int hour, minute;

            // Перевірка коректності введення години
            if (!int.TryParse(hourTextBox.Text, out hour))
            {
                MessageBox.Show("Некоректне годинне значення!");
                return;
            }

            // Перевірка коректності введення хвилини
            if (!int.TryParse(minuteTextBox.Text, out minute))
            {
                MessageBox.Show("Некоректне хвилинне значення!");
                return;
            }

            SetAlarm(hour, minute);
        }

        // Обробник події натискання кнопки "Вимкнути будильник"
        private void TurnOffAlarmButton_Click(object sender, EventArgs e)
        {
            alarmSet = false;
        }

        // Функція для зміни зображення у PictureBox
        private void ChangeImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    Image image = Image.FromFile(imagePath);
                    clock_PictureBox.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message);
                }
            }
        }

        // Перший варіант циферблату для годинника
        private void image1Button_Click(object sender, EventArgs e)
        {
            string imagePath = "Images/1.gif"; 
            ChangeImage(imagePath);
        }

        // Другий варіант циферблату для годинника
        private void image2Button_Click(object sender, EventArgs e)
        {
            string imagePath = "Images/2.jpg";
            ChangeImage(imagePath);
        }

        // Третій варіант циферблату для годинника
        private void image3Button_Click(object sender, EventArgs e)
        {
            string imagePath = "Images/3.png";
            ChangeImage(imagePath);
        }
    }
}