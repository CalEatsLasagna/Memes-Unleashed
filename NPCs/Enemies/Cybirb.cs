using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.NPCs.Enemies
{
	public class Cybirb : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cybirb");
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 33;
			npc.damage = 16;
			npc.defense = 6;
			npc.lifeMax = 68;
			npc.noGravity = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 5;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 1.5f;
		}
		
		public override void NPCLoot()
		{
		Item.NewItem(npc.getRect(), mod.ItemType("NullSingularity"));
		}
	}
}
