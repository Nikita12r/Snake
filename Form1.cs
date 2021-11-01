
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.Logging;

namespace Snake
{
    public partial class Form1 : Form
    {
    Label Apple = new Label();
    // Label snakeBody = new Label();
    Label defaultBody = new Label();
    int Xmax, Ymax;
    private List<Label> snakeBody = new List<Label>();

   
    
    //private Point Apple = new Point();
        public Form1()
        {
      try
      {
        InitializeComponent();
        //pictureBox1.MouseEnter += new EventHandler(pictureBox1_MouseEnter);
        //pictureBox1.MouseLeave += new EventHandler(pictureBox1_MouseLeave);
        //pictureBox1.KeyDown += new KeyEventHandler(pictureBox1_KeyDown);

        new Config();
        Xmax = SnakeBoard.Size.Width / Config.Width;
        Ymax = SnakeBoard.Size.Height / Config.Height;

        Apple.Text = "^$$^";
        Apple.Location = new Point(10, 10);

        StartGame();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in form load Function " + ex.ToString());

      }

    }

    /// <summary>
    /// Function to build default body length of Snake
    /// </summary>
    private void BuildDefaultSnake()
    {
      try {
        //for (var i = 0; i < 5; i++)
        {
          Label s2 = new Label();

          if (snakeBody.Count == 0)
          {
            s2.Location = new Point(10, 5);

          }
          //else
          //{
          //  s2.Location = new Point(snakeBody[snakeBody.Count - 1].Location.X - 1, snakeBody[snakeBody.Count - 1].Location.Y);
          //}
          snakeBody.Add(s2);
        }


      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in BuildDefaultSnake Function " + ex.ToString());

      }


    }

