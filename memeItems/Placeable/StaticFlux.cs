using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Placeable
{
	public class StaticFlux : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Static Flux)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("StaticFlux");
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
