using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MemesUnleashed.memeItems.Weapons
{
	public class PossessedTotem : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("b o n e l e s s");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.magic = true;
			item.mana = 5;
			item.width = 40;
			item.height = 40;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 3;
			item.value = 12500;
			item.rare = 6;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("TotemBlast");
			item.shootSpeed = 11f;
		}
						public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // 10 degree spread.
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
			recipe.AddIngredient(null, "NatureCrystal");
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddTile(null, "Purifier");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}