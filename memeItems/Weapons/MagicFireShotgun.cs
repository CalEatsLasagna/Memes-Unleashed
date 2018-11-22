using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class MagicFireShotgun : ModItem
	{
	
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoots blasts of fireballs.");
		}

		public override void SetDefaults()
		{
			item.damage = 48;
			item.magic = true;
			item.mana = 15;
			item.width = 40;
			item.height = 40;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 12000;
			item.rare = 4;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.BallofFire;
			item.shootSpeed = 12f;
			item.useAnimation = 19;
			item.useTime = 19;
			item.useAmmo = AmmoID.Bullet;
		}
			public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
				 float scale = 1f - (Main.rand.NextFloat() * .3f);
				 perturbedSpeed = perturbedSpeed * scale; 
				 Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, ProjectileID.BallofFire, damage, knockBack, player.whoAmI);
			}
			return false;
		}

			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Shotgun);
			recipe.AddIngredient(ItemID.FlowerofFire);
			recipe.AddIngredient(null, "CharredMysteriousMatrix");			
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}