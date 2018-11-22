using System;
using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class GlassSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Don't cut yourself on it");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.useStyle = 5;
			item.useAnimation = 16;
			item.useTime = 16;
			item.shootSpeed = 6f;
			item.knockBack = 6.5f;
			item.width = 64;
			item.height = 64;
			item.scale = 1f;
			item.rare = 2;
			item.value = Item.sellPrice(silver: 23);

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<GlassSpearProjectile>();
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
		
					public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 12);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
