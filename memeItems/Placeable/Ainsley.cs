using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Placeable
{
	public class Ainsley : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ainsley");
			Tooltip.SetDefault("hehe yea boi");
		}
		public override void SetDefaults()
		{
			item.width = 50;
			item.height = 34;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 10000;
			item.rare = 0;
			item.createTile = mod.TileType("Ainsley");
			item.placeStyle = 0;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}