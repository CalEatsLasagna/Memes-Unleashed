using Terraria;
using Terraria.ModLoader;

namespace MemesUnleashed.Buffs
{
	public class ThunderOrb : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Thunder Orb");
			Description.SetDefault("Laser go pew");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			MemePlayer modPlayer = player.GetModPlayer<MemePlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("ThunderOrb")] > 0)
			{
				modPlayer.thunderMinion = true;
			}
			if (!modPlayer.thunderMinion)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}