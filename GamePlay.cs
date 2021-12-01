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


   Rectangle player = new Rectangle(200, 450, 50, 100);
   Rectangle enemy1 = new Rectangle(1200, 450, 50, 100);

   while (!Raylib.WindowShouldClose())
   {
    bool move = Raylib.CheckCollisionRecs(player, enemy1);

    if (move == false)
    {
     player.x += 10;
    }
    else
    {
     player.x += 0;
    }

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);

    Raylib.DrawRectangleRec(player, Color.BLUE);
    Raylib.DrawRectangleRec(enemy1, Color.BLUE);

    Raylib.EndDrawing();

   }
  }
 }
}