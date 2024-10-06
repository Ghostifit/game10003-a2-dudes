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
        // Place your variables here:


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
            Draw.FillColor = Color.Blue;
            Draw.LineColor = Color.DarkGray;
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
            //EYES
            for (int i = 0; i < 8; i++)
            {
                float x = xcoords[i];
                float y = ycoords[i];
                Draw.FillColor = Color.White;
                Draw.LineColor = Color.DarkGray;
                Draw.LineSize = 2;
                Draw.Circle(x, y, 20);
                //Lil Dude 1 Eyes //THISXYCOORD[0] IS APPARENTLY THE LEFT PUPIL?????
                xcoords[0] = 155;
                ycoords[0] = 215;
                xcoords[1] = 180;
                ycoords[1] = 180;
                //Lil Dude 2 Eyes 
                xcoords[2] = 680;
                ycoords[2] = 180;
                xcoords[3] = 720;
                ycoords[3] = 180;
                //Lil Dude 3 Eyes
                xcoords[4] = 80;
                ycoords[4] = 430;
                xcoords[5] = 120;
                ycoords[5] = 430;
                //Lil Dude 4 Eyes 
                xcoords[6] = 530;
                ycoords[6] = 380;
                xcoords[7] = 550;
                ycoords[7] = 380;
            }

            //PUPILS
            for (int i = 0; i < 8; i++)
            {
                float x = xcoords[i];
                float y = ycoords[i];
                Draw.FillColor = Color.Black;
                Draw.LineColor = Color.DarkGray;
                Draw.LineSize = 2;
                Draw.Circle(x, y, 5);
                //Lil Dude 1 pupils //IDK WHAT THIS XYCOORD[0] IS FOR THEN????
                xcoords[0] = 140;
                ycoords[0] = 180;
                xcoords[1] = 190;
                ycoords[1] = 190;
                //Lil Dude 2 Pupils
                xcoords[2] = 690;
                ycoords[2] = 180;
                xcoords[3] = 730;
                ycoords[3] = 180;
                //Lil Dude 3 Pupils
                xcoords[4] = 90;
                ycoords[4] = 430;
                xcoords[5] = 130;
                ycoords[5] = 430;
                //Lil Dude 4 Pupils
                xcoords[6] = 520;
                ycoords[6] = 380;
                xcoords[7] = 560;
                ycoords[7] = 380;
            }
        }
    }
}
