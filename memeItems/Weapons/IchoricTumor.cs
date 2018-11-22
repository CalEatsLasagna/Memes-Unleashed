using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class IchoricTumor : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fires a volley of ichor.");
		}

		public override void SetDefaults()
		{
			item.damage = 86;
			item.magic = true;
			item.mana = 5;
			item.width = 40;
			item.height = 40;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 12000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.IchorSplash;
			item.shootSpeed = 9f;
			item.useAnimation = 5;
			item.useTime = 5;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.Ichor, 20);
			recipe.AddIngredient(ItemID.GoldenShower);
			recipe.AddIngredient(null, "SpacialShard", 5);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}