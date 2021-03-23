﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship_Game
{
    class Asteroid
    {
        public Vector2 position = new Vector2(300, 300);
        public int speed;
        public int radius = 59;
        public bool offscreen = false;

        static Random rand = new Random();

        public Asteroid (int newSpeed)
        {
            speed = newSpeed;

            

            position = new Vector2(1280 + radius, rand.Next(0, 721));
        }

        public void asteroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
