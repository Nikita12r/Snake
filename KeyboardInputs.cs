using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
  class KeyboardInputs
  {


    private Dictionary<Keys, bool> keyTable = new Dictionary<Keys, bool>();
    private bool keyPressed = false;
    public Dictionary<Keys, bool> KeyTable
    {
      get
      {
        return keyTable;
      }
      private set { keyTable = value; }
    }

    public bool KeyPressed()
    {
      return keyPressed;
    }

    public bool KeyPressed(Keys key)
    {
      bool keyValue = false;

      if(KeyTable.TryGetValue(key,out keyValue))
      {
        return keyValue;
      }

      return false;

    }

    public  void newKeyPressed(Keys key,bool state)
    {
      KeyTable.TryGetValue(key, out state);

    }


  }
}
