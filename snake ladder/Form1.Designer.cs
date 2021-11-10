namespace snake_ladder
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
            this.board_game = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GameCube = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bluePositionLbl = new System.Windows.Forms.Label();
            this.redPositionLbl = new System.Windows.Forms.Label();
            this.displayBlueScore = new System.Windows.Forms.Label();
            this.displayRedScore = new System.Windows.Forms.Label();
            this.turnLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // board_game
            // 
            this.board_game.BackColor = System.Drawing.Color.AntiqueWhite;
            this.board_game.Location = new System.Drawing.Point(12, 12);
            this.board_game.Name = "board_game";
            this.board_game.Size = new System.Drawing.Size(868, 584);
            this.board_game.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 611);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(143, 55);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1070, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 115);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameCube
            // 
            this.GameCube.Enabled = false;
            this.GameCube.Location = new System.Drawing.Point(1070, 357);
            this.GameCube.Name = "GameCube";
            this.GameCube.Size = new System.Drawing.Size(115, 47);
            this.GameCube.TabIndex = 2;
            this.GameCube.Text = "Roll";
            this.GameCube.UseVisualStyleBackColor = true;
            this.GameCube.Click += new System.EventHandler(this.GameCube_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(905, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 86);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::snake_ladder.Properties.Resources.soldier_2;
            this.pictureBox2.Location = new System.Drawing.Point(59, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::snake_ladder.Properties.Resources.soldier_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bluePositionLbl
            // 
            this.bluePositionLbl.AutoSize = true;
            this.bluePositionLbl.Location = new System.Drawing.Point(1058, 35);
            this.bluePositionLbl.Name = "bluePositionLbl";
            this.bluePositionLbl.Size = new System.Drawing.Size(18, 20);
            this.bluePositionLbl.TabIndex = 4;
            this.bluePositionLbl.Text = "0";
            // 
            // redPositionLbl
            // 
            this.redPositionLbl.AutoSize = true;
            this.redPositionLbl.Location = new System.Drawing.Point(1058, 76);
            this.redPositionLbl.Name = "redPositionLbl";
            this.redPositionLbl.Size = new System.Drawing.Size(18, 20);
            this.redPositionLbl.TabIndex = 5;
            this.redPositionLbl.Text = "0";
            // 
            // displayBlueScore
            // 
            this.displayBlueScore.AutoSize = true;
            this.displayBlueScore.Location = new System.Drawing.Point(965, 35);
            this.displayBlueScore.Name = "displayBlueScore";
            this.displayBlueScore.Size = new System.Drawing.Size(91, 20);
            this.displayBlueScore.TabIndex = 4;
            this.displayBlueScore.Text = "Blue Score:";
            // 
            // displayRedScore
            // 
            this.displayRedScore.AutoSize = true;
            this.displayRedScore.Location = new System.Drawing.Point(967, 76);
            this.displayRedScore.Name = "displayRedScore";
            this.displayRedScore.Size = new System.Drawing.Size(89, 20);
            this.displayRedScore.TabIndex = 5;
            this.displayRedScore.Text = "Red Score:";
            // 
            // turnLbl
            // 
            this.turnLbl.AutoSize = true;
            this.turnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.turnLbl.Location = new System.Drawing.Point(957, 114);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(175, 37);
            this.turnLbl.TabIndex = 6;
            this.turnLbl.Text = "Turn: Blue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(921, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "אדום זה נחש ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(921, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "לבן כחול זה סולם";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 718);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turnLbl);
            this.Controls.Add(this.displayRedScore);
            this.Controls.Add(this.displayBlueScore);
            this.Controls.Add(this.redPositionLbl);
            this.Controls.Add(this.bluePositionLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GameCube);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.board_game);
            this.Name = "Form1";
            this.Text = "snake ladder";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board_game;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GameCube;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bluePositionLbl;
        private System.Windows.Forms.Label redPositionLbl;
        private System.Windows.Forms.Label displayBlueScore;
        private System.Windows.Forms.Label displayRedScore;
        private System.Windows.Forms.Label turnLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

