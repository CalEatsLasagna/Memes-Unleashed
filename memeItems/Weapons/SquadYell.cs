using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class SquadYell : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Squad yell attracts more fights.");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 58;
			item.height = 53;
			item.maxStack = 9999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 2.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("SquadYell");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 40f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		// Give each bullet consumed a 10% chance of granting the OnFire! buff for 4 seconds
		public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(5))
			{
				player.AddBuff(BuffID.Battle, 500);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 5);
			recipe.AddIngredient(null, "MemeCoin");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}
