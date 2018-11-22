using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
// If you are using c# 6, you can use: "using static Terraria.Localization.GameCulture;" which would mean you could just write "DisplayName.AddTranslation(German, "");"
using Terraria.Localization;

namespace MemesUnleashed.memeItems.Placeable
{
	public class Shale : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Flakes easily.");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;

	
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
			item.value = 1000;
			item.consumable = true;
			item.createTile = mod.TileType("Shale");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
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
