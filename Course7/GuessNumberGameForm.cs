using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
// а человек пытается его угадать за минимальное число попыток. Для ввода данных от человека используется 
// элемент TextBox.
// Самошина Анна
namespace Course7
{
    public partial class GuessNumberGameForm : Form
    {
        private int goalValue = 0;
        private int attemptsCount = 0;

        public GuessNumberGameForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            goalValue = random.Next(1, 100);
            attemptsCount = 0;
            btnStart.Enabled = false;
            btnAnswer.Enabled = true;
            txtAnswer.Enabled = true;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            bool isCorrectNumber = int.TryParse(txtAnswer.Text, out int answer);
            

            if (!isCorrectNumber)
            {
                MessageBox.Show("Вы ввели не число. Попробуйте еще", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            attemptsCount++;
            lblAttemptsCount.Text = attemptsCount.ToString();

            if (answer > goalValue)
            {
                MessageBox.Show("Вы ввели число больше, чем надо. Попробуйте еще раз!", "Не угадали!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (answer < goalValue)
            {
                MessageBox.Show("Вы ввели число меньше, чем надо. Попробуйте еще раз!", "Не угадали!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Вы угадали! Вам потребовалось {attemptsCount} попыток", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAnswer.Enabled = false;
            btnRestart.Enabled = true;
            txtAnswer.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            txtAnswer.Text = "";
            attemptsCount = 0;
            lblAttemptsCount.Text = "0";
            btnRestart.Enabled = false;
        }
    }
}
