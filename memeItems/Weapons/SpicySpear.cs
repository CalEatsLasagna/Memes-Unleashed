using System;
using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class SpicySpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It literally smells like hot sauce.");
		}

		public override void SetDefaults()
		{
			item.damage = 36;
			item.useStyle = 5;
			item.useAnimation = 12;
			item.useTime = 12;
			item.shootSpeed = 6f;
			item.knockBack = 6.5f;
			item.width = 172;
			item.height = 172;
			item.scale = 1f;
			item.rare = 3;
			item.value = Item.sellPrice(silver: 22);

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<SpicySpearProjectile>();
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
					public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 30);
			recipe.AddIngredient(ItemID.HellstoneBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
