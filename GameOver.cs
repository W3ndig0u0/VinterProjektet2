using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace VinterProjektet2
{
  public class GameOver
  {
    public void Gameover()
    {
      bool menuBool = false;
      Sound startSound = Raylib.LoadSound("Start.wav");

      Button startButton = new Button();
      Button settingButton = new Button();

      List<Button> buttons = new List<Button>();

      startButton.clickSound = Raylib.LoadSound("Hover.wav");
      settingButton.clickSound = Raylib.LoadSound("Hover.wav");

      startButton.yPosition = 200;
      settingButton.yPosition = 300;

      Image wallpapperMenu = Raylib.LoadImage(@"bg1.png");
      Raylib.ImageResize(ref wallpapperMenu, 1400, 700);
      Texture2D wallpapperMenuTextrure = Raylib.LoadTextureFromImage(wallpapperMenu);

      while (!menuBool)
      {

        buttons.Add(startButton);
        buttons.Add(settingButton);

        Vector2 mousePos = Raylib.GetMousePosition();


        for (int i = 0; i < buttons.Count; i++)
        {
          buttons[i].Update();
          buttons[i].areOverlapping = Raylib.CheckCollisionPointRec(mousePos, buttons[i].button);
        }

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);


        Raylib.DrawRectangleRec(startButton.button, startButton.ButtonColor);
        Raylib.DrawRectangleRec(settingButton.button, settingButton.ButtonColor);


        Raylib.DrawText("Again!", 600, 210, 40, Color.WHITE);
        Raylib.DrawText("Insert Text!", 600, 250, 20, Color.WHITE);

        Raylib.DrawText("Menu", 600, 310, 40, Color.WHITE);
        Raylib.DrawText("Menu...", 600, 350, 20, Color.WHITE);

        Raylib.DrawText("GAME OVER", 500, 100, 60, Color.WHITE);
        Raylib.EndDrawing();
      }
    }
  }
}