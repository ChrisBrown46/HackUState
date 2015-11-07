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
    public partial class GameForm : Form
    {
        private Label player1ScoreBox;
        private Label player2ScoreBox;
        public GameForm()
        {
            InitializeComponent();
        }
        public GameForm(int row, int columns)
        {
            game = new TwoPlayerGame(row, columns);
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(300 + row*50, 50 + columns*50);
            buildBoard(row, columns);
        }
        private void SeraDragForm_closeForm(Object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void buildBoard(int r, int c)
        {
            List<Panel> edgePanels = new List<Panel>();
            for (int i = 0; i < r; ++i)
            {
                for (int j = 1; j < c; ++j)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(5, 40);
                    panel.Location = new System.Drawing.Point(35 + i*50, -3 + j*50);
                    panel.Name = "vertical|" + (i) + "|" + (j - 1);
                    panel.Parent = this;
                    panel.Text = "";
                    panel.BackColor = Color.FromArgb(25, Color.Black);
                    panel.Click += (s, e) => { panel_click(s, e); };
                    panel.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
                    edgePanels.Add(panel);
                    this.Controls.Add(panel);
                }
            }
            for (int i = 0; i < c - 1; ++i)
            {
                for (int j = 0; j < r + 1; ++j)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(40, 5);
                    panel.Location = new System.Drawing.Point(42 + i * 50, -9 + j * 50);
                    panel.Name = "horizontal|" + (i) + "|" + (j - 1);
                    panel.Parent = this;
                    panel.Text = "";
                    panel.BackColor = Color.FromArgb(25, Color.Black);
                    panel.Click += (s, e) => { panel_click(s, e); };
                    panel.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
                    edgePanels.Add(panel);
                    this.Controls.Add(panel);
                }
            }
            
            List<Label> dotLabels = new List<Label>();
            for (int i = 0; i < r; ++i)
            {
                for (int j = 0; j < c; ++j)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(20 + i*50, 1 + j*50);
                    label.Name = "label" + (i - 1) + "|" + (j - 1);
                    label.Parent = this;
                    label.Text = ".";
                    label.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
                    dotLabels.Add(label);
                    this.Controls.Add(label);
                }
            }

            player1ScoreBox = new Label();
            player2ScoreBox = new Label();
            player1ScoreBox.ForeColor = Color.Green;
            player1ScoreBox.AutoSize = true;
            player2ScoreBox.AutoSize = true;
            player1ScoreBox.Location = new System.Drawing.Point(20 + r * 50, 10);
            player2ScoreBox.Location = new System.Drawing.Point(20 + r * 50, 40);
            player1ScoreBox.Parent = this;
            player2ScoreBox.Parent = this;
            player1ScoreBox.Text = "Player 1's Score:0";
            player2ScoreBox.Text = "Player 2's Score:0";
            player1ScoreBox.Font = new Font("Microsoft Sans Serif", 16.4F, FontStyle.Bold);
            player2ScoreBox.Font = new Font("Microsoft Sans Serif", 16.4F, FontStyle.Bold);
            this.Controls.Add(player1ScoreBox);
            this.Controls.Add(player2ScoreBox);
            
        }
        private void panel_click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel.BackColor == Color.Red)
                return;
            panel.BackColor = Color.Red;
            
            string name = panel.Name;   // Example, first row, second column, name = horizontalPanel|1|1
            char[] delimiterChars = { '|' };
            string[] words = name.Split(delimiterChars);    //Just need 2nd and 3rd item
            bool vertical = false;
            if (words[0] == "vertical")
                vertical = true;
            int column = int.Parse(words[1]);
            int row = int.Parse(words[2]);

            int updatedScore = game.addEdge(row, column, vertical);
            
            if (game._player1Turn)
            {
                delimiterChars[0] = ':';
                string[] scoreList = player1ScoreBox.Text.Split(delimiterChars);
                if (updatedScore <= int.Parse(scoreList[1]))
                    game._player1Turn = false;
                player1ScoreBox.Text = scoreList[0] + ":" + updatedScore.ToString();
            }
            else
            {
                delimiterChars[0] = ':';
                string[] scoreList = player2ScoreBox.Text.Split(delimiterChars);
                if (updatedScore <= int.Parse(scoreList[1]))
                    game._player1Turn = true;
                player2ScoreBox.Text = scoreList[0] + ":" + updatedScore.ToString();
            }

            if (game._player1Turn)
            {
                player2ScoreBox.ForeColor = Color.Black;
                player1ScoreBox.ForeColor = Color.Green;
            }
            else
            {
                player1ScoreBox.ForeColor = Color.Black;
                player2ScoreBox.ForeColor = Color.Green;
            }

            int totalBoxes = game._totalBoxes;
            delimiterChars[0] = ':';
            string[] player1ScoreList = player1ScoreBox.Text.Split(delimiterChars);
            string[] player2ScoreList = player2ScoreBox.Text.Split(delimiterChars);
            int total = int.Parse(player1ScoreList[1]) + int.Parse(player2ScoreList[1]);
            if (totalBoxes == total)
            {
                if (int.Parse(player1ScoreList[1]) > int.Parse(player2ScoreList[1]))
                    player1ScoreBox.ForeColor = Color.Yellow;
                else if (int.Parse(player1ScoreList[1]) < int.Parse(player2ScoreList[1]))
                    player2ScoreBox.ForeColor = Color.Yellow;
                else
                {
                    player1ScoreBox.ForeColor = Color.Yellow;
                    player2ScoreBox.ForeColor = Color.Yellow;
                }
            }

        }
    }
}
