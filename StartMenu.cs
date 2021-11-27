using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;

namespace VinterProjektet2
{
  public class StartMenu
  {
    public void Menu()
    {

      Pieces pieces = new Pieces();
      GamePlay game = new GamePlay();

      Rectangle StartBlock = new Rectangle(0, 0, 1400, 60);
      Rectangle EndBlock = new Rectangle(0, 660, 1400, 60);


      Button startButton = new Button();
      Button settingButton = new Button();
      Button aboutButton = new Button();

      SocialMediaButton faceButton = new SocialMediaButton();
      SocialMediaButton twiButton = new SocialMediaButton();
      SocialMediaButton gitButton = new SocialMediaButton();

      Rectangle exitButton = new Rectangle(0, 70, 90, 50);
      Rectangle profile = new Rectangle(1220, 5, 170, 50);

      Rectangle newScreen = new Rectangle(3000, 0, 1400, 700);

      // !Icons
      Image githubImg = Raylib.LoadImage(@"Github.png");
      Raylib.ImageResize(ref githubImg, 30, 30);
      Texture2D githubTexture = Raylib.LoadTextureFromImage(githubImg);

      Image facebookImg = Raylib.LoadImage(@"Facebook.png");
      Raylib.ImageResize(ref facebookImg, 30, 30);
      Texture2D facebookTexture = Raylib.LoadTextureFromImage(facebookImg);

      Image twitterImg = Raylib.LoadImage(@"Twitter.png");
      Raylib.ImageResize(ref twitterImg, 40, 40);
      Texture2D twitterTexture = Raylib.LoadTextureFromImage(twitterImg);

      Image wallpapperMenu = Raylib.LoadImage(@"bg1.png");
      Raylib.ImageResize(ref wallpapperMenu, 1400, 700);
      Texture2D wallpapperMenuTextrure = Raylib.LoadTextureFromImage(wallpapperMenu);

      // !Sound
      Sound clickSound = Raylib.LoadSound("Hover.wav");
      Music bgm = Raylib.LoadMusicStream("MenuBgm1.mp3");
      Font f1 = Raylib.LoadFont(@"Roboto-Bold.ttf");

      List<Button> buttons = new List<Button>();

      startButton.clickSound = Raylib.LoadSound("Hover.wav");
      settingButton.clickSound = Raylib.LoadSound("Hover.wav");
      aboutButton.clickSound = Raylib.LoadSound("Hover.wav");

      faceButton.click = Raylib.LoadSound("Hover.wav");
      twiButton.click = Raylib.LoadSound("Hover.wav");
      gitButton.click = Raylib.LoadSound("Hover.wav");

      startButton.yPosition = 200;
      settingButton.yPosition = 300;
      aboutButton.yPosition = 400;

      startButton.ButtonColor = pieces.S_GREEN;
      settingButton.ButtonColor = pieces.L_ORANGE;
      aboutButton.ButtonColor = pieces.T_PURPLE;

      faceButton.xPos = 1190;
      twiButton.xPos = 1260;
      gitButton.xPos = 1330;


      while (!Raylib.WindowShouldClose())
      {
        buttons.Add(startButton);
        buttons.Add(settingButton);
        buttons.Add(aboutButton);

        buttons.Add(faceButton);
        buttons.Add(twiButton);
        buttons.Add(gitButton);

        buttons.Add(new SocialMediaButton());

        Vector2 mousePos = Raylib.GetMousePosition();

        for (int i = 0; i < buttons.Count; i++)
        {
          buttons[i].Update();
          buttons[i].areOverlapping = Raylib.CheckCollisionPointRec(mousePos, buttons[i].button);
        }

        Raylib.PlayMusicStream(bgm);
        Raylib.UpdateMusicStream(bgm);
        Raylib.SetMusicVolume(bgm, 0.5f);

        bool areOverlappingExit = Raylib.CheckCollisionPointRec(mousePos, exitButton);
        bool areOverlappingProfile = Raylib.CheckCollisionPointRec(mousePos, profile);

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);

        Raylib.DrawRectangleRec(StartBlock, pieces.I_CYAN);
        Raylib.DrawRectangleRec(EndBlock, pieces.L_ORANGE);

        Raylib.DrawRectangleRec(startButton.button, startButton.ButtonColor);
        Raylib.DrawRectangleRec(settingButton.button, settingButton.ButtonColor);
        Raylib.DrawRectangleRec(aboutButton.button, aboutButton.ButtonColor);

        Raylib.DrawRectangleRec(exitButton, pieces.Z_RED);
        Raylib.DrawRectangleRec(profile, Color.BLACK);

        Raylib.DrawRectangleRec(faceButton.button, Color.WHITE);
        Raylib.DrawRectangleRec(twiButton.button, Color.WHITE);
        Raylib.DrawRectangleRec(gitButton.button, Color.WHITE);


        Raylib.DrawText("Home", 10, 10, 40, Color.WHITE);
        Raylib.DrawText("Jing Xu - Te 19B", 1000, 670, 20, Color.WHITE);
        Raylib.DrawText("Welcome To Tetris!", 20, 670, 20, Color.WHITE);
        Raylib.DrawText("Exit!", 10, 80, 30, Color.WHITE);

        Raylib.DrawText("Play!", 600, 210, 40, Color.WHITE);
        Raylib.DrawText("Tetris Time!", 600, 250, 20, Color.WHITE);

        Raylib.DrawText("Settings", 600, 310, 40, Color.WHITE);
        Raylib.DrawText("Settings...", 600, 350, 20, Color.WHITE);

        Raylib.DrawText("About", 600, 410, 40, Color.WHITE);
        Raylib.DrawText("What the heck is this?", 600, 450, 20, Color.WHITE);


        Raylib.DrawTexture(facebookTexture, 1200, 660, Color.WHITE);
        Raylib.DrawTexture(twitterTexture, 1265, 655, Color.WHITE);
        Raylib.DrawTexture(githubTexture, 1340, 660, Color.WHITE);

        Raylib.DrawRectangleRec(newScreen, Color.WHITE);


        // !Exit Interaktion
        if (areOverlappingExit)
        {
          if (exitButton.width < 130)
          {
            exitButton.width += 6;
          }


          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);
          }
        }

        else
        {
          if (exitButton.width > 90)
          {
            exitButton.width -= 6;
          }
        }

        // !Profil
        if (areOverlappingProfile)
        {
          if (profile.y < 10)
          {
            profile.y += 6;
          }
          profile.height = 55;

          if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
          {
            Raylib.PlaySound(clickSound);

            // game.Game();
          }
        }

        else
        {
          if (profile.y > 5 && profile.height > 50)
          {
            profile.y -= 6;
            profile.height -= 6;
          }
        }
        Raylib.EndDrawing();
      }
    }
  }
}