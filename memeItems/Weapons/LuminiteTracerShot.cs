using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class LuminiteTracerShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Line 'em up, obliterate the planet.'");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.ranged = true;
			item.width = 45;
			item.height = 45;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 6f;
			item.value = 10;
			item.rare = 9;  	 //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;    
			item.shoot = mod.ProjectileType("LuminiteTracerShot");			
			item.ammo = AmmoID.Bullet;
			//The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 2);
			recipe.AddIngredient(null, "MudShot", 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 30);
			recipe.AddRecipe();
		}
	}
}
