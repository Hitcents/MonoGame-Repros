using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Microsoft.Xna.Framework;

namespace TextureAt2048
{
	[Activity(
		Label = "2048 Texture", 
		MainLauncher = true,
		ConfigurationChanges = ConfigChanges.Orientation,
		Icon = "@drawable/icon", 
		ScreenOrientation = ScreenOrientation.Landscape, 
		Theme = "@android:style/Theme.NoTitleBar", 
		AlwaysRetainTaskState = true,
		LaunchMode = LaunchMode.SingleInstance)]
	public class Activity1 : AndroidGameActivity
	{
		Game1 _game;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Game.Activity = this;
			_game = new Game1();
			_game.Run ();
			SetContentView (_game.Window);
		}
	}
}


