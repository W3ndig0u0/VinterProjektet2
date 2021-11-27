using System;
using Raylib_cs;

namespace VinterProjektet2
{
  public class SocialMediaButton : Button
  {
    public Sound click;
    public int xPos;

    public override void Update()
    {

      button = new Rectangle(xPos, 650, 50, 50);

      if (areOverlapping)
      {

        if (button.y > 625)
        {
          button.y -= 4;
        }
        button.height = 100;

        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
        {
          Raylib.PlaySound(click);
        }
      }

      else
      {
        button.height = 100;

        if (button.y < 650)
        {
          button.y += 4;
        }
      }
    }

  }
}