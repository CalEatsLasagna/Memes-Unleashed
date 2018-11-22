using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MemesUnleashed.NPCs.Enemies
{
	public class AngryChicken : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Angry Chicken");
		}

		public override void SetDefaults()
		{
			npc.width = 29;
			npc.height = 19;
			npc.damage = 14;
			npc.defense = 7;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCHit1;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Unicorn;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.4f;
		}
		
		//--------------i am a terrible person-------------//
		public override void NPCLoot()
		{
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		Item.NewItem(npc.getRect(), mod.ItemType("Egg"));
		}
	}
}
