using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class MudShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's a mess, but a good time.");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 32;
			item.height = 32;
			item.maxStack = 9999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 6f;
			item.value = 10;
			item.rare = 0;  	 //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;    
			item.shoot = mod.ProjectileType("MudShot");			
			item.ammo = AmmoID.Bullet;
			//The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MudBlock, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
