using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
  public class Enteties
  {

    public int speed = 2;
    public int xPosition;
    public int width = 50;
    public int height = 100;
    public int yPosition;

    public Color ButtonColor;

    public Vector2 mousePos;
    public Sound clickSound;
    public Rectangle entetiesInGame;
    public Rectangle entetiesHp;
    public bool areOverlapping;

    public int hp = 100;
    public int timeAttack = 0;


    public void StartUpdate(Rectangle otha)
    {
      entetiesInGame = new Rectangle(xPosition, yPosition, width, height);
      entetiesHp = new Rectangle(xPosition, yPosition - 40, hp / 2, 15);

      if (this.hp <= 0)
      {
        this.entetiesInGame.y -= speed * 100;
        this.entetiesHp.y -= speed * 100;
        entetiesHp.width = 0;
      }
    }

  }
}