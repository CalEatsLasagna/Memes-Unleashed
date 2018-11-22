using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MemesUnleashed.memeItems.Weapons
{
	public class GalacticKunai : ModItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 18f;
			item.damage = 64;
			item.knockBack = 4f;
			item.useStyle = 1;
			item.useAnimation = 7;
			item.useTime = 7;
			item.width = 17;
			item.height = 17;
			item.maxStack = 1;
			item.rare = 6;

			item.consumable = false;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 2);
			item.shoot = mod.ProjectileType<GalacticKunaiProjectile>();
		}
						public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(18)); // 18 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				 float scale = 1f - (Main.rand.NextFloat() * .1f);
				 perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false; // return false because we don't want tmodloader to shoot projectile
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpacialShard", 18);
			recipe.AddTile(null, "Purifier");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
