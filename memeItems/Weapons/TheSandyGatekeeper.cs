using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class TheSandyGatekeeper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Sandy Gatekeeper");
			Tooltip.SetDefault("If you listen close enough, you can hear the desert inside.");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 108;
			item.height = 108;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 13000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("SandBall");
			item.shootSpeed = 10;
		}
				
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FakeGoldSword");
			recipe.AddIngredient(ItemID.SandstoneBrick, 10);
			recipe.AddIngredient(ItemID.DemoniteBar, 15);
			recipe.AddIngredient(null, "HopperBlade");
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "FakeGoldSword");
			recipe2.AddIngredient(ItemID.SandstoneBrick, 10);
			recipe2.AddIngredient(ItemID.CrimtaneBar, 15);
			recipe2.AddIngredient(null, "HopperBlade");
			recipe2.AddTile(null, "Compressor");
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}
