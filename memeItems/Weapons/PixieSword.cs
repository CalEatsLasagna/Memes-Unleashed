using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class PixieSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pixie Sword");
			Tooltip.SetDefault("There's a fairy stuck on the handle. Gross.");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.melee = true;
			item.width = 256;
			item.height = 224;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 20);
			recipe.AddIngredient(ItemID.TitaniumSword);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.PixieDust, 20);
			recipe2.AddIngredient(ItemID.AdamantiteSword);
			recipe2.AddTile(TileID.WorkBenches);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}
