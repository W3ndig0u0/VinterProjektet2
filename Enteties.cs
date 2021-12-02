using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
 public class Enteties
 {

  public int speed = 10;
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

  virtual public void Update()
  {
   entetiesInGame = new Rectangle(xPosition, yPosition, width, height);

   if (hp <= 0)
   {
    this.entetiesInGame.y += speed;
   }
  }

 }
}