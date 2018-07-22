using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.NPCs.Enemies
{
	public class SkidaddleSkidoodle : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skidaddle Skidoodle");
		}

		public override void SetDefaults()
		{
			npc.width = 200;
			npc.height = 200;
			npc.damage = 10;
			npc.defense = 6;
			npc.lifeMax = 82;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/TongueClick");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/TongueClick");
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 1.2f;
		}
	}
}
