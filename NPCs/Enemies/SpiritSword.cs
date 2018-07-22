using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.NPCs.Enemies
{
	public class SpiritSword : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit Sword");
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 33;
			npc.damage = 20;
			npc.defense = 6;
			npc.lifeMax = 71;
			npc.noGravity = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCHit1;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 56;
			aiType = NPCID.DemonEye;
		}
	}
}
