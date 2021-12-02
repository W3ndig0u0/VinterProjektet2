using System;
using Raylib_cs;
using System.Numerics;

namespace VinterProjektet2
{
  public class Player : Enteties
  {

    public override void StartUpdate()
    {

      if (areOverlapping)
      {
        entetiesInGame.x += speed;
      }
    }
  }
}