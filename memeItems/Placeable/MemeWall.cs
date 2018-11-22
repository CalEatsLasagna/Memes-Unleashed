using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Placeable
{
	public class MemeWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Smells dank.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("MemeWall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeStone");
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}