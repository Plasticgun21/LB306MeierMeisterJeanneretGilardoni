using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PAC_Man_Game_WPF_MOO_ICT
{
    public partial class MainWindow : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer(); // Timer to control the game loop

        // Movement control flags
        bool goLeft, goRight, goDown, goUp;
        bool noLeft, noRight, noDown, noUp;

        int speed = 8; // Pac-Man speed

        Rect pacmanHitBox; 

        int ghostSpeed = 10; 
        int ghostMoveStep = 160; 
        int currentGhostStep;
        int score = 0;

        Random random = new Random(); 

        public MainWindow()
        {
            InitializeComponent();
            GameSetUp(); // Set up the game
        }

        private void CanvasKeyDown(object sender, KeyEventArgs e) // Handle user inputs
        {
            // Move left
            if (e.Key == Key.Left && !noLeft)
            {
                goRight = goUp = goDown = false;
                noRight = noUp = noDown = false;
                goLeft = true;
                pacman.RenderTransform = new RotateTransform(-180, pacman.Width / 2, pacman.Height / 2);
            }

            // Move right
            if (e.Key == Key.Right && !noRight)
            {
                noLeft = noUp = noDown = false;
                goLeft = goUp = goDown = false;
                goRight = true;
                pacman.RenderTransform = new RotateTransform(0, pacman.Width / 2, pacman.Height / 2);
            }

            // Move up
            if (e.Key == Key.Up && !noUp)
            {
                noRight = noDown = noLeft = false;
                goRight = goDown = goLeft = false;
                goUp = true;
                pacman.RenderTransform = new RotateTransform(-90, pacman.Width / 2, pacman.Height / 2);
            }

            // Move down
            if (e.Key == Key.Down && !noDown)
            {
                noUp = noLeft = noRight = false;
                goUp = goLeft = goRight = false;
                goDown = true;
                pacman.RenderTransform = new RotateTransform(90, pacman.Width / 2, pacman.Height / 2);
            }
        }

        private void GameSetUp() // Set up game initial state
        {
            MyCanvas.Focus(); 
            gameTimer.Tick += GameLoop; 
            gameTimer.Interval = TimeSpan.FromMilliseconds(20); 
            gameTimer.Start(); 
            currentGhostStep = ghostMoveStep; 

            // Load Pac-Man texture
            ImageBrush pacmanImage = new ImageBrush();
            pacmanImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/pacman.jpg"));
            pacman.Fill = pacmanImage;

            // Load red ghost texture
            ImageBrush redGhost = new ImageBrush();
            redGhost.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/red.jpg"));
            redGuy.Fill = redGhost;

            // Load orange ghost texture
            ImageBrush orangeGhost = new ImageBrush();
            orangeGhost.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/orange.jpg"));
            orangeGuy.Fill = orangeGhost;

            // Load pink ghost texture
            ImageBrush pinkGhost = new ImageBrush();
            pinkGhost.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/pink.jpg"));
            pinkGuy.Fill = pinkGhost;
        }

        private void GameLoop(object sender, EventArgs e) // Main game loop
        {
            txtScore.Content = "Score: " + score; 

            // Move Pac-Man based on the current direction
            if (goRight) Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) + speed);
            if (goLeft) Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) - speed);
            if (goUp) Canvas.SetTop(pacman, Canvas.GetTop(pacman) - speed);
            if (goDown) Canvas.SetTop(pacman, Canvas.GetTop(pacman) + speed);

            // Stop Pac-Man from moving out of the game area
            if (goDown && Canvas.GetTop(pacman) + 80 > Application.Current.MainWindow.Height)
            {
                noDown = true;
                goDown = false;
            }
            if (goUp && Canvas.GetTop(pacman) < 1)
            {
                noUp = true;
                goUp = false;
            }
            if (goLeft && Canvas.GetLeft(pacman) - 10 < 1)
            {
                noLeft = true;
                goLeft = false;
            }
            if (goRight && Canvas.GetLeft(pacman) + 70 > Application.Current.MainWindow.Width)
            {
                noRight = true;
                goRight = false;
            }

            pacmanHitBox = new Rect(Canvas.GetLeft(pacman), Canvas.GetTop(pacman), pacman.Width, pacman.Height); // Update Pac-Man's hitbox

            foreach (var x in MyCanvas.Children.OfType<Rectangle>())
            {
                Rect hitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height); // Get hitbox of each rectangle (wall, coin, ghost)

                if ((string)x.Tag == "wall") // Handle collision with walls
                {
                    if (goLeft && pacmanHitBox.IntersectsWith(hitBox))
                    {
                        Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) + 10);
                        noLeft = true;
                        goLeft = false;
                    }
                    if (goRight && pacmanHitBox.IntersectsWith(hitBox))
                    {
                        Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) - 10);
                        noRight = true;
                        goRight = false;
                    }
                    if (goDown && pacmanHitBox.IntersectsWith(hitBox))
                    {
                        Canvas.SetTop(pacman, Canvas.GetTop(pacman) - 10);
                        noDown = true;
                        goDown = false;
                    }
                    if (goUp && pacmanHitBox.IntersectsWith(hitBox))
                    {
                        Canvas.SetTop(pacman, Canvas.GetTop(pacman) + 10);
                        noUp = true;
                        goUp = false;
                    }
                }

                if ((string)x.Tag == "coin") // Handle collision with coins
                {
                    if (pacmanHitBox.IntersectsWith(hitBox) && x.Visibility == Visibility.Visible)
                    {
                        x.Visibility = Visibility.Hidden; 
                        score++; 
                    }
                }

                if ((string)x.Tag == "ghost") // Handle collision with ghosts
                {
                    if (pacmanHitBox.IntersectsWith(hitBox))
                    {
                        GameOver("Ghosts got you, click ok to play again"); 
                    }

                    // Ghost movement pattern
                    if (x.Name.ToString() == "redGuy")
                    {
                        Canvas.SetLeft(x, Canvas.GetLeft(x) + ghostSpeed);
                        if (Canvas.GetLeft(x) > 700)
                        {
                            Canvas.SetLeft(x, 50);
                        }
                    }
                    else if (x.Name.ToString() == "orangeGuy")
                    {
                        Canvas.SetLeft(x, Canvas.GetLeft(x) + ghostSpeed);
                        if (Canvas.GetLeft(x) > 700)
                        {
                            Canvas.SetLeft(x, 50);
                        }
                    }
                    else if (x.Name.ToString() == "pinkGuy")
                    {
                        Canvas.SetLeft(x, Canvas.GetLeft(x) - ghostSpeed);
                        if (Canvas.GetLeft(x) < 50)
                        {
                            Canvas.SetLeft(x, 700);
                        }
                    }

                    currentGhostStep--;

                    if (currentGhostStep < 1) // Change ghost direction after certain steps
                    {
                        currentGhostStep = ghostMoveStep;
                        ghostSpeed = -ghostSpeed;
                    }
                }
            }

            if (score == 124) // Check if player has collected all coins
            {
                GameOver("You Win! you collected all of the coins");
            }
        }

        private void GameOver(string message) // Handle game over
        {
            gameTimer.Stop(); // Stop the game loop
            MessageBox.Show(message, "Pac Man Game "); 
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location); 
            Application.Current.Shutdown(); 
        }
    }
}
