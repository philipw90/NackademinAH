using System;
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
        public bool winResult;
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

            if (aiAmmo == 0)
            {
                Random first = new Random();
                aiChoice = first.Next(1, 3);
            }
            else if (aiAmmo > 0 && aiAmmo < 3)
            {
                Random second = new Random();
                aiChoice = second.Next(1, 4);
            }
            else if (aiAmmo == 3)
            {
                aiChoice = 4;
            }

            return aiChoice;
        }

        public void GameScenario(int playersChoice)
        {
            if (playersChoice == 1) //Ladda
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
                    winResult = true;
                }
                else
                {
                    result = "Player reloaded, Ai won using shotgun";
                    winResult = true;
                }
            }
            if (playersChoice == 2) //Block
            {
                if (CompRandomNumber() == 1)
                {
                    result = "Player blocked, Ai reload";
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
                    result = "Player blocked, Ai won using shotgun";
                    winResult = true;
                }
            }
            if (playersChoice == 3) //Skjut
            {
                if (CompRandomNumber() == 1)
                {
                    playerAmmo--;
                    result = "Player shoot, Ai reloaded";
                    winResult = false;
                }
                else if (CompRandomNumber() == 2)
                {
                    playerAmmo--;
                    result = "Player shoot, Ai block";
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
                    winResult = true;
                }
            }
            if (playersChoice == 4) //Shotgun
            {
                if (CompRandomNumber() == 4)
                {
                    result = "You both died using shotgun";
                }
                else
                {
                    result = "You won using shotgun";
                    winResult = false;
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

        public bool WinScenario()
        {
            string aiWon = "Ai won!";
            string playerWon = "Player Won!";

            if (winResult != true)
            {
                return ToString(aiWon);
            }
            else if (winResult = false)
            {
                MessageBox.Show("Dinner dinner cheicken winer");
            }

        }
    }
}



