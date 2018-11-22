using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MemesUnleashed.memeItems.Weapons
{
	public class FlowerWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fires a harsh beam of light.");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 4;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("SunLaser");
			item.value = Item.sellPrice(silver: 3);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
