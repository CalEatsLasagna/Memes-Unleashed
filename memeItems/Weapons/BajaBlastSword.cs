using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class BajaBlastSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baja Blast Sword");
			Tooltip.SetDefault("The blade is sharp but it's worth it because it's delicious.");
		}
		public override void SetDefaults()
		{
			item.damage = 117;
			item.melee = true;
			item.width = 524;
			item.height = 524;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("BajaBlastSwordProjectile");
			item.shootSpeed = 18;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 30);
			recipe.AddIngredient(null, "WeebSword", 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
