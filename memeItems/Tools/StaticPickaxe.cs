using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MemesUnleashed.memeItems.Tools
{
	public class StaticPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Not very tough, but it gets the job done.");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 9;
			item.useAnimation = 9;
			item.pick = 41;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CompressedStatic", 10);
			recipe.AddTile(null, "Compressor");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Static"));
			}
		}
	}
}