using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DietBigSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diet Big Sword");
			Tooltip.SetDefault("Less calories.");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 24;
			item.value = 10000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BigSword");
			recipe.AddIngredient(null, "WeightReducer");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
