using Terraria;
using Terraria.ModLoader;

namespace MemesUnleashed.Buffs
{
	public class StaticAlly : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Static Ally");
			Description.SetDefault("This... thing will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}