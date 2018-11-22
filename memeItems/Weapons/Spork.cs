﻿using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class Spork : ModItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 12f;
			item.damage = 17;
			item.knockBack = 4f;
			item.useStyle = 1;
			item.useAnimation = 7;
			item.useTime = 7;
			item.width = 17;
			item.height = 17;
			item.maxStack = 9999;
			item.rare = 1;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<SporkProjectile>();
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 40);
			recipe.AddRecipe();
		}
	}
}
