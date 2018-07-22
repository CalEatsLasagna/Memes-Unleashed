using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	public class CharredMysteriousMatrix : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Completely destroyed.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = -12;
			
		}
	}
}