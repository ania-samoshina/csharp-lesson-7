using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowDoubler_Click(object sender, EventArgs e)
        {
            DoublerForm doublerForm = new DoublerForm();
            doublerForm.ShowDialog();
        }

        private void btnGuesNumber_Click(object sender, EventArgs e)
        {
            GuessNumberGameForm guessNumberGameForm = new GuessNumberGameForm();
            guessNumberGameForm.ShowDialog();
        }
    }
}
