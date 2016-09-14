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
    public class ScreenManager
    {
        #region Variables
        GameScreen currentScreen;
        GameScreen newScreen;

        private static ScreenManager instance;

        Stack<GameScreen> screenStack = new Stack<GameScreen>();

        Vector2 dimensions;

        #endregion
        #region Properties
        public static ScreenManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ScreenManager();
                }
                return instance;
            }
        }
        public Vector2 Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }
        #endregion
        #region Main Methods
        public void AddScreen(GameScreen screen)
        {

        }
        public void Initialize()
        {

        }
        public void LoadContent(ContentManager Content)
        {

        }
        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {

        }
        #endregion
    }
}
