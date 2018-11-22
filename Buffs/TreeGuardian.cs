using Terraria;
using Terraria.ModLoader;

namespace MemesUnleashed.Buffs
{
	public class TreeGuardian : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Tree Guardian");
			Description.SetDefault("*tree noises*");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			MemePlayer modPlayer = player.GetModPlayer<MemePlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("TreeGuardian")] > 0)
			{
				modPlayer.treeMinion = true;
			}
			if (!modPlayer.treeMinion)
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