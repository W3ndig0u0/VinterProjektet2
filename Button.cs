using System;
using System.Numerics;
using Raylib_cs;

namespace VinterProjektet2
{
  public class Button
  {
    public int xPosition = 500;
    public int width = 3000;
    public int height = 80;

    public Color ButtonColor;

    public int yPosition;
    public Vector2 mousePos;
    public Sound clickSound;
    public Rectangle button;
    public bool areOverlapping;

    virtual public void Update()
    {
      StartMenu Start = new StartMenu();
      GamePlay game = new GamePlay();
      button = new Rectangle(xPosition, yPosition, width, height);

      if (areOverlapping)
      {
        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
        {
          Raylib.PlaySound(clickSound);
          if (this.yPosition == 200)
          {
            game.Game();
            button.x -= 12;
            ButtonColor.a = 255;
          }
          else if (this.yPosition == 75)
          {
            // (Ny gubbe)
            // Pengar försvinner
            button.x -= 120;
            ButtonColor.a = 255;
          }
          else
          {
            Start.Menu();
            button.x -= 12;
            ButtonColor.a = 255;
          }
        }
      }

      else
      {
        button.x += 6;
        ButtonColor.a = 200;
      }

    }
  }
}