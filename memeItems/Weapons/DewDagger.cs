﻿using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DewDagger : ModItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 10f;
			item.damage = 45;
			item.knockBack = 5f;
			item.useStyle = 1;
			item.useAnimation = 10;
			item.useTime = 10;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = 3;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
			item.shoot = mod.ProjectileType<DewDaggerProjectile>();
		}
			
					public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 6);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
	}
}
