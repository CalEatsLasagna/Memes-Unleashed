using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DietFakeGoldSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diet Fake Gold Sword");
			Tooltip.SetDefault("It's a little faster. Still sucks though.");
		}
		public override void SetDefaults()
		{
			item.damage = 9;
			item.melee = true;
			item.width = 256;
			item.height = 224;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FakeGoldSword");
			recipe.AddIngredient(null, "WeightReducer");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
