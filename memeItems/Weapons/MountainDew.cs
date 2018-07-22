using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class MountainDew : ModItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 12f;
			item.damage = 60;
			item.knockBack = 5f;
			item.useStyle = 1;
			item.useAnimation = 8;
			item.useTime = 8;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = 4;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = false;
			item.autoReuse = true;
			item.thrown = false;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 15);
			item.shoot = mod.ProjectileType<MountainDewProjectile>();
		}
		
					public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 6);
			recipe.AddIngredient(ItemID.HallowedBar, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}
	}
}
