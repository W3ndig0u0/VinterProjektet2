using System;
using System.Numerics;
using Raylib_cs;

namespace VinterProjektet2
{
 public class Button
 {
  int xPosition = 500;
  int width = 3000;
  int height = 80;

  public Color ButtonColor;

  public int yPosition;
  public Vector2 mousePos;
  public Sound clickSound;
  public Rectangle button;
  public bool areOverlapping;

  virtual public void Update()
  {

   GamePlay game = new GamePlay();
   button = new Rectangle(xPosition, yPosition, width, height);

   if (areOverlapping)
   {
    button.x -= 12;
    ButtonColor.a = 255;

    if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
    {
     Raylib.PlaySound(clickSound);
     game.Game();
    }
   }

   else
   {
    button.x += 12;
    ButtonColor.a = 200;
   }

  }
 }
}