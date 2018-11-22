using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class SinisterDuality : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Left click inflicts poison, right click lights enemies ablaze.");
		}

		public override void SetDefaults()
		{
			item.damage = 42;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("FireBlast");
			item.shootSpeed = 5f;
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
				item.damage = 50;
				item.shoot = 0;
			}
			else
			{
				item.useStyle = 1;
				item.useTime = 20;
				item.useAnimation = 20;
				item.damage = 37;
				item.shoot = mod.ProjectileType ("FireBlast");
			}
			return base.CanUseItem(player);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if (player.altFunctionUse == 2)
			{
				target.AddBuff(BuffID.OnFire, 60);
			}
			else
			{
				target.AddBuff(BuffID.Poisoned, 300);
			}
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				if (player.altFunctionUse == 2)
				{
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
					Main.dust[dust].noGravity = true;
				}
				else
				{
					int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
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
	}
}