﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
// If you are using c# 6, you can use: "using static Terraria.Localization.GameCulture;" which would mean you could just write "DisplayName.AddTranslation(German, "");"
using Terraria.Localization;

namespace MemesUnleashed.memeItems.Placeable
{
	public class MagmiumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Static ore that overheated upon the world's creation. It is shimmering like a hot coal.");

	
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 9999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MagmiumOre");
		}
	}
}
