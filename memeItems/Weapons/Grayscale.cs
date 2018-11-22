using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Weapons
{
	public class Grayscale : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grayscale");
			Tooltip.SetDefault("It seems to change its shade periodically.");
		}
		public override void SetDefaults()
		{
			item.damage = 18;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Grayscale");
			item.autoReuse = true;
		}
	}
}
