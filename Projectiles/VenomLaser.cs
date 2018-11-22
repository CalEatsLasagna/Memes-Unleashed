using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;

namespace MemesUnleashed.Projectiles
{
	public class VenomLaser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Venom Laser");     //The English name of the projectile
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}

		public override void SetDefaults()
		{
			projectile.width = 8;               //The width of projectile hitbox
			projectile.height = 8;              //The height of projectile hitbox
			projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?         
			projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.alpha = 20;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in)
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = false;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
			aiType = ProjectileID.Bullet;           //Act exactly like default Bullet
		}


		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			//Redraw the projectile with the color not influenced by light
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
		public override void AI()
		{
		for(int i = 0; i < 200; i++)
			{
				NPC target = Main.npc[i];

				{
					//Get the shoot trajectory from the projectile and target
					float shootToX = target.position.X + (float)target.width * 0.5f - projectile.Center.X;
					float shootToY = target.position.Y - projectile.Center.Y;
					float distance = (float)System.Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));

					//If the distance between the live targeted npc and the projectile is less than 480 pixels
					if(distance < 120f && !target.friendly && target.active)
						{
							//Divide the factor, 3f, which is the desired velocity
							distance = 3f / distance;
   
               //Multiply the distance by a multiplier if you wish the projectile to have go faster
               shootToX *= distance * 5;
               shootToY *= distance * 5;

               //Set the velocities to the shoot values
               projectile.velocity.X = shootToX;
               projectile.velocity.Y = shootToY;
					}
				}
			}
		}
	}
}
