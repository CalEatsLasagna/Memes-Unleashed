using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DietNullBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diet Null Blade");
			Tooltip.SetDefault("Now without trans fats.");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.melee = true;
			item.width = 128;
			item.height = 128;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NullBlade");
			recipe.AddIngredient(null, "WeightReducer");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
