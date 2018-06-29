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
	public class BladeDemon : ModNPC
	{
		private const int size = 240;
		private const int particleSize = 10;
		public static readonly int arenaWidth = (int)(2f * NPC.sWidth);
		public static readonly int arenaHeight = (int)(2f * NPC.sHeight);

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blade Demon");
			NPCID.Sets.MustAlwaysDraw[npc.type] = true;
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 5;
			npc.lifeMax = 4500;
			npc.damage = 25;
			npc.defense = 22;
			npc.knockBackResist = 0f;
			npc.dontTakeDamage = false;
			npc.width = size;
			npc.height = size;
			npc.value = Item.buyPrice(0, 5, 0, 0);
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
			music = MusicID.Boss1;
		}
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax / Main.expertLife * 1.0875f * bossLifeScale);
			npc.defense = 30;
		}
	}
}