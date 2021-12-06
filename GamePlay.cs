using System;
using Raylib_cs;

namespace VinterProjektet2
{

  public class GamePlay
  {

    public void Game()
    {
      Pieces pieces = new Pieces();

      Image wallpapperMenu = Raylib.LoadImage(@"bg1.png");
      Raylib.ImageResize(ref wallpapperMenu, 1400, 700);
      Texture2D wallpapperMenuTextrure = Raylib.LoadTextureFromImage(wallpapperMenu);

      Player p = new Player();
      Enemy e = new Enemy();

      Enteties e2 = new Enteties();

      p.xPosition = 200;
      p.yPosition = 450;

      e.xPosition = 1200;
      e.yPosition = 450;

      while (!Raylib.WindowShouldClose())
      {
        p.StartUpdate(e.entetiesInGame);
        e.StartUpdate(p.entetiesInGame);

        p.PlayerStartUpdate(e.entetiesInGame);
        e.EnemyStartUpdate(p.entetiesInGame);

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);

        Raylib.DrawRectangleRec(p.entetiesInGame, Color.BLUE);
        Raylib.DrawRectangleRec(e.entetiesInGame, Color.BLUE);

        Raylib.EndDrawing();

      }
    }
  }
}