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

   p.xPosition = 200;
   p.yPosition = 450;

   e.entetiesInGame.x = 1200;
   e.entetiesInGame.y = 450;

   while (!Raylib.WindowShouldClose())
   {
    bool move = Raylib.CheckCollisionRecs(p.entetiesInGame, e.entetiesInGame);

    if (move == false)
    {
     p.xPosition += 5;
    }
    else
    {
     p.xPosition += 0;
     e.hp -= 5;
    }


    if (e.hp <= 0)
    {
     e.yPosition -= 5;
    }

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);

    Raylib.DrawRectangleRec(p.entetiesInGame, Color.BLUE);
    Raylib.DrawRectangleRec(e.entetiesInGame, Color.BLUE);

    Raylib.DrawRectangleRec(p.entetiesInGame, Color.BLUE);
    Raylib.DrawRectangleRec(e.entetiesInGame, Color.BLUE);

    Raylib.EndDrawing();

   }
  }
 }
}