using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SmallerBackbuffer
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private Texture2D _texture;
		
		public Game1 ()
		{
			_graphics = new GraphicsDeviceManager(this);
			_graphics.IsFullScreen = true;

			//Here I'm modifying the backbuffer to "zoom in" the game to act as if it were 480x320 (height adjusted to keep ratio)
			//Comment this line, the game doesn't render any differently
			_graphics.PreferredBackBufferHeight = (int)(_graphics.PreferredBackBufferHeight * 480d / _graphics.PreferredBackBufferWidth);
			_graphics.PreferredBackBufferWidth = 480;
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

			_spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, SamplerState.LinearWrap, DepthStencilState.None, null, null, Matrix.Identity);
			_spriteBatch.Draw (_texture, Vector2.Zero, Color.White);
			_spriteBatch.End ();
		}
	}
}

