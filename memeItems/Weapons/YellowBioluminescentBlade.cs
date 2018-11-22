using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class YellowBioluminescentBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bioluminescent Blade");
			Tooltip.SetDefault("Shining brightly.");
		}
		public override void SetDefaults()
		{
			item.damage = 17;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NullSingularity", 3);
			recipe.AddIngredient(ItemID.VineRope, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
