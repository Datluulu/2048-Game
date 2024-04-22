namespace game2048 {
    partial class PlayGround {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGround));
            this.target2 = new System.Windows.Forms.Label();
            this.target1 = new System.Windows.Forms.PictureBox();
            this.cube1 = new System.Windows.Forms.PictureBox();
            this.cube16 = new System.Windows.Forms.PictureBox();
            this.cube15 = new System.Windows.Forms.PictureBox();
            this.cube14 = new System.Windows.Forms.PictureBox();
            this.cube13 = new System.Windows.Forms.PictureBox();
            this.cube12 = new System.Windows.Forms.PictureBox();
            this.cube11 = new System.Windows.Forms.PictureBox();
            this.cube10 = new System.Windows.Forms.PictureBox();
            this.cube9 = new System.Windows.Forms.PictureBox();
            this.cube8 = new System.Windows.Forms.PictureBox();
            this.cube7 = new System.Windows.Forms.PictureBox();
            this.cube6 = new System.Windows.Forms.PictureBox();
            this.cube5 = new System.Windows.Forms.PictureBox();
            this.cube4 = new System.Windows.Forms.PictureBox();
            this.cube3 = new System.Windows.Forms.PictureBox();
            this.cube2 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.backOfScore = new System.Windows.Forms.Panel();
            this.bestScore = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.target1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.backOfScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // target2
            // 
            this.target2.AutoSize = true;
            this.target2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.target2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(120)))), ((int)(((byte)(108)))));
            this.target2.Location = new System.Drawing.Point(53, 177);
            this.target2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.target2.Name = "target2";
            this.target2.Size = new System.Drawing.Size(519, 40);
            this.target2.TabIndex = 56;
            this.target2.Text = "Combine numbers to reach 2048!";
            this.target2.Click += new System.EventHandler(this.target2_Click);
            // 
            // target1
            // 
            this.target1.BackColor = System.Drawing.Color.DarkGray;
            this.target1.BackgroundImage = global::game2048.Properties.Resources.score_2048;
            this.target1.Location = new System.Drawing.Point(40, 27);
            this.target1.Margin = new System.Windows.Forms.Padding(4);
            this.target1.Name = "target1";
            this.target1.Size = new System.Drawing.Size(133, 123);
            this.target1.TabIndex = 55;
            this.target1.TabStop = false;
            // 
            // cube1
            // 
            this.cube1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube1.Location = new System.Drawing.Point(40, 246);
            this.cube1.Margin = new System.Windows.Forms.Padding(4);
            this.cube1.Name = "cube1";
            this.cube1.Size = new System.Drawing.Size(133, 123);
            this.cube1.TabIndex = 39;
            this.cube1.TabStop = false;
            // 
            // cube16
            // 
            this.cube16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube16.Location = new System.Drawing.Point(520, 689);
            this.cube16.Margin = new System.Windows.Forms.Padding(4);
            this.cube16.Name = "cube16";
            this.cube16.Size = new System.Drawing.Size(133, 123);
            this.cube16.TabIndex = 54;
            this.cube16.TabStop = false;
            // 
            // cube15
            // 
            this.cube15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube15.Location = new System.Drawing.Point(360, 689);
            this.cube15.Margin = new System.Windows.Forms.Padding(4);
            this.cube15.Name = "cube15";
            this.cube15.Size = new System.Drawing.Size(133, 123);
            this.cube15.TabIndex = 53;
            this.cube15.TabStop = false;
            // 
            // cube14
            // 
            this.cube14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube14.Location = new System.Drawing.Point(200, 689);
            this.cube14.Margin = new System.Windows.Forms.Padding(4);
            this.cube14.Name = "cube14";
            this.cube14.Size = new System.Drawing.Size(133, 123);
            this.cube14.TabIndex = 52;
            this.cube14.TabStop = false;
            // 
            // cube13
            // 
            this.cube13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube13.Location = new System.Drawing.Point(40, 689);
            this.cube13.Margin = new System.Windows.Forms.Padding(4);
            this.cube13.Name = "cube13";
            this.cube13.Size = new System.Drawing.Size(133, 123);
            this.cube13.TabIndex = 51;
            this.cube13.TabStop = false;
            // 
            // cube12
            // 
            this.cube12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube12.Location = new System.Drawing.Point(520, 542);
            this.cube12.Margin = new System.Windows.Forms.Padding(4);
            this.cube12.Name = "cube12";
            this.cube12.Size = new System.Drawing.Size(133, 123);
            this.cube12.TabIndex = 50;
            this.cube12.TabStop = false;
            // 
            // cube11
            // 
            this.cube11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube11.Location = new System.Drawing.Point(360, 542);
            this.cube11.Margin = new System.Windows.Forms.Padding(4);
            this.cube11.Name = "cube11";
            this.cube11.Size = new System.Drawing.Size(133, 123);
            this.cube11.TabIndex = 49;
            this.cube11.TabStop = false;
            // 
            // cube10
            // 
            this.cube10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube10.Location = new System.Drawing.Point(200, 542);
            this.cube10.Margin = new System.Windows.Forms.Padding(4);
            this.cube10.Name = "cube10";
            this.cube10.Size = new System.Drawing.Size(133, 123);
            this.cube10.TabIndex = 48;
            this.cube10.TabStop = false;
            // 
            // cube9
            // 
            this.cube9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube9.Location = new System.Drawing.Point(40, 542);
            this.cube9.Margin = new System.Windows.Forms.Padding(4);
            this.cube9.Name = "cube9";
            this.cube9.Size = new System.Drawing.Size(133, 123);
            this.cube9.TabIndex = 47;
            this.cube9.TabStop = false;
            // 
            // cube8
            // 
            this.cube8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube8.Location = new System.Drawing.Point(520, 394);
            this.cube8.Margin = new System.Windows.Forms.Padding(4);
            this.cube8.Name = "cube8";
            this.cube8.Size = new System.Drawing.Size(133, 123);
            this.cube8.TabIndex = 46;
            this.cube8.TabStop = false;
            // 
            // cube7
            // 
            this.cube7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube7.Location = new System.Drawing.Point(360, 394);
            this.cube7.Margin = new System.Windows.Forms.Padding(4);
            this.cube7.Name = "cube7";
            this.cube7.Size = new System.Drawing.Size(133, 123);
            this.cube7.TabIndex = 45;
            this.cube7.TabStop = false;
            // 
            // cube6
            // 
            this.cube6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube6.Location = new System.Drawing.Point(200, 394);
            this.cube6.Margin = new System.Windows.Forms.Padding(4);
            this.cube6.Name = "cube6";
            this.cube6.Size = new System.Drawing.Size(133, 123);
            this.cube6.TabIndex = 44;
            this.cube6.TabStop = false;
            // 
            // cube5
            // 
            this.cube5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube5.Location = new System.Drawing.Point(40, 394);
            this.cube5.Margin = new System.Windows.Forms.Padding(4);
            this.cube5.Name = "cube5";
            this.cube5.Size = new System.Drawing.Size(133, 123);
            this.cube5.TabIndex = 43;
            this.cube5.TabStop = false;
            // 
            // cube4
            // 
            this.cube4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube4.Location = new System.Drawing.Point(520, 246);
            this.cube4.Margin = new System.Windows.Forms.Padding(4);
            this.cube4.Name = "cube4";
            this.cube4.Size = new System.Drawing.Size(133, 123);
            this.cube4.TabIndex = 42;
            this.cube4.TabStop = false;
            // 
            // cube3
            // 
            this.cube3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube3.Location = new System.Drawing.Point(360, 246);
            this.cube3.Margin = new System.Windows.Forms.Padding(4);
            this.cube3.Name = "cube3";
            this.cube3.Size = new System.Drawing.Size(133, 123);
            this.cube3.TabIndex = 41;
            this.cube3.TabStop = false;
            // 
            // cube2
            // 
            this.cube2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(192)))), ((int)(((byte)(180)))));
            this.cube2.Location = new System.Drawing.Point(200, 246);
            this.cube2.Margin = new System.Windows.Forms.Padding(4);
            this.cube2.Name = "cube2";
            this.cube2.Size = new System.Drawing.Size(133, 123);
            this.cube2.TabIndex = 40;
            this.cube2.TabStop = false;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.background.Location = new System.Drawing.Point(20, 228);
            this.background.Margin = new System.Windows.Forms.Padding(4);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(653, 603);
            this.background.TabIndex = 57;
            this.background.TabStop = false;
            // 
            // backOfScore
            // 
            this.backOfScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(102)))));
            this.backOfScore.Controls.Add(this.bestScore);
            this.backOfScore.Controls.Add(this.textScore);
            this.backOfScore.Location = new System.Drawing.Point(379, 27);
            this.backOfScore.Margin = new System.Windows.Forms.Padding(4);
            this.backOfScore.Name = "backOfScore";
            this.backOfScore.Size = new System.Drawing.Size(295, 123);
            this.backOfScore.TabIndex = 58;
            // 
            // bestScore
            // 
            this.bestScore.AutoSize = true;
            this.bestScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScore.ForeColor = System.Drawing.Color.White;
            this.bestScore.Location = new System.Drawing.Point(25, 71);
            this.bestScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bestScore.Name = "bestScore";
            this.bestScore.Size = new System.Drawing.Size(139, 27);
            this.bestScore.TabIndex = 2;
            this.bestScore.Text = "Best score: 0";
            this.bestScore.Click += new System.EventHandler(this.bestScore_Click);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textScore.ForeColor = System.Drawing.Color.White;
            this.textScore.Location = new System.Drawing.Point(25, 20);
            this.textScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(170, 27);
            this.textScore.TabIndex = 0;
            this.textScore.Text = "Current score: 0";
            this.textScore.Click += new System.EventHandler(this.textScore_Click);
            // 
            // PlayGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(696, 854);
            this.Controls.Add(this.backOfScore);
            this.Controls.Add(this.target2);
            this.Controls.Add(this.target1);
            this.Controls.Add(this.cube1);
            this.Controls.Add(this.cube16);
            this.Controls.Add(this.cube15);
            this.Controls.Add(this.cube14);
            this.Controls.Add(this.cube13);
            this.Controls.Add(this.cube12);
            this.Controls.Add(this.cube11);
            this.Controls.Add(this.cube10);
            this.Controls.Add(this.cube9);
            this.Controls.Add(this.cube8);
            this.Controls.Add(this.cube7);
            this.Controls.Add(this.cube6);
            this.Controls.Add(this.cube5);
            this.Controls.Add(this.cube4);
            this.Controls.Add(this.cube3);
            this.Controls.Add(this.cube2);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PlayGround";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayGround_FormClosing);
            this.Load += new System.EventHandler(this.PlayGround_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.backOfScore.ResumeLayout(false);
            this.backOfScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label target2;
        private System.Windows.Forms.PictureBox target1;
        private System.Windows.Forms.PictureBox cube1;
        private System.Windows.Forms.PictureBox cube16;
        private System.Windows.Forms.PictureBox cube15;
        private System.Windows.Forms.PictureBox cube14;
        private System.Windows.Forms.PictureBox cube13;
        private System.Windows.Forms.PictureBox cube12;
        private System.Windows.Forms.PictureBox cube11;
        private System.Windows.Forms.PictureBox cube10;
        private System.Windows.Forms.PictureBox cube9;
        private System.Windows.Forms.PictureBox cube8;
        private System.Windows.Forms.PictureBox cube7;
        private System.Windows.Forms.PictureBox cube6;
        private System.Windows.Forms.PictureBox cube5;
        private System.Windows.Forms.PictureBox cube4;
        private System.Windows.Forms.PictureBox cube3;
        private System.Windows.Forms.PictureBox cube2;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Panel backOfScore;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label bestScore;
    }
}

