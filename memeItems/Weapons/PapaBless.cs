using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class PapaBless : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bless up.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 126;
			item.magic = true;
			item.mana = 4;
			item.width = 150;
			item.height = 60;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 7;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("PapaBlessProjectile");
			item.shootSpeed = 6f;
			item.useAnimation = 12;
			item.useTime = 4;
			item.reuseDelay = 14;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MagmiumCrystal", 12);
			recipe.AddIngredient(null, "MemeCoin", 10);
			recipe.AddIngredient(null, "SpacialShard", 8);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(null, "Purifier");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}