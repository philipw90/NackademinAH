using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shotgun.Game_Mechanics;

namespace Shotgun
{
    public partial class Form1 : Form
    {
                    
        GameMechanics _gameMechanics= new GameMechanics();

        public Form1()
        {
            InitializeComponent();
            RefreshLabel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _gameMechanics.GameScenario(1);
            RefreshLabel();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            _gameMechanics.GameScenario(3);
            RefreshLabel();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            _gameMechanics.GameScenario(2);
            RefreshLabel();
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            _gameMechanics.GameScenario(4);
            RefreshLabel();
        }

        private void lblAmmoCountPlayer_Click(object sender, EventArgs e)
        {
       
        }

        private void lblAmmoCountComputer_Click(object sender, EventArgs e)
        {
          
        }

        public void RefreshLabel()
        {
            lblAmmoCountComputer.Text = _gameMechanics.AmmoCounterAi().ToString();
            lblAmmoCountPlayer.Text = _gameMechanics.AmmoCounterPlayer().ToString();
            lblShowAction.Text = _gameMechanics.ShowResult();
            btnShotgun.Visible = _gameMechanics.EnableShotgun();
            btnShoot.Visible = _gameMechanics.EnableFire();

            if (_gameMechanics.WinScenario()==1)
            {
                MessageBox.Show("AI has won!!");
                _gameMechanics.PlayAgain();
            }
            else if (_gameMechanics.WinScenario()==2)
            {
                MessageBox.Show("Player has won!!");
                _gameMechanics.PlayAgain();
            }

        }


    }
}
