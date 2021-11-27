using System;
using Raylib_cs;

namespace VinterProjektet2
{
  class Program
  {
    static void Main(string[] args)
    {
      int height = 700;
      int width = 1400;
      Image logo = Raylib.LoadImage(@"Logo.png");

      Raylib.InitWindow(width, height, "Tetris - Jing Xu");
      Raylib.SetTargetFPS(120);
      Raylib.InitAudioDevice();
      Raylib.SetWindowIcon(logo);
      StartMenu Start = new StartMenu();
      int intro = 0;

      bool menuBool = false;
      Sound startSound = Raylib.LoadSound("Start.wav");

      // Image wallpapperTetris = Raylib.LoadImage(@"Background2.png");
      // Raylib.ImageResize(ref wallpapperTetris, 1400, 700);
      // Texture2D wallpapperTetrisTexture = Raylib.LoadTextureFromImage(wallpapperTetris);

      while (!menuBool)
      {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        intro += 5;

        // !FAde in eller nåt
        if (intro < 100)
        {
          Raylib.DrawRectangle(0, 0, 1400, 700, Color.BLUE);
        }

        else if (intro < 500)
        {
          Raylib.DrawRectangle(0, 0, 1400, 700, Color.BLUE);
          Raylib.PlaySound(startSound);
        }

        else if (intro < 1500)
        {
          Start.Menu();
          menuBool = true;
        }

        Raylib.EndDrawing();
      }

    }
  }
}
