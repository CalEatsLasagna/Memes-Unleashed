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
	public class GiantGrasshopper : ModNPC{
	int timer = 0;
	
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Grasshopper");
			NPCID.Sets.MustAlwaysDraw[npc.type] = true;
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 1;
			npc.lifeMax = 2200;
			npc.damage = 20;
			npc.defense = 6;
			npc.knockBackResist = 0f;
			npc.dontTakeDamage = false;
			npc.width = 264;
			npc.height = 160;
			npc.value = Item.buyPrice(0, 3, 0, 0);
			npc.npcSlots = 50f;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = false;
			npc.noTileCollide = false;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = null;
			npc.alpha = 0;
			for (int k = 0; k < npc.buffImmune.Length; k++)
			{
				npc.buffImmune[k] = true;
			}
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Throwdown!");
		}
		public override void BossLoot(ref string name, ref int potionType)
		{
			potionType = ItemID.LesserHealingPotion;
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HopperBlade"));
		}
		public override void AI()
		{
		timer++;
		if (timer % 60 == 0)
		NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("AngryGrasshopper"));
		}
	}
}
