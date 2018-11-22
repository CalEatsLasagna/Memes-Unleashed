using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class IronThrowingKnife : ModItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 12f;
			item.damage = 11;
			item.knockBack = 4f;
			item.useStyle = 1;
			item.useAnimation = 9;
			item.useTime = 9;
			item.width = 30;
			item.height = 30;
			item.maxStack = 9999;
			item.rare = 1;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 11);
			item.shoot = mod.ProjectileType<IronThrowingKnifeProjectile>();
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
	}
}
