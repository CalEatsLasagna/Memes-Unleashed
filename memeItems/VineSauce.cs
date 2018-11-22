using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	public class VineSauce : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vine Sauce");
			Tooltip.SetDefault("Good on pasta."
				+ "\nDuwang.");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 24;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 8;
			item.useTime = 8;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 1;
			item.consumable = false;
			item.rare = -12;
			item.healLife = 105; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
			item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
			item.value = Item.buyPrice(silver: 30);
		}
				public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MemeCoin", 2);
			recipe.AddIngredient(ItemID.VineRope, 5);
			recipe.AddIngredient(ItemID.Obsidian);
			recipe.AddIngredient(ItemID.Sunflower, 5);
			recipe.AddIngredient(null, "BlueBit", 40);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
