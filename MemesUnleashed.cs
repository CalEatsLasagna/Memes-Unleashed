using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using System;

namespace MemesUnleashed
{
	class MemesUnleashed : Mod
	{
		public MemesUnleashed()
		{
			
			
		}
		public override void Load()
		{
		if (!Main.dedServ)
		
		//music boxes
			{
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/OneTwoOatmeal"), ItemType("OneTwoOatmeal"), TileType("OneTwoOatmeal"));
			AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/StaticFlux"), ItemType("StaticFlux"), TileType("StaticFlux"));
			}
		}
	}
}