  /// <summary>
  /// To progress movement of snake with keypress events and detect collision with apple/snake/border
  /// </summary>
    private void SnakeMove()
    {

      try
      {
        Point pt = new Point();
        for (var i = snakeBody.Count - 1; i >= 0; i--)
        {
          if (i == 0)
          {
            switch (Config.direction)
            {

              case Config.Direction.Down:
                pt.Y = snakeBody[i].Location.Y + 1;
                snakeBody[i].Location = new Point(snakeBody[i].Location.X, pt.Y);
                break;
              case Config.Direction.Up:
                pt.Y = snakeBody[i].Location.Y - 1;
                snakeBody[i].Location = new Point(snakeBody[i].Location.X, pt.Y);
                break;
              case Config.Direction.Left:
                pt.X = snakeBody[i].Location.X - 1;
                snakeBody[i].Location = new Point(pt.X, snakeBody[i].Location.Y);
                break;
              case Config.Direction.Right:
                pt.X = snakeBody[i].Location.X + 1;
                snakeBody[i].Location = new Point(pt.X, snakeBody[i].Location.Y);
                break;

            }
            bool crash = DetectCrash(snakeBody[i], snakeBody);

            if (snakeBody[i].Location.X == Apple.Location.X && snakeBody[i].Location.Y == Apple.Location.Y)
            {
              AddApple();
            }
            else if (crash)
            {
              GameOver();
            }



          }
          else
          {
            pt.X = snakeBody[i - 1].Location.X;
            pt.Y = snakeBody[i - 1].Location.Y;

            snakeBody[i].Location = pt;

          }

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in SnakeMove Function " + ex.ToString());

      }
    }

    /// <summary>
    /// Adding growth to snake on colliding with apple 
    /// </summary>
    private void AddApple()
    {
      try
      {

        Config.Score += Config.Points;
        lbl_Score.Text = Config.Score.ToString();

        for (var i = 0; i < Config.Growth; i++)
        {
          Label s1 = new Label();
          //Label s2 = new Label();

          s1.Location = new Point(snakeBody[snakeBody.Count - 1].Location.X - 1, snakeBody[snakeBody.Count - 1].Location.Y - 1);
          snakeBody.Add(s1);
        }
        // s2.Location = new Point(snakeBody[snakeBody.Count - 1].Location.X - 1, snakeBody[snakeBody.Count - 1].Location.Y - 1);
        // snakeBody.Add(s2);


        placeApple();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in AddApple Function " + ex.ToString());

      }
    }

    /// <summary>
    /// Identify if snake touches the border of the board or its own body
    /// </summary>
    /// <param name="SnakeFace">First element of snake array</param>
    /// <param name="Body">Full array of snake(label)</param>
    /// <returns></returns>
    private bool DetectCrash(Label SnakeFace,List<Label> Body)
    {
      try
      {

        if (SnakeFace.Location.X < 0 || SnakeFace.Location.Y < 0 || SnakeFace.Location.X >= Xmax || SnakeFace.Location.Y >= Ymax)
        {
          return true;

        }

        for (var i = 1; i < snakeBody.Count; i++)
        {
          if (SnakeFace.Location.X == Body[i].Location.X && SnakeFace.Location.Y == Body[i].Location.Y)
          {
            return true;
          }
        }
        return false;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in DetectCrash Function " + ex.ToString());
        return false;

      }
    }

    /// <summary>
    /// Activating flag to indicate gameover 
    /// </summary>
    private void GameOver()
    {

      Config.GameOver = true;

    }

    /// <summary>
    /// Initializing board and location of snake & apple
    /// </summary>
    private void StartGame()
    {
      try
      {
        new Config();

        snakeBody.Clear();

        BuildDefaultSnake();

        lbl_Score.Text = Config.Score.ToString();
        placeApple();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in StartGame Function " + ex.ToString());

      }


    }

    /// <summary>
    /// Placing Apple at random locations on board
    /// </summary>
    private void placeApple()
    {
      try
      {
        Random rdm = new Random();
        Apple.Location = new Point(rdm.Next(0, Xmax), rdm.Next(0, Ymax));
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in Place Apple Function " + ex.ToString());

      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
      
      
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// Transforms location of Snake and Apple to board coordinates on any movement(event) on the board
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SnakeBoard_Paint(object sender, PaintEventArgs e)
    {
      try
      {
        Graphics board = e.Graphics;
        int ptX, ptY, AppleX, AppleY;
        if (!Config.GameOver)
        {

          for (var i = 0; i < snakeBody.Count; i++)
          {

            //snakeBody[i].Text = "*";
            ptX = snakeBody[i].Location.X * Config.Width;
            ptY = snakeBody[i].Location.Y * Config.Height;
            board.FillEllipse(Brushes.Green, new Rectangle(ptX, ptY, Config.Width, Config.Height));
          }

          AppleX = Apple.Location.X * Config.Width;
          AppleY = Apple.Location.Y * Config.Height;
          board.FillEllipse(Brushes.Red, new Rectangle(AppleX, AppleY, Config.Width, Config.Height));

        }
        else
        {
          MessageBox.Show("Game over. Your Final Score is  " + Config.Score);
          btn_PlayAgain.Visible = true;

        }

      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in SnakeBoard Function " + ex.ToString());

      }
    }

    private void pictureBox1_PreviewKeyDown(object sender, KeyPressEventArgs e)
    {
      }
    
    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar==(char)Keys.Up)
        MessageBox.Show("Up key1");

      if (e.KeyChar == (char)Keys.Down)
        MessageBox.Show("Down key1");
    }

    private void SnakeBoard_Click(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// Event to restart the game.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btn_PlayAgain_Click(object sender, EventArgs e)
    {
      try
      {
        lbl_msg.Visible = true;
        btn_PlayAgain.Visible = false;

        StartGame();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error in Play Again Function " + ex.ToString());

      }
    }

    /// <summary>
    /// Function to identify arrow key press events and move snake accordingly
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="keyData"></param>
    /// <returns></returns>
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      try
      {
        lbl_msg.Visible = false;
        var flag = true;
        if (keyData == Keys.Enter)
        {
          StartGame();

          flag = true;

        }
        if (keyData == Keys.Up && Config.direction != Config.Direction.Down)
        {

          Config.direction = Config.Direction.Up;
          flag = true;
        }
        if (keyData == Keys.Down && Config.direction != Config.Direction.Up)
        {
          Config.direction = Config.Direction.Down;
          flag = true;
        }
        if (keyData == Keys.Left && Config.direction != Config.Direction.Right)
        {
          Config.direction = Config.Direction.Left;
          flag = true;

        }
        if (keyData == Keys.Right && Config.direction != Config.Direction.Left)
        {
          Config.direction = Config.Direction.Right;
          flag = true;

        }

        SnakeMove();
        SnakeBoard.Invalidate();
        if (flag)
          return flag;

        else
          return base.ProcessCmdKey(ref msg, keyData);

      }
      catch(Exception ex)
      {
        Console.WriteLine("Error in ProcessCmdKey "+ ex.ToString());
        return base.ProcessCmdKey(ref msg, keyData);

      }
    }
  }
}
