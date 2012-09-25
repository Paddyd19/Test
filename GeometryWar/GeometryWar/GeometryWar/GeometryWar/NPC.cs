﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace GeometryWar
{
    class NPC : Entity
    {
        public NPC()
        {
            mPosition = Vector2.Zero;
            mVelocity = new Vector2(Globals.random.Next(-30, 30),Globals.random.Next(-30,30));
            mOrientation = mVelocity;
            mAcceleration = Vector2.Zero;
        }
    }
}
