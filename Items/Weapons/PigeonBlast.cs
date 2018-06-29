using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MemesUnleashed.Items.Weapons
{
	public class PigeonBlast : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The power of the fattest vape rests in your hands");
		}

		public override void SetDefaults()
		{
			item.damage = 47;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 3;
			item.rare = 4;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("Pewpew");
			item.value = Item.sellPrice(silver: 3);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StarCannon);
			recipe.AddIngredient(ItemID.LifeCrystal, 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
