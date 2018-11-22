using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class NullBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Null Blade");
			Tooltip.SetDefault("The form of this blade seems to shift in your hand.");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.melee = true;
			item.width = 128;
			item.height = 128;
			item.useTime = 10;
			item.useAnimation = 10;
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
			recipe.AddIngredient(null, "NullSingularity", 10);
			recipe.AddIngredient(null, "MemeCoin", 100);
			recipe.AddIngredient(ItemID.BreakerBlade, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
