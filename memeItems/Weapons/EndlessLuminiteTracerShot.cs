using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class EndlessLuminiteTracerShot : ModItem
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
			item.maxStack = 1;
			item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
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
			recipe.AddIngredient(ItemID.LunarBar, 20);
			recipe.AddIngredient(null, "LuminiteTracerShot", 299);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
