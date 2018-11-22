using System;
using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MemesUnleashed.memeItems.Weapons
{
	public class ThunderSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Zap some dudes");
		}

		public override void SetDefaults()
		{
			item.damage = 29;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 18;
			item.shootSpeed = 6f;
			item.knockBack = 6.5f;
			item.width = 64;
			item.height = 64;
			item.scale = 1f;
			item.rare = 3;
			item.value = Item.sellPrice(silver: 26 );

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<ThunderSpearProjectile>();
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.LaserMachinegunLaser, damage, knockBack, player.whoAmI);
			return true;
		}
		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ElectricCrystal");
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddIngredient(ItemID.SunplateBlock, 10);
			recipe.AddIngredient(ItemID.Starfury);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
