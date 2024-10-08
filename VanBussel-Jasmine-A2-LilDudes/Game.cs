// Include code libraries you need below (use the namespace).
using System;
using System.ComponentModel.Design;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {

        Color colorRandom = Random.Color();

        // Place your variables here:
        float[] eyeRadii = {
            5f,
            5f,
            5f,
            5f,
            5f,
            5f,
            5f,
            5f
        };
        Vector2[] eyePositions = {
            new(140, 180),
            new(190, 190),
            new(690, 180),
            new(730, 180),
            new(90, 430),
            new(130, 430),
            new(520, 380),
            new(560, 380)
        };

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Lil Dudes");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            //BODIES
            Draw.FillColor = colorRandom;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 2;
            float[] xcoords = new float[100];
            float[] ycoords = new float[100];
            //Lil Dude 1 Body
            xcoords[0] = 150;
            ycoords[0] = 200;
            //Lil Dude 2 Body
            xcoords[1] = 700;
            ycoords[1] = 200;
            //Lil Dude 3 Body
            xcoords[2] = 100;
            ycoords[2] = 450;
            //Lil Dude 4 Body
            xcoords[3] = 550;
            ycoords[3] = 400;

            for (int i = 0; i < 4; i++)
            {
                float x = xcoords[i];
                float y = ycoords[i];
                Draw.Circle(x, y, 45);
            }

            for (int i = 0; i < 8; i++)
            {
                DrawEye(eyePositions[i], eyeRadii[i]);
            }

            void DrawEye(Vector2 eyePosition, float eyeRadius)
            {
                eyePosition += new Vector2(0, 20f);
                eyeRadius += 15.0f;
                float pupilRadius = (20f / 40f) * eyeRadius;
                Vector2 mousePosition = Input.GetMousePosition();
                Vector2 offset = new(0, 0);
                Vector2 eyeToMouse = mousePosition - eyePosition;
                float eyeWhiteSpaceRadius = eyeRadius - 10;
                offset = Vector2.Normalize(eyeToMouse) * eyeWhiteSpaceRadius;
                if (Vector2.Distance(eyePosition, mousePosition) < eyeWhiteSpaceRadius)
                {
                    offset = -eyePosition + mousePosition;
                }
                for (int i = 0; i < 8; i++)
                {
                    Draw.FillColor = Color.White;
                    Draw.LineColor = Color.Black;
                    Draw.Circle(eyePosition, eyeRadius);
                    Draw.FillColor = Color.Black;

                    Draw.LineColor = Color.DarkGray;
                    Draw.LineSize = 2;
                    Draw.Circle(eyePosition + offset, pupilRadius);
                }
            }
        }
    }
}
