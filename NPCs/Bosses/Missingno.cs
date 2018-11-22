using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;
using MemesUnleashed.Projectiles;

namespace MemesUnleashed.NPCs.Bosses
{
	[AutoloadBossHead]
	public class Missingno : ModNPC
	{
		private const int particleSize = 10;
		public static readonly int arenaWidth = (int)(1f * NPC.sWidth);
		public static readonly int arenaHeight = (int)(1f * NPC.sHeight);

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Missingno");
			NPCID.Sets.MustAlwaysDraw[npc.type] = true;
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 56;
			npc.lifeMax = 9000;
			npc.damage = 40;
			npc.defense = 8;
			npc.knockBackResist = 0f;
			npc.dontTakeDamage = false;
			npc.width = 54;
			npc.height = 128;
			npc.value = Item.buyPrice(0, 7, 0, 0);
			npc.npcSlots = 50f;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = null;
			npc.alpha = 0;
			for (int k = 0; k < npc.buffImmune.Length; k++)
			{
				npc.buffImmune[k] = true;
			}
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Throwdown!");
		}
		        public override void AI()
        {

            if (Main.rand.Next(0, 8) == 0) Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, mod.DustType("Static"), 0f, 0f);
			if (Main.rand.Next(0, 12) == 0) Projectile.NewProjectile(npc.position.X, npc.position.Y, 0, 0, mod.ProjectileType("HostileStaticBall"), npc.damage, 3f, Main.myPlayer);
		}
			
		public override void BossLoot(ref string name, ref int potionType)
		{
			potionType = ItemID.HealingPotion;
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CharredMysteriousMatrix"));
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax / Main.expertLife * 1f * bossLifeScale);
			npc.defense = 9;
		}
	}
}
