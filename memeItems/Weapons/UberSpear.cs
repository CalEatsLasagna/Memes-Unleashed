using System;
using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MemesUnleashed.memeItems.Weapons
{
	public class UberSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's pretty cool maybe");
		}

		public override void SetDefaults()
		{
			item.damage = 130;
			item.useStyle = 5;
			item.useAnimation = 6;
			item.useTime = 6;
			item.shootSpeed = 6f;
			item.knockBack = 6.5f;
			item.width = 172;
			item.height = 172;
			item.scale = 1f;
			item.rare = 9;
			item.value = Item.sellPrice(silver: 80 );

			item.melee = true;
			item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
			item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
			item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<UberSpearProjectile>();
		}

		public override bool CanUseItem(Player player)
		{
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType ("UberBlast"), damage, knockBack, player.whoAmI);
			return true;
		}
		

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpacialShard", 20);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddIngredient(null, "ThunderSpear");
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
