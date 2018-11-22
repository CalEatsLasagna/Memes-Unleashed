using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class IceCube : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Frosty. Counts as a Rocket.");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 4f;
			item.value = 10;
			item.rare = 2;  	 //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 24f;                 			 //The speed of the projectile
			item.ammo = AmmoID.Rocket;           		 	 //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 2);
			recipe.AddIngredient(ItemID.SnowBlock);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
