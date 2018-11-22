using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class PharaohsHand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pharaoh's Hand");
			Tooltip.SetDefault("Can be thrown or used as ammo.");
		}
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 12f;
			item.damage = 15;
			item.knockBack = 4f;
			item.useStyle = 1;
			item.useAnimation = 8;
			item.useTime = 8;
			item.width = 30;
			item.height = 30;
			item.maxStack = 1;
			item.rare = 3;
			item.ammo = AmmoID.Arrow;

			item.consumable = false;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.ranged = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 15);
			item.shoot = mod.ProjectileType ("PharaohsHand");
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SandstoneBrick, 30);
			recipe.AddIngredient(ItemID.Topaz, 10);
			recipe.AddIngredient(ItemID.GoldBar, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.SandstoneBrick, 30);
			recipe2.AddIngredient(ItemID.Topaz, 10);
			recipe2.AddIngredient(ItemID.PlatinumBar, 7);
			recipe2.AddTile(TileID.WorkBenches);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}
