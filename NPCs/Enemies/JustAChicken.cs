using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.NPCs.Enemies
{
	public class JustAChicken : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Just A Chicken");
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 33;
			npc.damage = 0;
			npc.defense = 6;
			npc.lifeMax = 10;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCHit1;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 0;
			aiType = NPCID.DemonEye;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 1.5f;
		}
		
		public override void NPCLoot()
		{
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		}
	}
}
