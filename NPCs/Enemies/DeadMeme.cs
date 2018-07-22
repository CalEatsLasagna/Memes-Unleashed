using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.NPCs.Enemies
{
	public class DeadMeme : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dead Meme");
		}

		public override void SetDefaults()
		{
			npc.width = 95;
			npc.height = 85;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 74;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/TongueClick");
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 1.7f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{

		}
	}
}
