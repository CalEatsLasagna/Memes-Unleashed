using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
// If you are using c# 6, you can use: "using static Terraria.Localization.GameCulture;" which would mean you could just write "DisplayName.AddTranslation(German, "");"
using Terraria.Localization;

namespace MemesUnleashed.memeItems.Placeable
{
	public class MemeStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The classic Meme Coin. Now in a placable block form! Use in an Extractinator to get some dank loot.");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;

	
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 2;
			item.useTime = 2;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("MemeStone");
		}

		public override void AddRecipes()
		{
			if (!Main.dedServ)
			{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 2);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "MemeWall", 4);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
			}
		}

		public override void ExtractinatorUse(ref int resultType, ref int resultStack)
		{
			if (Main.rand.Next(30) == 0)
			{
				resultType = mod.ItemType("MemeCoin");
				if (Main.rand.Next(5) == 0)
				{
					resultStack += Main.rand.Next(2);
				}
			}
		}
	}
}
