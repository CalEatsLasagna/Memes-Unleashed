using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class BentHarp : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Yeet.");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.magic = true;
			item.mana = 5;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 14000;
			item.rare = 5;
			item.UseSound = SoundID.Item4;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Note");
			item.shootSpeed = 9f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "StaticStaff");
			recipe.AddIngredient(null, "MemeCoin", 30);
			recipe.AddIngredient(ItemID.MagicalHarp);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}