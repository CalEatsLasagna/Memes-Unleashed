using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.Items.Weapons
{
	public class BluntSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blunt Sword");
			Tooltip.SetDefault("Smonk.");
		}
		public override void SetDefaults()
		{
			item.damage = 36;
			item.melee = true;
			item.width = 256;
			item.height = 224;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
