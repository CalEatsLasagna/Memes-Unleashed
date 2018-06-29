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
			npc.width = 18;
			npc.height = 40;
			npc.damage = 10;
			npc.defense = 16;
			npc.lifeMax = 160;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/TongueClick");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Custom/TongueClick");
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 5.5f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
}
