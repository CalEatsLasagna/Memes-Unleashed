using Terraria;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class NegativeMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Darker than dark.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 5;
			item.defense = 17;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("NegativeBreastplate") && legs.type == mod.ItemType("NegativeLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Your melee and ranged weapons seem more powerful. 10% increased melee and ranged damage.";
			player.meleeDamage *= 1.1f;
			player.rangedDamage *= 1.1f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NullSingularity", 4);
			recipe.AddTile(null, "Purifier");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}