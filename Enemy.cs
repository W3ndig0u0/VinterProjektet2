using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
  public class Enemy : Enteties
  {

    public void EnemyStartUpdate(Rectangle otha, Rectangle othaBase)
    {
      bool move = Raylib.CheckCollisionRecs(this.entetiesInGame, otha);
      bool moveBase = Raylib.CheckCollisionRecs(this.entetiesInGame, othaBase);

      if (move == false && moveBase == false)
      {
        this.xPosition -= speed;
      }
      else
      {
        this.xPosition -= 0;
        timeAttack++;

        if (timeAttack >= 40 && move == true)
        {
          this.hp -= 15;
          timeAttack = 0;
        }
      }
    }


  }
}