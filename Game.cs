// Include code libraries you need below (use the namespace).
using System;
using System.ComponentModel;
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
        Color SkyBlue = new Color(10, 194, 255);
        Color BalloonColor;
        Color BalloonColor2;
        Color BalloonColor3;
        Color BalloonColor4;
        Color BalloonColor5;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Ethan's Balloon Bash");
            Window.SetSize(800, 600);
            Window.TargetFPS = 120;
            // will allow me to have the balloon change colour on each start up! (try starting it multiple times)
            BalloonColor = Random.Color();
            BalloonColor2 = Random.Color();
            BalloonColor3 = Random.Color();
            BalloonColor4 = Random.Color();
            BalloonColor5 = Random.Color();
            bool condition;

            while (condition)
            {
                // Loop runs if the condition is true.
                // Once the code reaches the end of the code block, it re-evaluates the condition.
                // If the condition is true, the code jumps up to the start of the block and is run again.
            }

            // Code after the block runs when the condition evaluates as false.
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            MouseX = Input.GetMouseX();
            MouseY = Input.GetMouseY();
            // Clear previous image
            Window.ClearBackground(SkyBlue);

            Input.HideMouseCursor();

            DrawBalloon(MouseX, MouseY);
            DrawBalloon2(MouseX + 50, MouseY + 50);
            DrawBalloon3(MouseX + 100, MouseY);
            DrawBalloon4(MouseX - 50, MouseY + 50);
            DrawBalloon5(MouseX + 150, MouseY + 50);
            DrawCloud(+ Time.SecondsElapsed, 50);

            //DrawCloud();

        }

        // draws a balloon (same code multiple small variations, ie. color, +/- x/y values)
        void DrawBalloon(float x, float y)
        {
            // changes the colour of all the lines underneath to black (until the next line colour change)
            Draw.LineColor = Color.Black;
            //draws the string (line) that is connected to the bottom of the balloon
            Draw.Line(x, y, x, y + 100);
            //draws a triangle that will follow the circle (put above bc i wanted it behind the circle)
            Draw.FillColor = BalloonColor;
            Draw.Triangle(x - 11, y + 30, x, y + 5, x + 11, y + 30);
            //draws a circle that moves where the mouse input is
            Draw.FillColor = BalloonColor;
            Draw.Circle(x, y, 25);

        }
        void DrawBalloon2(float x, float y)
        {
            //draws the string (line) that is connected to the bottom of the balloon
            Draw.Line(x, y, x, y + 100);
            //draws a triangle that will follow the circle (put above bc i wanted it behind the circle)
            Draw.FillColor = BalloonColor2;
            Draw.Triangle(x - 11, y + 30, x, y + 5, x + 11, y + 30);
            //draws a circle that moves where the mouse input is
            Draw.FillColor = BalloonColor2;
            Draw.Circle(x, y, 25);

        }
        void DrawBalloon3(float x, float y)
        {
            //draws the string (line) that is connected to the bottom of the balloon
            Draw.Line(x, y, x, y + 100);
            //draws a triangle that will follow the circle (put above bc i wanted it behind the circle)
            Draw.FillColor = BalloonColor3;
            Draw.Triangle(x - 11, y + 30, x, y + 5, x + 11, y + 30);
            //draws a circle that moves where the mouse input is
            Draw.FillColor = BalloonColor3;
            Draw.Circle(x, y, 25);

        }

        void DrawBalloon4(float x, float y)
        {
            //draws the string (line) that is connected to the bottom of the balloon
            Draw.Line(x, y, x, y + 100);
            //draws a triangle that will follow the circle (put above bc i wanted it behind the circle)
            Draw.FillColor = BalloonColor4;
            Draw.Triangle(x - 11, y + 30, x, y + 5, x + 11, y + 30);
            //draws a circle that moves where the mouse input is
            Draw.FillColor = BalloonColor4;
            Draw.Circle(x, y, 25);

        }

        void DrawBalloon5(float x, float y)
        {
            //draws the string (line) that is connected to the bottom of the balloon
            Draw.Line(x, y, x, y + 100);
            //draws a triangle that will follow the circle (put above bc i wanted it behind the circle)
            Draw.FillColor = BalloonColor5;
            Draw.Triangle(x - 11, y + 30, x, y + 5, x + 11, y + 30);
            //draws a circle that moves where the mouse input is
            Draw.FillColor = BalloonColor5;
            Draw.Circle(x, y, 25);

        }

        void DrawCloud(float x, float y)
        {
            Draw.LineColor = Color.White;
            Draw.FillColor = Color.White;
            Draw.Circle(x,y, 35);
            
            Draw.LineColor = Color.White;
            Draw.FillColor = Color.White;
            Draw.Circle(x+ 70,y, 25);

            Draw.LineColor = Color.White;
            Draw.FillColor = Color.White;   
            Draw.Circle(x,y, 25);  

        }
    }

}

