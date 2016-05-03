﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Project_Broban
{
    class Player : GameObject
    {
        private Texture2D PlayerTexture;
        Vector2 Position;

        Player()
        {
            Position = new Vector2(0, 0);
        }

        public void Update()
        {
            //Todo handle input 
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(PlayerTexture, Position, Color.White);
        }

        public void LoadContent()
        {
            //Todo load sprite
        }

        public void UnloadContent()
        {
        }

    }
}
