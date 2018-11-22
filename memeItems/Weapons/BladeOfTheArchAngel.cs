using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class BladeOfTheArchangel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blade Of The Archangel");
			Tooltip.SetDefault("Deals summon damage.");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.summon = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}
		
		public override bool UseItem(Player player)
		{
			if(player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 8);
			recipe.AddIngredient(ItemID.FieryGreatsword);
			recipe.AddIngredient(ItemID.CrystalShard, 10);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
