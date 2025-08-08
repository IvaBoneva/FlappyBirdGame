namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pipeTop = new PictureBox();
            flappyBird = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            restartBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.BackColor = Color.Transparent;
            pipeTop.Image = Properties.Resources.pipe2;
            pipeTop.Location = new Point(406, -34);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(115, 224);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.BackColor = Color.Transparent;
            flappyBird.Image = Properties.Resources.bird1;
            flappyBird.Location = new Point(53, 241);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(68, 51);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 1;
            flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.Transparent;
            pipeBottom.Image = Properties.Resources.pipe1;
            pipeBottom.Location = new Point(289, 398);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(115, 228);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            pipeBottom.Click += pictureBox3_Click;
            // 
            // ground
            // 
            ground.BackColor = Color.Transparent;
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-4, 564);
            ground.Name = "ground";
            ground.Size = new Size(563, 166);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Wheat;
            scoreText.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreText.Location = new Point(12, 612);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(102, 27);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // restartBtn
            // 
            restartBtn.BackColor = Color.Wheat;
            restartBtn.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            restartBtn.Location = new Point(179, 241);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(214, 65);
            restartBtn.TabIndex = 5;
            restartBtn.Text = "Play Again";
            restartBtn.UseVisualStyleBackColor = false;
            restartBtn.Visible = false;
            restartBtn.Click += restartBtnOnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(558, 659);
            Controls.Add(restartBtn);
            Controls.Add(scoreText);
            Controls.Add(flappyBird);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = "Flappy Bird Game";
            Load += Form1_Load;
            KeyDown += gameKeyIsDown;
            KeyUp += gameKeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox flappyBird;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private Button restartBtn;
    }
}
