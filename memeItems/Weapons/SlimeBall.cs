using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class SlimeBall : ModItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 22f;
			item.damage = 22;
			item.knockBack = 4f;
			item.useStyle = 1;
			item.useAnimation = 12;
			item.useTime = 12;
			item.width = 17;
			item.height = 17;
			item.maxStack = 1;
			item.rare = 2;

			item.consumable = false;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 29);
			item.shoot = mod.ProjectileType ("SlimeBall");
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteOre, 10);
			recipe.AddIngredient(ItemID.Vine, 3);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
