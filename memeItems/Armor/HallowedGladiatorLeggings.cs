using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class HallowedGladiatorLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rainbows and butterflies."
				+ "\n7% increased movement speed"
				+ "\n7% increased melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 4;
			item.defense = 11;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.07f;
			player.meleeDamage *= 1.07f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 7);
			recipe.AddIngredient(ItemID.SoulofLight, 2);
			recipe.AddIngredient(ItemID.UnicornHorn, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}