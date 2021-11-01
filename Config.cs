using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Config
  {

    public enum Direction
    {
      Left,
      Right,
      Up,
      Down
    };

    public static int Width { get; set; }
    public static int Height { get; set; }
  
    public static int Score { get; set; }
    public static int Points { get; set; }
    public static bool GameOver { get; set; }

    public static int Growth { get; set; }


    public static int length { get; set; }
    public static Direction direction  { get; set; }


    public Config()
    {
      Width = 10;
      Height = 10;
      Points = 10;
      Score = 0;
      GameOver = false;
      length = 5;
      Growth = 2;
      direction = Direction.Left;

    }


}
}
