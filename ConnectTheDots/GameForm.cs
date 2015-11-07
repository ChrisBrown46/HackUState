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
        public GameForm()
        {
            InitializeComponent();
        }
        public GameForm(int row, int columns)
        {
            game = new TwoPlayerGame(row, columns);
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(200 + row*50, 50 + columns*50);
            buildBoard(row, columns);
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
                    panel.Name = "verticalPanel" + i + "." + j;
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
                    panel.Name = "horizontalPanel" + i + "." + j;
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
                    label.Name = "label" + i + "." + j;
                    label.Parent = this;
                    label.Text = ".";
                    label.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
                    dotLabels.Add(label);
                    this.Controls.Add(label);
                }
            }

            
        }
        private void panel_click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.Red;
            TESTLABEL.Text = panel.Name;
        }
    }
}
