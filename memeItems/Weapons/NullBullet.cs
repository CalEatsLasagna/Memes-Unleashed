using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class NullBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Warning: Incredibly unstable. Firing too long may result in overheating.");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 2.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("NullBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 48f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		// Give each bullet consumed a 10% chance of granting the OnFire! buff for 4 seconds
		public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(20))
			{
				player.AddBuff(BuffID.OnFire, 120);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 25);
			recipe.AddIngredient(null, "NullSingularity", 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}
