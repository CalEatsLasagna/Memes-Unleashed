using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class GammaBuster : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Mildly radioactive, but you'll probably be fine.");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.magic = true;
			item.mana = 2;
			item.width = 40;
			item.height = 40;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/GammaShot");
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("GammaShot");
			item.shootSpeed = 11f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NullSingularity", 5);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Handgun);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}