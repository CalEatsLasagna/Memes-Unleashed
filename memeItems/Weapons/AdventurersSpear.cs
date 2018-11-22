using System;
using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class AdventurersSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Pretty standard weapon.");
			DisplayName.SetDefault("Adventurer's Spear");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.useStyle = 5;
			item.useAnimation = 13;
			item.useTime = 13;
			item.shootSpeed = 6f;
			item.knockBack = 2.5f;
			item.width = 64;
			item.height = 64;
			item.scale = 0.8f;
			item.rare = 1;
			item.value = Item.sellPrice(silver: 10);

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = false; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<AdventurersSpearProjectile>();
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
					public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Spear);
			recipe.AddIngredient(ItemID.StoneBlock, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
