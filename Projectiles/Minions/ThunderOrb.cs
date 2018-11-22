using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace MemesUnleashed.Projectiles.Minions
{
	//ported from my tAPI mod because I'm lazy
	public class ThunderOrb : HoverShooter
	{
		public override void SetStaticDefaults()
		{
			Main.projPet[projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.Homing[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true; //This is necessary for right-click targeting
		}

		public override void SetDefaults()
		{
			projectile.netImportant = true;
			projectile.width = 32;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			inertia = 20f;
			shoot = ProjectileID.LaserMachinegunLaser;
			shootSpeed = 12f;
		}

		public override void CheckActive()
		{
			Player player = Main.player[projectile.owner];
			MemePlayer modPlayer = player.GetModPlayer<MemePlayer>(mod);
			if (player.dead)
			{
				modPlayer.thunderMinion = false;
			}
			if (modPlayer.thunderMinion)
			{
				projectile.timeLeft = 2;
			}
		}

		public override void CreateDust()
		{
			if (projectile.ai[0] == 0f)
			{
				if (Main.rand.Next(5) == 0)
				{
					int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height / 2, mod.DustType("Sparks"));
					Main.dust[dust].velocity.Y -= 1.2f;
				}
			}
			else
			{
				if (Main.rand.Next(3) == 0)
				{
					Vector2 dustVel = projectile.velocity;
					if (dustVel != Vector2.Zero)
					{
						dustVel.Normalize();
					}
					int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("Sparks"));
					Main.dust[dust].velocity -= 1.2f * dustVel;
				}
			}
			Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.6f, 0.9f, 0.3f);
		}
	}
}