using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
       
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(120, 80, 600, 260));

            game.NewLevel(random);
            UpdateCharacters();
            timer1.Start();
        }

        public void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;

            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        bat.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        bat.Visible = false;
                        batHitPoints.Text = "0";
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        ghost.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {

                        ghost.Visible = false;
                        ghostHitPoints.Text = "0";
                    }

                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        ghoul.Visible = true;
                        enemiesShown++;
                    }
                    else
                    {
                        ghoul.Visible = false;
                        ghoulHitPoints.Text = "0";
                    }
                }
            }

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "RedPotion":
                    weaponControl = redPotion;
                    break;
                case "BluePotion":
                    weaponControl = bluePotion;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
            }
            if (game.CheckPlayerInventory("Sword"))
                SwordInv.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                BowInv.Visible = true;
            if (game.CheckPlayerInventory("RedPotion"))
            {
                if ((game.CheckPotionInventory("RedPotion")) == false)
                    RedPotionInv.Visible = true;
                else
                    RedPotionInv.Visible = false;
            }
            if (game.CheckPlayerInventory("BluePotion"))
            {
                if ((game.CheckPotionInventory("BluePotion")) == false)
                    BluePotionInv.Visible = true;
                else
                {
                    RemovePotionFromInventory("BluePotion");
                }
            }
            if (game.CheckPlayerInventory("Mace"))
                MaceInv.Visible = true;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;

            }
            else
            {
                weaponControl.Visible = true;
            }
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                DialogResult playAgain = MessageBox.Show("Would you like to Play again", "Play Again", MessageBoxButtons.YesNo);
                if (playAgain == DialogResult.Yes)
                    Application.Restart();
                else
                    Application.Exit();

            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);

                UpdateCharacters();
            }



        }
        private void RemovePotionFromInventory(string PotionName)
        {
            if (PotionName == "BluePotion")
                BluePotionInv.Visible = false;
            if (PotionName == "RedPotion")
                RedPotionInv.Visible = false;
            attackUp.Text = "↑";
            attackDown.Visible = true;
            attackLeft.Visible = true;
            attackRight.Visible = true;


        }


        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();

        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();

        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, System.EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, System.EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, System.EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void SwordInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                SwordInv.BorderStyle = BorderStyle.FixedSingle;
                BowInv.BorderStyle = BorderStyle.None;
                MaceInv.BorderStyle = BorderStyle.None;
                RedPotionInv.BorderStyle = BorderStyle.None;
                BluePotionInv.BorderStyle = BorderStyle.None;
            }

        }

        private void BowInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                BowInv.BorderStyle = BorderStyle.FixedSingle;
                SwordInv.BorderStyle = BorderStyle.None;
                MaceInv.BorderStyle = BorderStyle.None;
                RedPotionInv.BorderStyle = BorderStyle.None;
                BluePotionInv.BorderStyle = BorderStyle.None;
            }
        }

        private void MaceInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                MaceInv.BorderStyle = BorderStyle.FixedSingle;
                BowInv.BorderStyle = BorderStyle.None;
                SwordInv.BorderStyle = BorderStyle.None;
                RedPotionInv.BorderStyle = BorderStyle.None;
                BluePotionInv.BorderStyle = BorderStyle.None;
            }
        }

        private void BluePotionInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("BluePotion"))
            {
                game.Equip("BluePotion");
                BluePotionInv.BorderStyle = BorderStyle.FixedSingle;
                BowInv.BorderStyle = BorderStyle.None;
                MaceInv.BorderStyle = BorderStyle.None;
                RedPotionInv.BorderStyle = BorderStyle.None;
                SwordInv.BorderStyle = BorderStyle.None;
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackUp.Text = "Drink";
            }
        }

        private void RedPotionInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("RedPotion"))
            {
                game.Equip("RedPotion");
                RedPotionInv.BorderStyle = BorderStyle.FixedSingle;
                BowInv.BorderStyle = BorderStyle.None;
                MaceInv.BorderStyle = BorderStyle.None;
                SwordInv.BorderStyle = BorderStyle.None;
                BluePotionInv.BorderStyle = BorderStyle.None;
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackUp.Text = "Drink";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game.PlayerHitPoints > 0)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (enemy is Bat)
                    {
                        bat.Location = enemy.Location;
                        enemy.Move(random);
                    }
                    if (enemy is Ghost)
                    {
                        ghost.Location = enemy.Location;
                        enemy.Move(random);
                    }
                    if (enemy is Ghoul)
                    {
                        ghoul.Location = enemy.Location;
                        enemy.Move(random);
                    }
                }
            }     
        }
    }
}

