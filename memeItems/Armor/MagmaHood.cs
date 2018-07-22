using Terraria;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class MagmaHood : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Incendium.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 3;
			item.defense = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("MagmaOrb");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "You feel like a true caster. 12% increased magic damage and +60 mana.";
			player.magicDamage *= 1.12f;
			player.statManaMax2 += 60;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MagmiumCrystal", 18);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}