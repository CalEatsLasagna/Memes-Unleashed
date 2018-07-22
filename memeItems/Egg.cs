using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems
{
	public class Egg : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Literally just takes up inventory space. Good job.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 0;
			item.rare = -1;
			}
		}
	}
