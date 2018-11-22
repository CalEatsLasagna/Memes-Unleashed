using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class PlatigoldRapier : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Stabbing attacks from this weapon deal 1.5x its base damage.");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = 3;
				item.useTime = 20;
				item.useAnimation = 20;
				item.damage = 24;
				item.shoot = 0;
			}
			else
			{
				item.useStyle = 1;
				item.useTime = 20;
				item.useAnimation = 20;
				item.damage = 16;
			}
			return base.CanUseItem(player);
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				if (player.altFunctionUse == 2)
				{
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"), player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 1f);
					Main.dust[dust].noGravity = true;
				}
				else
				{
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"), player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 1f);
					Main.dust[dust].noGravity = true;
				}
			}
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Fix the speedX and Y to point them horizontally.
			speedX = new Vector2(speedX, speedY).Length() * (speedX > 0 ? 1 : -1);
			speedY = 0;
			// Add random Rotation
			Vector2 speed = new Vector2(speedX, speedY);
			speed = speed.RotatedByRandom(MathHelper.ToRadians(30));
			// Change the damage since it is based off the weapons damage and is too high
			damage = (int)(damage * .1f);
			speedX = speed.X;
			speedY = speed.Y;
			return true;
		}
			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.PlatinumBar, 15);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}