using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Tools
{
	public class MagmiumPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's a pretty spicy boi.");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.pick = 56;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "MagmiumCrystal", 10);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("MagmaDust"));
			}
		}
	}
}