using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class NegativeBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Negative Breastplate");
			Tooltip.SetDefault("Darker than dark."
				+ "\nImmunity to 'Cursed'"
				+ "\n3% increased melee and ranged damage.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 19;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.Cursed] = true;
			player.meleeDamage *= 1.03f;
			player.rangedDamage *= 1.03f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NullSingularity", 5);
			recipe.AddTile(null, "Purifier");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}