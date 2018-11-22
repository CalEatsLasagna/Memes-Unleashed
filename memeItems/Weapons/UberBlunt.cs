using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class UberBlunt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Uber Blunt");
			Tooltip.SetDefault("S M O N K.");
		}
		public override void SetDefaults()
		{
			item.damage = 208;
			item.melee = true;
			item.width = 156;
			item.height = 156;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("UberBluntProjectile");
			item.shootSpeed = 8;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(null, "GlowingBlunt", 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
