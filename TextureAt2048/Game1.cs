using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TextureAt2048
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private Texture2D _texture;

		public Game1 ()
		{
			_graphics = new GraphicsDeviceManager(this);
		}

		protected override void LoadContent()
		{
			base.LoadContent();
			
			_spriteBatch = new SpriteBatch(GraphicsDevice);
			_texture = Content.Load<Texture2D> ("medium_test1");
		}

		protected override void Draw (GameTime gameTime)
		{
			GraphicsDevice.Clear (Color.LightGray);

			_spriteBatch.Begin ();
			_spriteBatch.Draw (_texture, Vector2.Zero, Color.White);
			_spriteBatch.End ();
		}
	}
}

