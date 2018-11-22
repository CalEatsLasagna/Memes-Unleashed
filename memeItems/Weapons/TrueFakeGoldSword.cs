using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class TrueFakeGoldSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Fake Gold Sword");
			Tooltip.SetDefault("Not actually that much of an improvement.");
		}
		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 12000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(null, "FakeGoldSword");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
