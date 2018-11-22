using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	public class WeightReducer : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Literally a chicken sandwich. Makes things lighter for some reason.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
			
		}
					
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}