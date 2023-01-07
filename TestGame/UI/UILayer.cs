﻿using Microsoft.Xna.Framework.Graphics;

using System.Collections.Generic;


namespace TestGame.UI
{
    internal class UILayer
    {
        private readonly List<UIControl> controls = new();

        public void AddControl(UIControl control)
        {
            controls.Add(control);
        }

        public void Update()
        {
            foreach (var control in controls)
            {
                control.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            foreach (var control in controls)
            {
                control.Draw(spriteBatch);
            }
            spriteBatch.End();
        }
    }
}