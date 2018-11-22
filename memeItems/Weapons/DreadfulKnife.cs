using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DreadfulKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dreadful Knife");
			Tooltip.SetDefault("I just... want to look at you...");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 3;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = -1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
