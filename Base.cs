using System;
using Raylib_cs;

namespace VinterProjektet2
{
  public class Base : Enteties
  {

    public void BaseStartUpdate(Rectangle otha)
    {
      GameOver over = new GameOver();
      bool move = Raylib.CheckCollisionRecs(this.entetiesInGame, otha);

      if (move)
      {
        this.xPosition -= 0;
        timeAttack++;

        if (timeAttack >= 40)
        {
          this.hp -= 15;
          timeAttack = 0;
        }
      }

      if (this.hp <= 0)
      {
        over.Gameover();
      }
    }

  }
}