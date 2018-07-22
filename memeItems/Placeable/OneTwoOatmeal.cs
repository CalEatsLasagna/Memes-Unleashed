using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Placeable
{
	public class OneTwoOatmeal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (1 2 Oatmeal)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("OneTwoOatmeal");
			item.width = 24;
			item.height = 24;
			item.rare = 8;
			item.value = 100000;
			item.accessory = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 20);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
