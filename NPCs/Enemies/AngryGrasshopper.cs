using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.NPCs.Enemies
{
	public class AngryGrasshopper : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Angry Grasshopper");
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 33;
			npc.damage = 12;
			npc.defense = 3;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCHit1;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 1;
			aiType = NPCID.GreenSlime;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.6f;
		}
	}
}
