using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MemesUnleashed.memeItems.Weapons
{
	public class GumdropCombo : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Extravagant flavors!");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.magic = true;
			item.mana = 4;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 8000;
			item.rare = 2;
			item.UseSound = SoundID.Item84;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("RedGumdropProjectile");
			item.shootSpeed = 8f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("BlueGumdropProjectile"), damage, knockBack, player.whoAmI);
			return true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NullSingularity", 2);
			recipe.AddIngredient(null, "RedGumdrop");
			recipe.AddIngredient(null, "BlueGumdrop");
			recipe.AddIngredient(null, "MemeCoin", 100);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}