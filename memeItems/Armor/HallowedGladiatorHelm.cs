using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HallowedGladiatorHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rainbows and butterflies."
					+ "\nIncreases magic damage by 7%");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 4;
			item.defense = 14;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("HallowedGladiatorBreastplate") && legs.type == mod.ItemType("HallowedGladiatorLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "You now have greatly increased mana reserves.";
			player.statManaMax2 += 100;
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
		
		public override void UpdateEquip(Player player)
		{
			player.magicDamage *= 1.07f;
		}
	}
}