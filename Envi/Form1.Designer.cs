namespace Envi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIronMan = new System.Windows.Forms.Button();
            this.btnHulk = new System.Windows.Forms.Button();
            this.btnThor = new System.Windows.Forms.Button();
            this.btnDeadPool = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_play.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_play.Location = new System.Drawing.Point(244, 12);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(142, 37);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "PLAY!";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 2200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poplar Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "IRON MAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poplar Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "HULK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poplar Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "THOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poplar Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DEADPOOL";
            // 
            // btnIronMan
            // 
            this.btnIronMan.BackgroundImage = global::Envi.Properties.Resources.iron_man;
            this.btnIronMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIronMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIronMan.FlatAppearance.BorderSize = 3;
            this.btnIronMan.Location = new System.Drawing.Point(279, 356);
            this.btnIronMan.Name = "btnIronMan";
            this.btnIronMan.Size = new System.Drawing.Size(51, 75);
            this.btnIronMan.TabIndex = 12;
            this.btnIronMan.UseVisualStyleBackColor = true;
            this.btnIronMan.Click += new System.EventHandler(this.btnHulk_Click);
            // 
            // btnHulk
            // 
            this.btnHulk.BackgroundImage = global::Envi.Properties.Resources.hulk;
            this.btnHulk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHulk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHulk.FlatAppearance.BorderSize = 3;
            this.btnHulk.Location = new System.Drawing.Point(212, 356);
            this.btnHulk.Name = "btnHulk";
            this.btnHulk.Size = new System.Drawing.Size(51, 75);
            this.btnHulk.TabIndex = 11;
            this.btnHulk.UseVisualStyleBackColor = true;
            this.btnHulk.Click += new System.EventHandler(this.btnIronMan_Click);
            // 
            // btnThor
            // 
            this.btnThor.BackgroundImage = global::Envi.Properties.Resources.thor;
            this.btnThor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThor.FlatAppearance.BorderSize = 3;
            this.btnThor.Location = new System.Drawing.Point(146, 356);
            this.btnThor.Name = "btnThor";
            this.btnThor.Size = new System.Drawing.Size(51, 75);
            this.btnThor.TabIndex = 10;
            this.btnThor.UseVisualStyleBackColor = true;
            this.btnThor.Click += new System.EventHandler(this.btnThor_Click);
            // 
            // btnDeadPool
            // 
            this.btnDeadPool.BackgroundImage = global::Envi.Properties.Resources.character;
            this.btnDeadPool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeadPool.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeadPool.FlatAppearance.BorderSize = 3;
            this.btnDeadPool.Location = new System.Drawing.Point(77, 356);
            this.btnDeadPool.Name = "btnDeadPool";
            this.btnDeadPool.Size = new System.Drawing.Size(51, 75);
            this.btnDeadPool.TabIndex = 9;
            this.btnDeadPool.UseVisualStyleBackColor = true;
            this.btnDeadPool.Click += new System.EventHandler(this.btnDeadPool_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(60, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "WHO DO YOU WANNA PLAY WITH?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(61, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "YOU ARE PLAYING WITH";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblCharacter.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.Location = new System.Drawing.Point(58, 288);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(157, 33);
            this.lblCharacter.TabIndex = 19;
            this.lblCharacter.Text = "DEADPOOL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.NavajoWhite;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(112, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 33);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(274, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 27);
            this.label10.TabIndex = 21;
            this.label10.Text = "Level 1";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPause.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(131, 226);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(132, 44);
            this.lblPause.TabIndex = 22;
            this.lblPause.Text = "PAUSE";
            this.lblPause.Visible = false;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnResults.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResults.Location = new System.Drawing.Point(244, 55);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(142, 41);
            this.btnResults.TabIndex = 23;
            this.btnResults.Text = "Best results!";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(63, 174);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(200, 20);
            this.tbUsername.TabIndex = 24;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.Location = new System.Drawing.Point(63, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(157, 21);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "Your name please...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::Envi.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 461);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIronMan);
            this.Controls.Add(this.btnHulk);
            this.Controls.Add(this.btnThor);
            this.Controls.Add(this.btnDeadPool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_play);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIronMan;
        private System.Windows.Forms.Button btnHulk;
        private System.Windows.Forms.Button btnThor;
        private System.Windows.Forms.Button btnDeadPool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
    }
}

