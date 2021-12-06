using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
  public class Enteties
  {

    public int speed = 5;
    public int xPosition;
    public int width = 50;
    public int height = 100;
    public int yPosition;

    public Color ButtonColor;

    public Vector2 mousePos;
    public Sound clickSound;
    public Rectangle entetiesInGame;
    public bool areOverlapping;

    public int hp = 100;

    int timer = 0;

    public void StartUpdate(Rectangle otha)
    {
      entetiesInGame = new Rectangle(xPosition, yPosition, width, height);

      // if (this.hp <= 0)
      // {

      if (timer == 0)
      {
        this.entetiesInGame.y -= speed;
      }
      // }
    }

  }
}