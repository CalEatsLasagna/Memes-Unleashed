using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class BigSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Big Sword");
			Tooltip.SetDefault("Size matters.");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 3;
			item.knockBack = 24;
			item.value = 10000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
