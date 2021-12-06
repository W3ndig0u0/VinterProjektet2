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
        this.xPosition += 5;
      }
      else
      {
        this.xPosition += 0;
        // this.hp -= 5;
      }
    }
  }
}