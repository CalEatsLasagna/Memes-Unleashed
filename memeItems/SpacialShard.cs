using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	public class SpacialShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Harvested from Shale. It's glowing.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 8;
			
		}
					
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Shale", 5);
			recipe.AddTile(null, "Purifier");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}