using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class BladeTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Casts ghostly blade constructs.");
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.magic = true;
			item.mana = 4;
			item.width = 40;
			item.height = 40;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 12000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BladeConstruct");
			item.shootSpeed = 12f;
			item.useAnimation = 8;
			item.useTime = 3;
			item.reuseDelay = 18;
		}
			public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperShortsword, 3);
			recipe.AddIngredient(ItemID.DemoniteBar, 8);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}