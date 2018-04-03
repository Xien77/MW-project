using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlacitka
{
    public class Button
    {
        
        public new Vector2 Position;
        public Texture2D Texture;
        public int Width;
        public int Heigth;



        public Button(int positionX, int positionY, int heigth, int width)
        {
            Width = width;
            Heigth = heigth;

            Position = new Vector2(positionX, positionY);           
            Texture = new Texture2D(Game1.instance.GraphicsDevice, width, heigth);         
            
            Color[] square = new Color[width * heigth];
            for (int i = 0; i < square.Length; i++) square[i] = Color.DarkRed;
            Texture.SetData(square);

        }


        public bool MouseTracking()
        {
            
            if (Mouse.GetState().X >= Position.X || Mouse.GetState().X <= Width)
            { if (Mouse.GetState().Y >= Position.Y || Mouse.GetState().Y <= Heigth)
                {
                    return true;

                }

            }              
        }

        public bool IsClicked()
        {
            if (MouseTracking() = true | Mouse.().LeftButton)
        }

    }
}
