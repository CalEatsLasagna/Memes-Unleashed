using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class RedGumdrop : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Strawberry flavored.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.magic = true;
			item.mana = 4;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 4000;
			item.rare = 2;
			item.UseSound = SoundID.Item84;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("RedGumdropProjectile");
			item.shootSpeed = 8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NullSingularity", 2);
			recipe.AddIngredient(null, "MemeCoin", 100);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}