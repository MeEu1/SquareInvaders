/*
 
 
    CREATOR: Artur R. M. D. Azevedo
    GITHUB: MeEu1

    TOOLS: Visual Studio Community 2017
    PROJECT TYPE: WINDOWS FORMS
 
    (^^)

 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        static Timer Drawer;//Draw the screen.
        static Timer EnemyMovement;//Handles the movement of the enemies.
        static Graphics G;
        static int EnemiesCount;

        #region GameObjects
        static Player Player01;
        static Drop PlayerDrop;
        static Enemy[] Enemies;
        #endregion

        public Form1()
        {
            InitializeComponent();

            G = this.CreateGraphics();

            //Create a new Player object.
            Player01 = new Player();
            Player01.Create(this.Width / 2, this.Height - 100);

            //Create a new Drop object.
            PlayerDrop = new Drop();
            PlayerDrop.Create(Player01.Xpos, Player01.Ypos);

            //Create a new Enemy array.
            Enemies = new Enemy[6];
            for(int i = 0; i < Enemies.Length; i++)
            {
                Enemies[i] = new Enemy();
                Enemies[i].Create((i * 60) + 55, 50);
            }
            EnemiesCount = Enemies.Length;//Get the enemies count.

            Drawer = new Timer();//Create the sprite manager.

            EnemyMovement = new Timer();//Create the manager that will manage the movement of the enemies.
        }

        private void OnLoad(object sender, EventArgs e)
        {
            int value = 15;//Value to go up/down.
            int round = 0;//Type of movement(up or down).

            Drawer.Interval = 250;//It's called every 0.25 seconds.

            Drawer.Tick += (object s, EventArgs sa) =>
            {
                Draw();
            };

            EnemyMovement.Interval = 1000;//It's called every 1 second.

            EnemyMovement.Tick += (object s, EventArgs sa) =>
            {
                //Check the type of movement.
                if (round == 0)
                {
                    round++;
                    value = 15;
                }
                else
                {
                    round = 0;
                    value = -15;
                }

                //Move the every enemy up and down, depending on it's y axe.
                for (int i = 0; i < Enemies.Length; i++)
                {
                    //Move.
                    Enemies[i].Move(value);
                }
            };

            //Start the timers/managers.
            Drawer.Start();
            EnemyMovement.Start();
        }

        public void Draw()
        {
            if(EnemiesCount < 0)
            {
                //Stop the timers.
                Drawer.Stop();
                EnemyMovement.Stop();

                //Hide this window.
                this.Hide();

                //Show the game over window.
                GameOver go = new GameOver();
                go.ShowDialog();

                //Close this window.
                this.Close();
                
            }
            else
            {
                //Clean the screen and then draw everything.
                G.Clear(Color.Transparent);

                DrawPlayer();
                DrawEnemies();
            }

        }

        private void DrawPlayer()
        {
            //Draw the player.
            Player01.Create(Player01.Xpos, Player01.Ypos);
            Player01.Draw(this);
        }

        private void DrawDrop()
        {
            //Draw the drop if it has been setten.
            if (PlayerDrop.IsSet)
            {
                PlayerDrop.Create(Player01.Xpos, Player01.Ypos);//Set the drop's position to the player's one.

                //Move the drop up and then draws it until it reaches the other side of the screen.
                for (int i = 0; i < 100; i++)
                {
                    G.Clear(Color.Transparent);

                    PlayerDrop.Draw(this);
                    PlayerDrop.Move(-5);
                    
                    for(int j = 0; j < Enemies.Length; j++)
                    {
                        if(Enemies[j].CollisionDetected(PlayerDrop))
                        {
                            Enemies[j].Delete = true;
                            EnemiesCount--;
                            goto stop;
                        }
                    }
                }

                stop:;

                PlayerDrop.IsSet = false;//It stops it.
            }
        }

        private void DrawEnemies()
        {
            //Draw the enemies.
            for(int i = 0; i < Enemies.Length; i++)
            {
                if (!Enemies[i].Delete)
                {
                    Enemies[i].Draw(this);
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            //Draw everything on the screen.
            Draw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Controls.
            if(e.KeyCode == Keys.Left)
            {
                Player01.Move(-5); //Move the player left.
            }
            else if(e.KeyCode == Keys.Right)
            {
                Player01.Move(5);//Move player right
            }
            else if(e.KeyCode == Keys.Space)
            {
                PlayerDrop.IsSet = true;

                DrawDrop();
            }
        }
    }
}
