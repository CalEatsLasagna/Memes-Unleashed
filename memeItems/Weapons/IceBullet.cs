using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class IceBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Frosty.");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 4f;
			item.value = 10;
			item.rare = 1;  	 //The projectile shoot when your weapon using this ammo
			item.shoot = mod.ProjectileType("IceBullet");
			item.shootSpeed = 24f;                 			 //The speed of the projectile
			item.ammo = AmmoID.Bullet;           		 	 //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 2);
			recipe.AddIngredient(ItemID.SnowBlock);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}
	}
}
