using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	public class MagmiumCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's lit.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 3;
			
		}
					
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MagmiumOre", 3);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}