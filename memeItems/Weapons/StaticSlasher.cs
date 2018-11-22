using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class StaticSlasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Static Slasher");
			Tooltip.SetDefault("Strangely hypnotic.");
		}
		public override void SetDefaults()
		{
			item.damage = 38;
			item.melee = true;
			item.width = 108;
			item.height = 108;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("StaticBall");
			item.shootSpeed = 10;
		}
				
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CompressedStatic", 10);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(null, "HopperBlade");
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
