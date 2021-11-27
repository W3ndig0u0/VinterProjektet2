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

      int RECS_WIDTH = 25;
      int RECS_HEIGHT = 25;

      int MAX_RECS_X = 250 / RECS_WIDTH;
      int MAX_RECS_Y = 500 / RECS_HEIGHT;

      Rectangle[] rects = new Rectangle[MAX_RECS_X * MAX_RECS_Y];

      Rectangle playerRect = new Rectangle(700, 100, RECS_WIDTH, RECS_HEIGHT);

      int gridXStart = 600;
      int gridYStart = 100;

      int S_HoldTime = 0;
      int D_HoldTime = 0;
      int A_HoldTime = 0;

      for (int y = 0; y < MAX_RECS_Y; y++)
      {
        for (int x = 0; x < MAX_RECS_X; x++)
        {
          rects[y * MAX_RECS_X + x].x = gridXStart + RECS_WIDTH * x;
          rects[y * MAX_RECS_X + x].y = gridYStart + RECS_HEIGHT * y;
          rects[y * MAX_RECS_X + x].width = RECS_WIDTH;
          rects[y * MAX_RECS_X + x].height = RECS_HEIGHT;
        }
      }


      while (game)
      {
        // !Hold a bit = SPEEED
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && playerRect.y < 575)
        {
          S_HoldTime += 10;
          if (S_HoldTime > 300)
          {
            playerRect.y += Convert.ToSingle(RECS_WIDTH);
          }
          else
          {
            playerRect.y += Convert.ToSingle(0);
          }
        }

        else if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && playerRect.x < 825)
        {
          D_HoldTime += 10;
          if (D_HoldTime > 300)
          {
            playerRect.x += Convert.ToSingle(RECS_WIDTH);
          }
          else
          {
            playerRect.x += Convert.ToSingle(0);
          }
        }

        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && playerRect.x > gridXStart)
        {
          A_HoldTime += 10;
          if (A_HoldTime > 300)
          {
            playerRect.x -= Convert.ToSingle(RECS_WIDTH);
          }
          else
          {
            playerRect.x -= Convert.ToSingle(0);
          }
        }


        // !Tap = down once
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_S) && playerRect.y < 575)
        {
          playerRect.y += Convert.ToSingle(RECS_WIDTH);
        }

        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_A) && playerRect.x > gridXStart)
        {
          playerRect.x -= Convert.ToSingle(RECS_WIDTH);
        }

        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_D) && playerRect.y < 825)
        {
          playerRect.x += Convert.ToSingle(RECS_WIDTH);
        }

        // !Extra Knappar
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE) && playerRect.y < 575)
        {
          playerRect.y = 575;
        }


        bool pressK = false;
        bool pressJ = false;
        bool pressHold = false;

        if (Raylib.IsKeyDown(KeyboardKey.KEY_K))
        {
          pressK = true;
        }


        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) || Raylib.IsKeyDown(KeyboardKey.KEY_J))
        {
          pressJ = true;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT_SHIFT))
        {
          pressHold = true;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_Q))
        {
          playerRect.x = 700;
          playerRect.y = 100;
        }


        // Shift are to hold.

        if (Raylib.IsKeyUp(KeyboardKey.KEY_S))
        {
          S_HoldTime = 0;
        }

        if (Raylib.IsKeyUp(KeyboardKey.KEY_D))
        {
          D_HoldTime = 0;
        }

        if (Raylib.IsKeyUp(KeyboardKey.KEY_A))
        {
          A_HoldTime = 0;
        }

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);

        for (int i = 0; i < MAX_RECS_X * MAX_RECS_Y; i++)
        {
          Raylib.DrawRectangleRec(rects[i], Color.WHITE);
          Raylib.DrawRectangleLinesEx(rects[i], 1, Color.BLACK);
        }

        // !Pieces
        pieces.DrawI();
        pieces.DrawL();
        pieces.DrawZ();
        pieces.DrawS();
        pieces.DrawT();
        pieces.DrawJ();
        pieces.DrawO();

        Raylib.DrawText(playerRect.y.ToString(), 10, 40, 20, Color.ORANGE);
        Raylib.DrawText(playerRect.x.ToString(), 60, 40, 20, Color.ORANGE);

        if (pressK)
        {
          Raylib.DrawText("rotate 90° counterclockwise :3", 330, 625, 50, Color.BLACK);
        }

        else if (pressJ)
        {
          Raylib.DrawText("rotate 90° clockwise :3", 380, 625, 50, Color.BLACK);
        }

        else if (pressHold)
        {
          Raylib.DrawText("Holding?", 600, 625, 50, Color.BLACK);
        }
        Raylib.DrawRectangleRec(playerRect, Color.SKYBLUE);

        Raylib.EndDrawing();

      }
    }
  }
}