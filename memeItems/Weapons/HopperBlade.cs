using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class HopperBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hopper Blade");
			Tooltip.SetDefault("You can use it to cut stuff. Like grass.");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
