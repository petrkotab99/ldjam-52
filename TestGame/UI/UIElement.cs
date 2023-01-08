﻿using Microsoft.Xna.Framework.Graphics;

using TestGame.Components;


namespace TestGame.UI
{
    internal abstract class UIElement
    {
        public Apperance Apperance;

        public virtual void Update() { }
        public virtual void Draw(SpriteBatch spriteBatch)
            => Apperance.Draw(spriteBatch);
    }
}