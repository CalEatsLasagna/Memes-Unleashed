using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class DietHopperBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diet Hopper Blade");
			Tooltip.SetDefault("The original form could probably be used for better stuff but hey, whatever floats you boat.");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 96;
			item.height = 96;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}
