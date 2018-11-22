using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MemesUnleashed.memeItems.Weapons
{
	public class VenomDestroyerMagic : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Venom Destroyer");			

		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/ElectroLaser");
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("VenomLaser");
			item.shootSpeed = 20f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(19));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "VenomBlaster");
			recipe.AddIngredient(null, "NullSingularity", 5);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(null, "VenomBlasterMagic");
			recipe3.AddIngredient(null, "NullSingularity", 5);
			recipe3.AddIngredient(ItemID.SoulofNight, 10);
			recipe3.AddTile(TileID.Anvils);
			recipe3.SetResult(this);
			recipe3.AddRecipe();
		
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(null, "VenomDestroyer");
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}