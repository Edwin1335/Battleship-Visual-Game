using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Text;

namespace GameApplication
{
    public partial class GameControl : UserControl
    {
        // Declare private variables
        Board player1;
        Board player2;
        private List<Button> shipButtons;
        private List<Button> playerButtons;
        private List<PictureBox> computerShips;
        private List<PictureBox> computerPictures;
        private List<int> guesses;
        private int[] computerIndex;
        private int[] playerIndex;
        private bool shipsHaveBeenPlaced = false;
        private int placedShips = 0;
        private int enemyShips = 3;

        public GameControl()
        {
            // Initialize Componenets
            InitializeComponent();            
            shipButtons = new List<Button>();
            computerShips = new List<PictureBox>();
            playerButtons = new List<Button>();
            computerPictures = new List<PictureBox>();
            guesses = new List<int>();
            computerIndex = new int[3];
            playerIndex = new int[3];
            player1 = new Board();
            player2 = new Board();

            // Retrive all controls
            retrieveControls();

            // Place ships for computer
            AIChooseLocation();
        }

        private void AIChooseLocation()
        {
            Random rand = new Random();

            // Generate three random numbers
            List<int> listNumbers = new List<int>();
            int number;
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    number = rand.Next(0, 16);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }

            foreach(int i in listNumbers)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < listNumbers.Count(); i++)
            {
                computerIndex[i] = listNumbers[i];
                computerShips.Add(computerPictures[listNumbers[i]]);
            }
        }

        private void retrieveControls()
        {
            // Get the buttons from player 
            foreach (Control c in this.playerGridPanel.Controls)
            {
                Button b = c as Button;
                if (b != null && b.Name != "AttackButton")
                {
                    playerButtons.Add(b);
                }
            }

            // Get the picture boxes from computer
            foreach (Control con in this.enemyPlayerPanel.Controls)
            {
                PictureBox b = con as PictureBox;
                if (b != null)
                {
                    computerPictures.Add(b);
                }
            }

            // Read from top to bottom
            playerButtons.Reverse();
            computerPictures.Reverse();
        }

        private void A1Button_Click(object sender, EventArgs e)
        {
            if(!shipsHaveBeenPlaced && player1.placeShip(0,0))
            {
                A1Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 0;
                placedShips++;
                shipButtons.Add(A1Button);
                if(placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void A2Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(0, 1))
            {
                A2Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 1;
                placedShips++;
                shipButtons.Add(A2Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void A3Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(0, 2))
            {
                A3Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 2;
                placedShips++;
                shipButtons.Add(A3Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void A4Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(0, 3))
            {
                A4Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 3;
                placedShips++;
                shipButtons.Add(A4Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void B1Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(1, 0))
            {
                B1Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 4;
                placedShips++;
                shipButtons.Add(B1Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void B2Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(1, 1))
            {
                B2Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 5;
                placedShips++;
                shipButtons.Add(B2Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void B3Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(1, 2))
            {
                B3Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 6;
                placedShips++;
                shipButtons.Add(B3Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void B4Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(1, 3))
            {
                B4Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 7;
                placedShips++;
                shipButtons.Add(B4Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void C1Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(2, 0))
            {
                C1Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 8;
                placedShips++;
                shipButtons.Add(C1Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void C2Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(2, 1))
            {
                C2Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 9;
                placedShips++;
                shipButtons.Add(C2Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void C3Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(2, 2))
            {
                C3Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 10;
                placedShips++;
                shipButtons.Add(C3Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void C4Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(2, 3))
            {
                C4Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 11;
                placedShips++;
                shipButtons.Add(C4Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void D1Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(3, 0))
            {
                D1Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 12;
                placedShips++;
                shipButtons.Add(D1Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void D2Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(3, 1))
            {
                D2Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 13;
                placedShips++;
                shipButtons.Add(D2Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void D3Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(3, 2))
            {
                D3Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 14;
                placedShips++;
                shipButtons.Add(D3Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void D4Button_Click(object sender, EventArgs e)
        {
            if (!shipsHaveBeenPlaced && player1.placeShip(3, 2))
            {
                D4Button.BackgroundImage = shipImageList.Images[placedShips];
                playerIndex[placedShips] = 15;
                placedShips++;
                shipButtons.Add(D4Button);
                if (placedShips == 3)
                {
                    shipsHaveBeenPlaced = true;
                    instructionLabel.Text = "Ships Have Been Place, ATTACK!!!";
                    attackListBox.Enabled = true;
                    AttackButton.Enabled = true;
                }
            }
        }

        private void EnemyAttack()
        {
            Random rand = new Random();
            int index = rand.Next(0, playerButtons.Count());
            bool hit = false;

            for(int i = 0; i < shipButtons.Count(); i++)
            {
                if(shipButtons[i].Tag == playerButtons[index].Tag)
                {
                    shipButtons.RemoveAt(i);
                    hit = true;
                    playerButtons[index].BackgroundImage = attackImageList.Images[2];
                    playerButtons.RemoveAt(index);
                    placedShips--;
                    hit = true;
                }
            }

            if(!hit)
            {
                playerButtons[index].BackgroundImage = attackImageList.Images[1];
                instructionLabel.Text = "Enemy Guess: " + playerButtons[index].Tag.ToString();
                playerButtons.RemoveAt(index);
            }

            if(placedShips == 0)
            {
                attackListBox.Enabled = false;
                AttackButton.Enabled = false;
                MessageBox.Show("You Lose");
            }

        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            bool hit = false;
            int index;

            if (attackListBox.SelectedIndex != -1 && !alreadyGuesed(attackListBox.SelectedIndex))
            {
                index = attackListBox.SelectedIndex;
                for(int i =0; i < 3; i++)
                {
                    if(computerIndex[i] == index)
                    {
                        computerShips[i].BackgroundImage = attackImageList.Images[0];
                        attackListBox.Items[index] = "HIT";
                        enemyShips--;
                        hit = true;
                        break;
                    }
                }

                if(hit == false)
                {
                    computerPictures[index].BackgroundImage = attackImageList.Images[1];
                    attackListBox.Items[index] = "MISS";
                }

                if(enemyShips == 0)
                {
                    MessageBox.Show("You have WON!!");
                    attackListBox.Enabled = false;
                    AttackButton.Enabled = false;
                    return;
                }
                guesses.Add(index);
                EnemyAttack();
            }
        }

        private bool alreadyGuesed(int x)
        {
            foreach(int g in guesses)
            {
                if(g == x)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
