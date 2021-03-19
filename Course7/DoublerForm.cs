using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
//Игрок должен постараться получить это число за минимальное количество ходов.
//в) *Добавить кнопку «Отменить», которая отменяет последние ходы.
//Самошина Анна 

namespace Course7
{
    public partial class DoublerForm : Form
    {
        private Stack<CommandType> commandsList;
        private int currentValue = 1;
        private int goalValue = 0;
        private DoublerState currentState;

        public DoublerForm()
        {
            InitializeComponent();
            commandsList = new Stack<CommandType>();
            currentState = DoublerState.Idle;
        }

        private void UpdateCommandsCount()
        {
            lblCommandCountValue.Text = commandsList.Count.ToString();
        }

        private void MakeGameStep()
        {
            if (currentValue > goalValue)
            {
                MessageBox.Show($"Ваше число {currentValue}, а надо было набрать {goalValue}","Вы проиграли!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                commandsList = new Stack<CommandType>();
                currentState = DoublerState.Idle;
            }
            else if (currentValue == goalValue)
            {
                MessageBox.Show($"Ура! Ваше число {currentValue},надо было набрать {goalValue}", "Вы выиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                commandsList = new Stack<CommandType>();
                currentState = DoublerState.Idle;
            }

            UpdateCommandsCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentValue += 1;
            lblNumber.Text = currentValue.ToString();
            commandsList.Push(CommandType.AddOne);
            UpdateCommandsCount();

            if (currentState == DoublerState.Playing)
            {
                MakeGameStep();
            }
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            currentValue *= 2;
            lblNumber.Text = currentValue.ToString();
            commandsList.Push(CommandType.MultiplyByTwo);
            UpdateCommandsCount();

            if (currentState == DoublerState.Playing)
            {
                MakeGameStep();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (currentState != DoublerState.Playing)
            {
                currentValue = 1;
                commandsList = new Stack<CommandType>();
                lblNumber.Text = currentValue.ToString();
                UpdateCommandsCount();
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            goalValue = random.Next(5, 1000);
            MessageBox.Show($"Привет! Давай играть! Вам нужно набрать {goalValue} за минимальное число шагов", "Игра", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Начинаем игру
            currentState = DoublerState.Playing;
            currentValue = 1;
            lblNumber.Text = "1";
            commandsList = new Stack<CommandType>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (commandsList.Count == 0)
            {
                return;
            }

            CommandType lastCommandType = commandsList.Pop();

            if (lastCommandType == CommandType.AddOne)
            {
                currentValue -= 1;
            }
            else if (lastCommandType == CommandType.MultiplyByTwo)
            {
                currentValue /= 2;
            }

            lblNumber.Text = currentValue.ToString();
            UpdateCommandsCount();
        }

        private void DoublerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
