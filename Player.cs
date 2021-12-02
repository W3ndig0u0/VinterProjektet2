using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
 public class Player : Enteties
 {

  public override void Update()
  {

   if (areOverlapping)
   {
    entetiesInGame = new Rectangle(xPosition, yPosition, width, height);

    this.entetiesInGame.x += speed;
   }
  }
 }
}