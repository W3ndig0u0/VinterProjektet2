using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
  public class Enemy : Enteties
  {

    public void EnemyStartUpdate(Rectangle otha)
    {
      bool move = Raylib.CheckCollisionRecs(this.entetiesInGame, otha);

      if (move == false)
      {
        this.xPosition -= 5;
      }
      else
      {
        this.xPosition += 0;
        // otha.hp -= 5;
      }
    }

  }
}