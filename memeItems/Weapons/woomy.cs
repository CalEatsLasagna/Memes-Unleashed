using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class woomy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("woomy");
		}
		public override void SetDefaults()
		{
			item.width = 96;
			item.height = 96;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.value = 100;
			item.rare = -12;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/woomy");
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
