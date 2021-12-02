using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
 public class Enemy : Enteties
 {

  public override void Update()
  {
   Rectangle enemyGuy = new Rectangle(xPosition, yPosition, width, height);

   if (areOverlapping)
   {
    enemyGuy.x -= speed;
   }
  }

 }
}