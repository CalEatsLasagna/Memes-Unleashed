using Microsoft.Xna.Framework;
using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class CounterLance : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Casts a large protective aura when used.");
		}

		public override void SetDefaults()
		{
			item.damage = 52;
			item.useStyle = 5;
			item.useAnimation = 10;
			item.useTime = 10;
			item.shootSpeed = 6f;
			item.knockBack = 6.5f;
			item.width = 64;
			item.height = 64;
			item.scale = 1f;
			item.rare = 5;
			item.value = Item.sellPrice(silver: 30);

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<CounterLanceProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 50);
			recipe.AddIngredient(null, "CharredMysteriousMatrix", 2);
			recipe.AddIngredient(ItemID.Spear);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 360 degree spread. Oh hell yeah.
				// If you want to randomize the speed to stagger the projectiles
				 float scale = 1f - (Main.rand.NextFloat() * .3f);
				 perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return true; // return false because we do want tmodloader to shoot projectile and kick lots of ass
		}
	}
}
