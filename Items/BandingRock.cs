using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.Items
{
	//imported from my tAPI mod because I'm lazy
	public class BandingRock : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Use in the Underworld. Be careful, this boss is really strong and poorly sprited.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = 4;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		// We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
		public override bool CanUseItem(Player player)
		{
			// "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return player.ZoneUnderworldHeight && !NPC.AnyNPCs(mod.NPCType("Wokebird"));
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Wokebird"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 500);
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}