namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }


        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
            restartBtn.Visible = true;
            restartBtn.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void restartBtnOnClick(object sender, EventArgs e)
        {
            restartBtn.Visible = false;
            restartBtn.Enabled = false;
            pipeSpeed = 8;
            gravity = 15;
            score = 0;
            flappyBird.Location = new Point(100, 150);
            pipeTop.Left = 950;
            pipeBottom.Left = 800;
            scoreText.Text = "Score: "+score ;
            gameTimer.Start();
        }
    }
}