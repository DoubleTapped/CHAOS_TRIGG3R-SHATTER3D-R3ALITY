using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CHAOS_TRIGG3R_SHATT3R3D_R3ALITY
{
    public class SplashScreen : GameScreen
    {
        KeyboardState keyState;
        SpriteFont font;

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            if (font == null)
            {
                font = Content.Load<SpriteFont>("SpriteFont1.spritefont");
            }
        }

        public override void UnloadContent(ContentManager Content)
        {
            base.UnloadContent(Content);
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Z))
            {
                ScreenManager.Instance.AddScreen(new TitleScreen());
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, "SplashScreen", new Vector2(100, 100), Color.Black);
        }
    }
}
