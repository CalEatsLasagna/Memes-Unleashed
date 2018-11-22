using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class SuperchargedHopperBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Supercharged Hopper Blade");
			Tooltip.SetDefault("Satisfying.");
		}
		public override void SetDefaults()
		{
			item.damage = 32;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("NullSphere");
			item.shootSpeed = 12;
		}		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CharredMysteriousMatrix", 2);
			recipe.AddIngredient(null, "HopperBlade");
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
