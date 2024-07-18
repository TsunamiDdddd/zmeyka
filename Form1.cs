
namespace zmeyka
{
    public partial class Form1 : Form
    {
        private int rI, rJ;
        private PictureBox[] snake = new PictureBox[400];
        private PictureBox[] obstacle = new PictureBox[6];
        private Label labelScore;
        private int score = 0;
        private int dirX, dirY;
        private int _width = 800;
        private int _heighth = 800;
        private int _sizeofsides = 40;
        public int intervalofmove;
        public int numberofobstacles;

        private PictureBox fruite;


        public Form1(int intervalofmove, int numberofobstacles)

        {
            InitializeComponent();

            dirX = 1;
            dirY = 0;
            snake[0] = new PictureBox();
            snake[0].Location = new Point(200, 200);
            snake[0].Size = new Size(_sizeofsides, _sizeofsides);
            snake[0].BackColor = Color.Blue;
            fruite = new PictureBox();
            fruite.BackColor = Color.Red;
            this.Controls.Add(snake[0]);
            fruite.Size = new Size(_sizeofsides, _sizeofsides);
            labelScore = new Label();
            labelScore.Text = "Score: 0";
            labelScore.Location = new Point(810, 10);
            this.Controls.Add(labelScore);
            this.numberofobstacles = numberofobstacles;
            this.intervalofmove = intervalofmove;
            _generateMap();

            _generateObstacles(numberofobstacles);

            _generateFruit();
            timer1.Tick += new EventHandler(_update);
            timer1.Interval = intervalofmove;
            timer1.Start();
            this.KeyDown += new KeyEventHandler(OKP);
            label1.Text = timer1.Interval.ToString();
        }

        private void _generateFruit()
        {
            Random r = new Random();
            rI = r.Next(0, _width - _sizeofsides);
            int tempI = rI % _sizeofsides;
            rI -= tempI;
            rJ = r.Next(0, _width - _sizeofsides);
            int tempJ = rJ % _sizeofsides;
            rJ -= tempJ;
            fruite.Location = new Point(rI, rJ);

            for (int i = 0; i < numberofobstacles; i++)
            {
                if (fruite.Bounds.IntersectsWith(obstacle[i].Bounds))
                {
                    rI = r.Next(0, _width - _sizeofsides);
                    tempI = rI % _sizeofsides;
                    rI -= tempI;
                    rJ = r.Next(0, _width - _sizeofsides);
                    tempJ = rJ % _sizeofsides;
                    rJ -= tempJ;
                    fruite.Location = new Point(rI, rJ);
                }
            }

            this.Controls.Add(fruite);

        }

        private void _generateObstacles(int number)
        {
            for (int i = 0; i < number; i++)
            {
                obstacle[i] = new PictureBox();
                obstacle[i].Size = new Size(_sizeofsides, _sizeofsides * 4);
                Random r = new Random();
                rI = r.Next(0, _width - _sizeofsides);
                int tempI = rI % _sizeofsides;
                rI -= tempI;
                rJ = r.Next(0, _width - _sizeofsides);
                int tempJ = rJ % _sizeofsides;
                rJ -= tempJ;

                obstacle[i].Location = new Point(rI, rJ);
                obstacle[i].BackColor = Color.Brown;
                this.Controls.Add(obstacle[i]);


            }
        }
        private void _eatFrute()
        {
            if (snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                labelScore.Text = "Score: " + ++score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirX, snake[score - 1].Location.Y - 40 * dirY);
                snake[score].Size = new Size(_sizeofsides, _sizeofsides);
                snake[score].BackColor = Color.Blue;
                this.Controls.Add(snake[score]);
                _generateFruit();
            }
        }

        private void _generateMap()
        {
            for (int i = 0; i < _width / _sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeofsides * i);
                pic.Size = new Size(_width, 1);
                this.Controls.Add(pic);
            }
            for (int i = 0; i <= _heighth / _sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeofsides * i, 0);
                pic.Size = new Size(1, _width);
                this.Controls.Add(pic);
            }
        }
        private bool EatMySelf()
        {
            int count = 0;
            if (score > 1)

            {
                for (int i = score; i >= 1; i--)
                {
                    if (snake[0].Location == snake[i].Location)
                    {
                        count++;
                    }
                }
            }
            if (count > 0) { return true; }
            else { return false; }
        }// EatMySelf
        private bool CollisionWithObstacle(int numberofobstacles)
        {
            int count = 0;
            if (numberofobstacles > 0)
            {
                for (int i = 0; i < numberofobstacles; i++)
                {
                    if (snake[0].Bounds.IntersectsWith(obstacle[i].Bounds))
                    {
                        count++;
                    }
                }
            }
            if (count > 0) { return true; }
            else { return false; }
        }
        private bool CrossingBorder()
        {
            if (snake[0].Location.X < 0 || snake[0].Location.Y < 0 || snake[0].Location.X > 800 || snake[0].Location.Y >800)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        private void _moveSnake()
        {
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * _sizeofsides, snake[0].Location.Y + dirY * _sizeofsides);

        }
        private void _gameOver()
        {
            if (EatMySelf() || CollisionWithObstacle(numberofobstacles)||CrossingBorder())
            {
                Close();
            }
        }

        private void _update(object obj, EventArgs eventsArgs)
        {
            _eatFrute();
            _moveSnake();
            EatMySelf();
            CollisionWithObstacle(numberofobstacles);
            CrossingBorder();
            _gameOver();


            //cube.Location = new Point(cube.Location.X + dirX*_sizeofsides, cube.Location.Y+ dirY* _sizeofsides);
        }

        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                    dirY = -1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;
            }
        }
    }
}