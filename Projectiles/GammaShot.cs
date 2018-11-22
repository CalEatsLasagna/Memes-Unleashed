using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.Projectiles
{
	public class GammaShot : ModProjectile
	{

		
		private const float sinSpeed = 0.15f;
		private const float waveHeight = 1.2f;
		private float originalRotation;
		private float originalSpeed;
		private double sin = Math.PI / 2;
		
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
		}

	public override void AI()
	{
	if (sin == Math.PI / 2)
	{
		originalRotation = projectile.velocity.ToRotation();
		originalSpeed = projectile.velocity.Length();
	}

	float y = (float)Math.Sin(sin) * waveHeight;
	projectile.velocity = new Vector2(originalSpeed, y).RotatedBy(originalRotation);

	sin += sinSpeed;
	}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("Gamma"), projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 0.5f);
			}
			Main.PlaySound (mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit"));
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.8f;
		}
	}
}