using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DietTrueFakeGoldSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diet True Fake Gold Sword");
			Tooltip.SetDefault("The name is starting to get kinda long. I wonder how long this meme can be kept up.");
		}
		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 12000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TrueFakeGoldSword");
			recipe.AddIngredient(null, "WeightReducer");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
