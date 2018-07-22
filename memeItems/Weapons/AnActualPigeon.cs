using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MemesUnleashed.memeItems.Weapons
{
	public class AnActualPigeon : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A truly powerful bird indeed.");
		}

		public override void SetDefaults()
		{
			item.damage = 126;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 8;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("Pewpew");
			item.value = Item.sellPrice(silver: 90);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"PigeonBlast");
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(null,"MemeCoin", 120);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
