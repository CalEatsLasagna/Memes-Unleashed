using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class HallowedGladiatorBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Hallowed Gladiator Breastplate");
			Tooltip.SetDefault("Rainbows and butterflies."
				+ "\nImmunity to 'Confused'"
				+ "\n5% increased melee and magic damage.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 4;
			item.defense = 12;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.Confused] = true;
			player.meleeDamage *= 1.05f;
			player.magicDamage *= 1.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PixieDust, 10);
			recipe.AddIngredient(ItemID.SoulofLight, 3);
			recipe.AddIngredient(ItemID.UnicornHorn, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}