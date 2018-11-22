using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	public class FlaskofDew : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flask of Dew");
			Tooltip.SetDefault("Heals 10 life."
				+ "\nDoesn't grant potion sickness.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 8;
			item.useTime = 8;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 99;
			item.consumable = true;
			item.rare = 3;
			item.healLife = 10; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
			item.potion = false; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
			item.value = Item.buyPrice(silver: 10);
		}
				public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 5);
			recipe.AddIngredient(ItemID.Mushroom);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
