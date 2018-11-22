using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace MemesUnleashed.memeItems.Weapons
{
	class JackOBomb : ModItem
	{
		// TODO, count as explosive for demolitionist spawn

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Jack O' Bomb");
			Tooltip.SetDefault("Very destructive. Can pass through tiles.");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType<Projectiles.JackOBomb>();
			item.width = 28;
			item.height = 28;
			item.maxStack = 99;
			item.consumable = true;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 20;
			item.useTime = 20;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 0, 20, 0);
			item.rare = -12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BlueBit", 10);
			recipe.AddIngredient(ItemID.Bomb, 3);
			recipe.AddIngredient(ItemID.Pumpkin, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
