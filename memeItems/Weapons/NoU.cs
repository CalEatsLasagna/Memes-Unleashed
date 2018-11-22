using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class NoU : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("no u");
			Tooltip.SetDefault("The ultimate comeback.");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 1;
			item.knockBack = 224;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}
			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
