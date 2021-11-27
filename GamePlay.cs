using System;
using Raylib_cs;

namespace VinterProjektet2
{

  public class GamePlay
  {

    public void Game()
    {
      Pieces pieces = new Pieces();
      bool game = true;

      while (game)
      {

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);

        Raylib.EndDrawing();

      }
    }
  }
}