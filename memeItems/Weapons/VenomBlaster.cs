using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class VenomBlaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Venom Blaster");			

		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 21;
			item.useAnimation = 21;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/ElectroLaser");
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("VenomLaser");
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 4);
			recipe.AddIngredient(null, "NullSingularity", 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "VenomBlasterMagic");
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}