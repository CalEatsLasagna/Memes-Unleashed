using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DietBluntSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diet Blunt Sword");
			Tooltip.SetDefault("Smonk. Now with less cholesterol.");
		}
		public override void SetDefaults()
		{
			item.damage = 36;
			item.melee = true;
			item.width = 256;
			item.height = 224;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BluntSword");
			recipe.AddIngredient(null,"WeightReducer");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
