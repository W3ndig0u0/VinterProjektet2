using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
  public class Player : Enteties
  {

    public void PlayerStartUpdate(Rectangle otha)
    {
      bool move = Raylib.CheckCollisionRecs(this.entetiesInGame, otha);

      if (move == false)
      {
        this.xPosition += speed - 1;
      }
      else
      {
        this.xPosition += 0;
        timeAttack++;
        if (timeAttack >= 20)
        {
          this.hp -= 25;
          timeAttack = 0;
        }
      }
    }

  }
}