namespace game2048 {
    partial class Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.mainMenu = new System.Windows.Forms.Panel();
            this.soundButton = new System.Windows.Forms.Button();
            this.specButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.Specification = new System.Windows.Forms.Panel();
            this.textSpec = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.labelSpec = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.Specification.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.mainMenu.Controls.Add(this.soundButton);
            this.mainMenu.Controls.Add(this.specButton);
            this.mainMenu.Controls.Add(this.startButton);
            this.mainMenu.Controls.Add(this.labelMenu);
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(522, 694);
            this.mainMenu.TabIndex = 0;
            // 
            // soundButton
            // 
            this.soundButton.BackColor = System.Drawing.Color.Green;
            this.soundButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.soundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundButton.ForeColor = System.Drawing.Color.White;
            this.soundButton.Location = new System.Drawing.Point(142, 476);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(239, 59);
            this.soundButton.TabIndex = 11;
            this.soundButton.Text = "Звук вкл.";
            this.soundButton.UseVisualStyleBackColor = false;
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            // 
            // specButton
            // 
            this.specButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.specButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.specButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specButton.ForeColor = System.Drawing.Color.White;
            this.specButton.Location = new System.Drawing.Point(142, 376);
            this.specButton.Name = "specButton";
            this.specButton.Size = new System.Drawing.Size(239, 59);
            this.specButton.TabIndex = 10;
            this.specButton.Text = "Правила";
            this.specButton.UseVisualStyleBackColor = false;
            this.specButton.Click += new System.EventHandler(this.specButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(142, 276);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(239, 59);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(102)))));
            this.labelMenu.Location = new System.Drawing.Point(167, 160);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(182, 64);
            this.labelMenu.TabIndex = 8;
            this.labelMenu.Text = "Меню";
            // 
            // Specification
            // 
            this.Specification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.Specification.Controls.Add(this.textSpec);
            this.Specification.Controls.Add(this.backButton);
            this.Specification.Controls.Add(this.labelSpec);
            this.Specification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Specification.Location = new System.Drawing.Point(0, 0);
            this.Specification.Name = "Specification";
            this.Specification.Size = new System.Drawing.Size(522, 694);
            this.Specification.TabIndex = 1;
            // 
            // textSpec
            // 
            this.textSpec.AutoSize = true;
            this.textSpec.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSpec.Location = new System.Drawing.Point(24, 125);
            this.textSpec.Name = "textSpec";
            this.textSpec.Size = new System.Drawing.Size(122, 21);
            this.textSpec.TabIndex = 11;
            this.textSpec.Text = "Правила игры";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(29, 606);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 59);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(102)))));
            this.labelSpec.Location = new System.Drawing.Point(73, 30);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(389, 64);
            this.labelSpec.TabIndex = 9;
            this.labelSpec.Text = "Правила игры";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 694);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.Specification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.Specification.ResumeLayout(false);
            this.Specification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Button soundButton;
        private System.Windows.Forms.Button specButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Panel Specification;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label textSpec;
    }
}