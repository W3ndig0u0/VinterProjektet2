using System;
using Raylib_cs;
using System.Numerics;
using System.Collections.Generic;


namespace VinterProjektet2
{

  public class GamePlay
  {

    public void Game()
    {
      Pieces pieces = new Pieces();

      // !Sound
      Sound clickSound = Raylib.LoadSound("Hover.wav");
      Music bgm = Raylib.LoadMusicStream("MenuBgm1.mp3");
      Font f1 = Raylib.LoadFont(@"Roboto-Bold.ttf");

      Image wallpapperMenu = Raylib.LoadImage(@"bg1.png");
      Raylib.ImageResize(ref wallpapperMenu, 1400, 700);
      Texture2D wallpapperMenuTextrure = Raylib.LoadTextureFromImage(wallpapperMenu);

      // Spawn Btn
      Button meeleBtn = new Button();
      Button rangeBtn = new Button();
      Button specialBtn = new Button();

      Base eBase = new Base();
      Base pBase = new Base();
      Player p = new Player();
      Enemy e = new Enemy();

      List<Button> buttons = new List<Button>();

      // Loading Sound
      meeleBtn.clickSound = Raylib.LoadSound("Hover.wav");
      rangeBtn.clickSound = Raylib.LoadSound("Hover.wav");
      specialBtn.clickSound = Raylib.LoadSound("Hover.wav");

      //! Spawn btn Placement
      meeleBtn.yPosition = 0;
      rangeBtn.yPosition = 75;
      specialBtn.yPosition = 150;

      meeleBtn.xPosition = 50;
      rangeBtn.xPosition = 50;
      specialBtn.xPosition = 50;

      // !btn size
      meeleBtn.width = 50;
      rangeBtn.width = 50;
      specialBtn.width = 50;

      meeleBtn.height = 50;
      rangeBtn.height = 50;
      specialBtn.height = 50;

      meeleBtn.ButtonColor = pieces.S_GREEN;
      rangeBtn.ButtonColor = pieces.L_ORANGE;
      specialBtn.ButtonColor = pieces.T_PURPLE;



      //! Spawn Placement
      p.xPosition = 200;
      p.yPosition = 450;

      e.xPosition = 1200;
      e.yPosition = 450;

      pBase.xPosition = 50;
      pBase.yPosition = 350;
      pBase.width = 100;
      pBase.height = 200;
      pBase.hp = 200;

      eBase.xPosition = 1250;
      eBase.yPosition = 350;
      eBase.width = 100;
      eBase.height = 200;
      eBase.hp = 200;

      while (!Raylib.WindowShouldClose())
      {
        p.StartUpdate();
        e.StartUpdate();
        eBase.StartUpdate();
        pBase.StartUpdate();

        buttons.Add(meeleBtn);
        buttons.Add(rangeBtn);
        buttons.Add(specialBtn);

        Vector2 mousePos = Raylib.GetMousePosition();

        // indexing the btns
        for (int i = 0; i < buttons.Count; i++)
        {
          buttons[i].Update();
          buttons[i].areOverlapping = Raylib.CheckCollisionPointRec(mousePos, buttons[i].button);
        }

        // Sound + bgm
        Raylib.PlayMusicStream(bgm);
        Raylib.UpdateMusicStream(bgm);
        Raylib.SetMusicVolume(bgm, 0.5f);

        p.PlayerStartUpdate(e.entetiesInGame, eBase.entetiesInGame);
        e.EnemyStartUpdate(p.entetiesInGame, pBase.entetiesInGame);

        eBase.BaseStartUpdate(p.entetiesInGame);
        pBase.BaseStartUpdate(e.entetiesInGame);

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawTexture(wallpapperMenuTextrure, 0, 0, Color.WHITE);

        Raylib.DrawRectangleRec(meeleBtn.button, meeleBtn.ButtonColor);
        Raylib.DrawRectangleRec(rangeBtn.button, rangeBtn.ButtonColor);
        Raylib.DrawRectangleRec(specialBtn.button, specialBtn.ButtonColor);


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
        Raylib.DrawRectangleLinesEx(eBase.entetiesHp, 1, Color.BLACK);
        Raylib.DrawRectangleLinesEx(pBase.entetiesHp, 1, Color.BLACK);

        Raylib.DrawRectangle(0, 0, 100, 35, Color.WHITE);
        Raylib.DrawFPS(10, 10);


        Raylib.EndDrawing();

      }
    }
  }
}