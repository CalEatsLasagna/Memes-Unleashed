using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	//imported from my tAPI mod because I'm lazy
	public class SturdyBranch : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a Tree Guardian to fight for you.");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.summon = true;
			item.mana = 10;
			item.width = 26;
			item.height = 28;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = Item.buyPrice(0, 30, 0, 0);
			item.rare = 0;
			item.UseSound = SoundID.Item44;
			item.shoot = mod.ProjectileType("TreeGuardian");
			item.shootSpeed = 10f;
			item.buffType = mod.BuffType("TreeGuardian");	//The buff added to player after used the item
			item.buffTime = 36000;				//The duration of the buff, here is 10 minutes
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
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
