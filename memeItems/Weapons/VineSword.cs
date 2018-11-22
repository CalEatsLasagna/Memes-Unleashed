using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class VineSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vine Sword");
		}
		public override void SetDefaults()
		{
			item.damage = 11;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}
			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VineRope, 12);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.VineRope, 12);
			recipe2.AddIngredient(ItemID.LeadBar, 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}
