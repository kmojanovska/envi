﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envi
{
    public partial class Form1 : Form
    {
        Graphics paper;
        public Boolean flagFromForm = false;
        Character character = null;
        Monsters monsters = null;
        Bullets bullets = null;
        Results results = null;
        public Boolean play = false;
        private string username = "";
        private int level = 1;
        private double time = 0;
        private string name;
        private int score = 0;
        private int monstersKilled = 0;
        private Image characterImage = Properties.Resources.character;
        
        void Play()
        { 
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            play = true;
            label2.Text = "No monsters killed yet";
            monstersKilled = 0;
            time = 0;
            score = 0;
            toggleVisibility();
            btn_play.Visible = true;
            bullets = new Bullets();
            character = new Character();
            character.characterImage = characterImage;
            checkForLevel();
            monsters.AddMonster(new MonsterWeek(170, 15));
            if(level == 1)
            {
                bullets.AddBullet(new BulletType1(character.GetX, character.GetY, 15, name));
            }
            else
            {
                bullets.AddBullet(new BulletType2(character.GetX, character.GetY, 15, name));
            }
        }

        void Pause()
        {
            play = false;
        }

        public Form1()
        {
           
            Pause();
            this.KeyPreview = true;
            InitializeComponent();
            if (tbUsername.Text.Count() == 0)
            {
                btn_play.Enabled = false;
            }
            else
            {
                btn_play.Enabled = true;
            }
            results = new Results();
            string[] lines = System.IO.File.ReadAllLines(@"..\best_results.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                results.AddResult(new Result(parts[0], Int32.Parse(parts[2]), parts[4].ToLower()));
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            if (character != null)
            {
                character.drawCharacter(paper);
                bullets.DrawBullets(paper);
                monsters.DrawMonsters(paper);
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (character != null)
            {
                character.moveCharacter(e.X);
                character.SetX(e.X);
                this.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monsters != null)
                foreach (IMonster m in monsters.GetMonstersList)
                {
                    if (play == true)
                    {
                        m.MoveMonster();
                        if(m is MonsterWeek)
                        {
                            toggleMonstersWings((MonsterWeek)m);
                        }
                        else if(m is MonsterMedium)
                        {
                            toggleMonsterColor((MonsterMedium)m);
                        }
                    }
                    if (character.characterKilledMethod(m.MonsterRect))
                    {
                        timer1.Dispose();
                        timer2.Dispose();
                        timer3.Dispose();
                        timer4.Dispose();
                        string messageBoxText = "Do you want to play again?";
                        string caption = "GAME OVER!!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        MessageBoxIcon icon = MessageBoxIcon.Question;
                        DialogResult dialogResult = MessageBox.Show(messageBoxText, caption, buttons, icon);
                        play = false;
                        if (dialogResult == DialogResult.Yes)
                        {
                            Result result = new Result(username, score, name);
                            results.AddResult(result);
                            System.IO.File.WriteAllLines(@"..\best_results.txt", results.bestResults());
                            Play();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            Result result = new Result(username, score, name);
                            results.AddResult(result);
                            System.IO.File.WriteAllLines(@"..\best_results.txt", results.bestResults());
                            toggleVisibility();
                            Pause();
                        }
                    }
                    foreach (IBullet bullet in bullets.GetBulletsList)
                    {
                        if (m.Collision(bullet.BulletRect))
                        {
                            bullets.KillBullet(bullet);
                            BulletType1 b = new BulletType1(character.GetX, character.GetY, 30, name);
                            bullets.AddBullet(b);
                            if (name == "thor")
                            {
                                b.bulletImage = Properties.Resources.hammer1;
                            }
                            else
                            {
                                b.bulletImage = Properties.Resources.fireBig;
                            }
                            
                            if (m is MonsterMedium)
                            {
                                m.IncreaseStrength();
                                if (m.GetStrength()==2)
                                {
                                    monstersKilled += 2;
                                    monsters.KillMonster(m);
                                }
                            }
                            else if( m is MonsterWeek)
                            {
                                monsters.KillMonster(m);
                                monstersKilled++;
                            } else if(m is MonsterStrong)
                            {
                                m.IncreaseStrength();
                                if (m.GetStrength() == 3)
                                {
                                    monstersKilled += 3;
                                    monsters.KillMonster(m);
                                }
                            }

                            label2.Text = String.Format("{0} monsters killed so far.", monstersKilled);
                            return;
                        }
                    }
                    
                }


            this.Invalidate();
        }

        private void toggleMonstersWings(MonsterWeek monster)
        {

                if (monster.areWingsOpen)
                {
                    monster.monsterImage = Properties.Resources.monsterWingsOpen;
                    monster.areWingsOpen = false;
                }
                else
                {
                    monster.monsterImage = Properties.Resources.monsterWeek;
                    monster.areWingsOpen = true;
                }
            
        }
        private void toggleMonsterColor(MonsterMedium monster)
        {
            if (monster.isColored)
            {
                monster.monsterImage = Properties.Resources.Witch;
                monster.isColored = false;
            }
            else
            {
                monster.monsterImage = Properties.Resources.WitchColor;
                monster.isColored = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            name = "deadpool";
            label1.Text = "0";
            label2.Text = "No monsters killed yet";
        }
        public void InitTimer()
        {

            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 100; // in miliseconds
            timer2.Start();
            this.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                foreach (IBullet bullet in bullets.GetBulletsList)
                {
                    bullet.x = character.GetX;
                    bullet.y = character.GetY;
                    bullet.MoveBullet(character.GetX, character.GetY);
                }
                time += 0.1;
                label1.Text = String.Format("{0:N2}", time);
                score = (int)(time * 10) * monstersKilled;
                label9.Text = score.ToString();
            }
            this.Invalidate();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            btn_play.Text = "Restart";
            username = tbUsername.Text;
            Play();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                checkForLevel();
                this.Invalidate();
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {   
            if(play == true)
            {
                bullets = new Bullets();
                if(level == 1)
                {
                    bullets.AddBullet(new BulletType1(character.GetX, character.GetY, 30, name));
                }
                else
                {
                    bullets.AddBullet(new BulletType2(character.GetX, character.GetY, 30, name));
                }
                this.Invalidate();
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (play == true)
            {
                if(level == 1)
                {
                    bullets.AddBullet(new BulletType1(character.GetX, character.GetY, 30, name));
                }
                else
                {
                    bullets.AddBullet(new BulletType2(character.GetX, character.GetY, 30, name));
                }
                
                this.Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnDeadPool_Click(object sender, EventArgs e)
        {
            characterImage = Properties.Resources.character;
            name = "deadpool";
            lblCharacter.Text = "DEADPOOL";
        }

        private void btnThor_Click(object sender, EventArgs e)
        {
            characterImage = Properties.Resources.thor;
            name = "thor";
            lblCharacter.Text = "THOR";
        }

        private void btnIronMan_Click(object sender, EventArgs e)
        {
            characterImage = Properties.Resources.hulk;
            name = "hulk";
            lblCharacter.Text = "HULK";
        }

        private void btnHulk_Click(object sender, EventArgs e)
        {
            characterImage = Properties.Resources.iron_man;
            name = "ironman";
            lblCharacter.Text = "IRONMAN";
        }

        private void toggleVisibility()
        {
            if(play==true)
            {
                label10.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label9.Visible = true;
                btnResults.Visible = false;
                lblCharacter.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                btnDeadPool.Visible = false;
                btnHulk.Visible = false;
                btnIronMan.Visible = false;
                btnThor.Visible = false;
                tbUsername.Visible = false;
                lblUsername.Visible = false;
            }
            else
            {
                tbUsername.Visible = false;
                lblUsername.Visible = false;
                label10.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label9.Visible = false;
                btn_play.Visible = true;
                btnResults.Visible = true;
                btn_play.Text = "PLAY!";
                lblCharacter.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                btnDeadPool.Visible = true;
                btnHulk.Visible = true;
                btnIronMan.Visible = true;
                btnThor.Visible = true;
                
            }
        }
        public void checkForLevel()
        {
            if(score > 1200)
            {
                level = 3;
                monsters = new Monsters(3);
                label10.Text = "Level 3!";
                Form1.ActiveForm.BackgroundImage = Envi.Properties.Resources._3;
                label10.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            }
            else if (score > 600 && score <=1200)
            {
                level = 2;
                monsters = new Monsters(2);
                label10.Text = "Level 2!";
                Form1.ActiveForm.BackgroundImage = Envi.Properties.Resources.sky;
                label10.Font = new Font("Comic Sans MS", 20, FontStyle.Bold);
            }
            else if(score <= 600)
            {
                level = 1;
                monsters = new Monsters(1);
                label10.Text = "Level 1";
                Form1.ActiveForm.BackgroundImage = Envi.Properties.Resources.back;
                label10.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p')
            {
                if (play == true)
                {
                    play = false;
                    lblPause.Visible = true;
                }
                else
                {
                    play = true;
                    lblPause.Visible = false;
                }
                
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.Show();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (tbUsername.Text.Count() == 0)
            {
                btn_play.Enabled = false;
            }
            else
            {
                btn_play.Enabled = true;
            }

        }
    }
}
