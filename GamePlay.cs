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

      Base eBase = new Base();
      Base pBase = new Base();
      Player p = new Player();
      Enemy e = new Enemy();

      p.xPosition = 200;
      p.yPosition = 450;

      e.xPosition = 1200;
      e.yPosition = 450;

      pBase.xPosition = 50;
      pBase.yPosition = 350;
      pBase.width = 100;
      pBase.height = 200;

      eBase.xPosition = 1250;
      eBase.yPosition = 350;
      eBase.width = 100;
      eBase.height = 200;

      while (!Raylib.WindowShouldClose())
      {
        p.StartUpdate();
        e.StartUpdate();
        eBase.StartUpdate();
        pBase.StartUpdate();

        p.PlayerStartUpdate(e.entetiesInGame, eBase.entetiesInGame);
        e.EnemyStartUpdate(p.entetiesInGame, pBase.entetiesInGame);

        eBase.BaseStartUpdate(p.entetiesInGame);
        pBase.BaseStartUpdate(e.entetiesInGame);

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);

        Raylib.DrawRectangleRec(p.entetiesInGame, Color.BLUE);
        Raylib.DrawRectangleRec(e.entetiesInGame, Color.BLUE);

        Raylib.DrawRectangleRec(pBase.entetiesInGame, Color.RED);
        Raylib.DrawRectangleRec(eBase.entetiesInGame, Color.RED);

        Raylib.DrawRectangleRec(e.entetiesHp, Color.GREEN);
        Raylib.DrawRectangleRec(p.entetiesHp, Color.GREEN);

        Raylib.DrawRectangleRec(eBase.entetiesHp, Color.GREEN);
        Raylib.DrawRectangleRec(pBase.entetiesHp, Color.GREEN);

        Raylib.DrawRectangleLinesEx(e.entetiesHp, 1, Color.BLACK);
        Raylib.DrawRectangleLinesEx(p.entetiesHp, 1, Color.BLACK);

        Raylib.EndDrawing();

      }
    }
  }
}