namespace FlappyBird_Prep
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
            components = new System.ComponentModel.Container();
            flappyBird = new System.Windows.Forms.PictureBox();
            pipeTop = new System.Windows.Forms.PictureBox();
            pipeBottom = new System.Windows.Forms.PictureBox();
            ground = new System.Windows.Forms.PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new System.Drawing.Point(92, 298);
            flappyBird.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new System.Drawing.Size(99, 83);
            flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new System.Drawing.Point(572, -163);
            pipeTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new System.Drawing.Size(120, 395);
            pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new System.Drawing.Point(440, 480);
            pipeBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new System.Drawing.Size(120, 395);
            pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new System.Drawing.Point(-29, 695);
            ground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            ground.Name = "ground";
            ground.Size = new System.Drawing.Size(798, 143);
            ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = System.Drawing.Color.PaleGreen;
            lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblScore.Location = new System.Drawing.Point(52, 752);
            lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(123, 31);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Aqua;
            ClientSize = new System.Drawing.Size(713, 802);
            Controls.Add(lblScore);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Controls.Add(flappyBird);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScore;
    }
}

