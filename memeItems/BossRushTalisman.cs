using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	//imported from my tAPI mod because I'm lazy
	public class BossRushTalisman : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons all Memes Unleashed bosses at once. Best used in the Underworld.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = 5;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item44;
			item.consumable = true;

		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Weegee"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Mayro"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("BladeDemon"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Wokebird"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Sanic"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("ReverseSanic"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("DarkSanic"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("GiantGrasshopper"));
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Missingno"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 999);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddIngredient(ItemID.HallowedBar, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}