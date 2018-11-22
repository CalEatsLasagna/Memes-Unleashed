using MemesUnleashed.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class PATRICK : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("WAH");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 36;
			item.rare = 0;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = null;
			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<PATRICKProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodYoyo);
			recipe.AddIngredient(ItemID.SoulofNight, 4);
			recipe.AddIngredient(null, "MemeCoin", 50);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
