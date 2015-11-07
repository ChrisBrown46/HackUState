using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectTheDots
{
    public partial class GameFinderForm : Form
    {
        public GameFinderForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            (new MainMenuForm()).Show();
            this.Close();
        }

        private void gameStartButton_Click(object sender, EventArgs e)
        {

            int gameRows = 0;
            int gameColumns = 0;

            if (beginnerMode.Checked)
            {
                gameRows = 5;
                gameColumns = 5;
            }
            else if (intermediateMode.Checked)
            {
                gameColumns = 10;
                gameRows = 10;
            }
            else if (advancedMode.Checked)
            {
                gameRows = 15;
                gameColumns = 15;
            }
            else
                return;

            (new GameForm(gameRows, gameColumns)).Show();
            this.Close();
        }
    }
}
