// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        float MouseX;
        float MouseY;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Ethan's Balloon Battle");
            Window.SetSize(800, 600);
            Window.TargetFPS = 300;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            MouseX = Input.GetMouseX();
            MouseY = Input.GetMouseY();
            // Clear previous image
            Window.ClearBackground(Color.White);
           
            Input.HideMouseCursor();
       
            DrawBalloon(MouseX, MouseY);


        }
        // draws a balloon
        void DrawBalloon(float x, float y)
        {
            //draws a triangle that will follow the circle (put above bc i wanted it behind the circle)
            Draw.FillColor = Color.Blue;
            Draw.Triangle(x-20,y+50,x,y+10,x+20,y+50);
            //draws a circle 
            Draw.FillColor = Color.Blue;
            Draw.Circle(x, y, 37);

        }
    }
}
