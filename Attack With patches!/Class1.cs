using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using Hearthstone_Deck_Tracker.Plugins;
using Microsoft.Win32;

namespace Attack_With_patches_
{
    public class Class1
    {
	    public static bool Activated = false;
	    internal static void GameStart()
	    {
		    if(!Activated) return;
	    }

	    internal static void ShowWindow()
	    {
			if(!Activated) return;

			var myWindow = new WAITT();
			
		}
    }

	public class PatchesPlugin : IPlugin
	{
		private readonly SoundPlayer _patches = new SoundPlayer("patches.mp3");
		private static int buttonPresses = 0;

		public void OnLoad()
		{
			Class1.Activated = true;
			DownloadSound();
		}

		public void OnUnload()
		{
			Class1.Activated = false;
		}

		public void OnButtonPress()
		{
			if(!Class1.Activated) return;
			buttonPresses++;
			if (buttonPresses >= 5)
			{
				_patches.Play();
			}
		}

		private void DownloadSound()
		{
			if (!File.Exists("patches.mp3"))
			{
				WebClient wc = new WebClient();
				wc.DownloadFile("https://judge2020.com/hdt/patches.mp3", "patches.mp3");
				wc.Dispose();
			}
		}

		public void OnUpdate()
		{
			
		}

		public string Name => "Attack with Patches!";
		public string Description => "Will help remind you to attack with Patches";
		public string ButtonText => "This button does nothing";
		public string Author => "Judge2020";
		public Version Version => new Version(1, 0, 0);
		public MenuItem MenuItem => null;
	}
}
