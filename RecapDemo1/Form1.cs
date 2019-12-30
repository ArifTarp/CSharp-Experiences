using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int buttonHeight = 50;
            int buttonWidth = 50;
            int buttonTopSize = 0;
            int buttonLeftSize = 0;

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = buttonHeight;
                    buttons[i, j].Width = buttonWidth;
                    buttons[i, j].Left = buttonLeftSize;
                    buttons[i, j].Top = buttonTopSize;
                    this.Controls.Add(buttons[i, j]);
                    buttonLeftSize += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }
                buttonTopSize += 50;
                buttonLeftSize = 0;
            }
        }
    }
}
