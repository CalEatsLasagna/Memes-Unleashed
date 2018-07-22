using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.NPCs.Enemies
{
	public class greenbean : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wild Bean");
		}

		public override void SetDefaults()
		{
			npc.width = 91;
			npc.height = 240;
			npc.damage = 12;
			npc.defense = 6;
			npc.lifeMax = 84;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/TongueClick");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/TongueClick");
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 1.3f;
		}
	}
}
