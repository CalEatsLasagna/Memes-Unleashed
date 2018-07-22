using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Placeable
{
	public class InstantCompressor : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Deploys a Compressor, used to craft with loose materials.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("Compressor");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Furnace);
			recipe.AddIngredient(null, "MemeCoin", 10);
			recipe.AddIngredient(null, "NullSingularity");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}