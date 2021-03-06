﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun.Game_Mechanics
{
    public class GameMechanics
    {
        public int playerAmmo = 0;
        public int aiAmmo = 0;
        public string result;
        public int playerPoints = 0;
        public int aiPoints = 0;

        // Comp Actions
        // 1 = Ladda
        // 2 = Block
        // 3 = skjut
        // 4 = Shotgun
        public string ShowResult()
        {
            return result;
        }

        public int AmmoCounterPlayer()
        {
            return playerAmmo;
        }

        public int AmmoCounterAi()
        {
            return aiAmmo;
        }

        public int CompRandomNumber()
        {
            int aiChoice = 1;
            Random random = new Random();

            if (aiAmmo == 0)
            {
                aiChoice = random.Next(1, 3);
            }
            else if (aiAmmo > 0 && aiAmmo < 3)
            {
                aiChoice = random.Next(1, 4);
            }
            else if (aiAmmo == 3)
            {
                aiChoice = 4;
            }

            return aiChoice;
        }

        public void GameScenario(int playersChoice)
        {
            //Ladda
            if (playersChoice == 1)
            {
                if (CompRandomNumber() == 1)
                {
                    aiAmmo++;
                    playerAmmo++;
                    result = "Both reloaded";
                }
                else if (CompRandomNumber() == 2)
                {
                    result = "Player reloaded, AI blocked";
                    playerAmmo++;
                }
                else if (CompRandomNumber() == 3)
                {
                    result = "Player reloaded, AI shoot and won";
                    aiPoints++;
                }
                else
                {
                    result = "Player reloaded, AI won using shotgun";
                    aiPoints++;
                }
            }

            if (playersChoice == 2) //Block
            {
                if (CompRandomNumber() == 1)
                {
                    result = "Player blocked, AI reload";
                    aiAmmo++;
                }
                else if (CompRandomNumber() == 2)
                {
                    result = "Both blocked";
                }
                else if (CompRandomNumber() == 3)
                {
                    aiAmmo--;
                    result = "Player blocked, and AI Shoot";
                }
                else
                {
                    result = "Player blocked, AI won using shotgun";
                    aiPoints++;
                }
            }

            //Skjut
            if (playersChoice == 3)
            {
                if (CompRandomNumber() == 1)
                {
                    playerAmmo--;
                    result = "Player shoot, AI reloaded";
                    playerPoints++;
                }
                else if (CompRandomNumber() == 2)
                {
                    playerAmmo--;
                    result = "Player shoot, AI block";
                }
                else if (CompRandomNumber() == 3)
                {
                    aiAmmo--;
                    playerAmmo--;
                    result = "Both shoot";
                }
                else
                {
                    result = "Player shoot but Ai won using shotgun";
                    aiPoints++;
                }
            }

            //Shotgun
            if (playersChoice == 4)
            {
                if (CompRandomNumber() == 4)
                {
                    result = "You both died using shotgun";
                }
                else
                {
                    result = "You won using shotgun";
                    playerPoints++;
                }
            }
        }

        public bool EnableShotgun()
        {
            if (playerAmmo == 3)
            {
                return true;
            }

            return false;
        }

        public bool EnableFire()
        {
            if (playerAmmo > 0)
            {
                return true;
            }

            return false;
        }

        public int WinScenario()
        {
            if (aiPoints >= 1)
            {
                return 1;
            }

            if (playerPoints >= 1)
            {
                return 2;
            }

            return 3;
        }

        public void PlayAgain()
        {
            DialogResult playAgain = MessageBox.Show("Do you want to play again?", "", MessageBoxButtons.YesNo);

            if (playAgain == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else if (playAgain == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}