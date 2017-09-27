using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SuperAdventure superAdventure = new SuperAdventure(true)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            superAdventure.ShowDialog(this);
            Close();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            SuperAdventure superAdventure = new SuperAdventure(false);
            superAdventure.StartPosition = FormStartPosition.CenterParent;
            superAdventure.ShowDialog(this);
            Close();
        }
    }
}
