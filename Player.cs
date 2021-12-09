using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
  public class Player : Enteties
  {

    public void PlayerStartUpdate(Rectangle otha, Rectangle othaBase)
    {
      bool move = Raylib.CheckCollisionRecs(this.entetiesInGame, otha);
      bool moveBase = Raylib.CheckCollisionRecs(this.entetiesInGame, othaBase);

      if (move == false || moveBase == false)
      {
        this.xPosition += speed;
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