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
	public class BladeDemon : ModNPC{
	int timer = 0;
	
		private const int size = 128;
		private const int particleSize = 10;
		private const int frameSize = size;
		public static readonly int arenaWidth = (int)(1f * NPC.sWidth);
		public static readonly int arenaHeight = (int)(1f * NPC.sHeight);

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blade Demon");
			NPCID.Sets.MustAlwaysDraw[npc.type] = true;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 5;
			npc.lifeMax = 4500;
			npc.damage = 25;
			npc.defense = 11;
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
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Throwdown!");
		}
				public override void AI()
		{	
		timer++;
		if (timer % 80 == 0)
		NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("SpiritSword"));
		}
		
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax / Main.expertLife * 1f * bossLifeScale);
			npc.defense = 12;
		}
				public override void BossLoot(ref string name, ref int potionType)
		{
			potionType = ItemID.HealingPotion;
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SinisterDuality"));
		}
	}
}