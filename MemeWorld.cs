using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace MemesUnleashed
{
	public class MemeWorld : ModWorld
	{
		private const int saveVersion = 0;
		public static bool downedBladeDemon = false;
		public static bool downedGiantGrasshopper = false;
		public static int memeTiles = 0;

		public override void Initialize()
		{
			downedBladeDemon = false;
			downedGiantGrasshopper = false;
		}

		public override TagCompound Save()
		{
			var downed = new List<string>();
			if (downedBladeDemon) downed.Add("BladeDemon");
			if (downedGiantGrasshopper) downed.Add("GiantGrasshopper");

			return new TagCompound {
				{"downed", downed}
			};
		}

		public override void Load(TagCompound tag)
		{
			var downed = tag.GetList<string>("downed");
			downedBladeDemon = downed.Contains("BladeDemon");
			downedGiantGrasshopper = downed.Contains("GiantGrasshopper");
		}

		public override void LoadLegacy(BinaryReader reader)
		{
			int loadVersion = reader.ReadInt32();
			if (loadVersion == 0)
			{
				BitsByte flags = reader.ReadByte();
				downedBladeDemon = flags[0];
				downedGiantGrasshopper = flags[1];
			}
			else
			{
				ErrorLogger.Log("MemesUnleashed: Unknown loadVersion: " + loadVersion);
			}
		}

		public override void NetSend(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = downedBladeDemon;
			flags[1] = downedGiantGrasshopper;
			writer.Write(flags);

			/*
			Remember that Bytes/BitsByte only have 8 entries. If you have more than 8 flags you want to sync, use multiple BitsByte:

				This is wrong:
			flags[8] = downed9thBoss; // an index of 8 is nonsense. 

				This is correct:
			flags[7] = downed8thBoss;
			writer.Write(flags);
			BitsByte flags2 = new BitsByte(); // create another BitsByte
			flags2[0] = downed9thBoss; // start again from 0
			// up to 7 more flags here
			writer.Write(flags2); // write this byte
			*/

			//If you prefer, you can use the BitsByte constructor approach as well.
			//writer.Write(saveVersion);
			//BitsByte flags = new BitsByte(downedBladeDemon, downedGiantGrasshopper);
			//writer.Write(flags);

			// This is another way to do the same thing, but with bitmasks and the bitwise OR assignment operator (the |=)
			// Note that 1 and 2 here are bit masks. The next values in the pattern are 4,8,16,32,64,128. If you require more than 8 flags, make another byte.
			//writer.Write(saveVersion);
			//byte flags = 0;
			//if (downedBladeDemon)
			//{
			//	flags |= 1;
			//}
			//if (downedGiantGrasshopper)
			//{
			//	flags |= 2;
			//}
			//writer.Write(flags);
		}

		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			downedBladeDemon = flags[0];
			downedGiantGrasshopper = flags[1];
			// As mentioned in NetSend, BitBytes can contain 8 values. If you have more, be sure to read the additional data:
			// BitsByte flags2 = reader.ReadByte();
			// downed9thBoss = flags[0];
		}

		// We use this hook to add 3 steps to world generation at various points. 
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			// Because world generation is like layering several images ontop of each other, we need to do some steps between the original world generation steps.

			// The first step is an Ore. Most vanilla ores are generated in a step called "Shinies", so for maximum compatibility, we will also do this.
			// First, we find out which step "Shinies" is.
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				// Next, we insert our step directly after the original "Shinies" step. 
				// ExampleModOres is a method seen below.
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Memes Unleashed Ores", MemesUnleashedOres));
			}
		}

		private void MemesUnleashedOres(GenerationProgress progress)
		{
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes. 
			progress.Message = "Memeing the World";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-04); k++)
			{
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coorinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("MagmiumOre"), false, 0f, 0f, false, true);
				WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(3, 6), mod.TileType("StaticOre"), false, 0f, 0f, false, true);

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				// Tile tile = Framing.GetTileSafely(x, y);
				// if (tile.active() && tile.type == TileID.SnowBlock)
				// {
				// 	WorldGen.TileRunner(.....);
				// }
			}
		}

		// We can use PostWorldGen for world generation tasks that don't need to happen between vanilla world generation steps.
		public override void PostWorldGen()
		{
			// This is simply generating a line of Chlorophyte halfway down the world.
			//for (int i = 0; i < Main.maxTilesX; i++)
			//{
			//	Main.tile[i, Main.maxTilesY / 2].type = TileID.Chlorophyte;
			//}

			// Here we spawn Example Person just like the Guide.
			int num = NPC.NewNPC((Main.spawnTileX + 5) * 16, Main.spawnTileY * 16, mod.NPCType("PepsEye"), 0, 0f, 0f, 0f, 0f, 255);
			Main.npc[num].homeTileX = Main.spawnTileX + 5;
			Main.npc[num].homeTileY = Main.spawnTileY;
			Main.npc[num].direction = 1;
			Main.npc[num].homeless = true;

			// Place some items in Ice Chests
			int[] itemsToPlaceInIceChests = new int[] { mod.ItemType("IceLauncher"), mod.ItemType("IceCube"), 50, ItemID.PinkJellyfishJar };
			int itemsToPlaceInIceChestsChoice = 0;
			for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
			{
				Chest chest = Main.chest[chestIndex];
				// If you look at the sprite for Chests by extracting Tiles_21.xnb, you'll see that the 12th chest is the Ice Chest. Since we are counting from 0, this is where 11 comes from. 36 comes from the width of each tile including padding. 
				if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 11 * 36)
				{
					for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
					{
						if (chest.item[inventoryIndex].type == 0)
						{
							chest.item[inventoryIndex].SetDefaults(itemsToPlaceInIceChests[itemsToPlaceInIceChestsChoice]);
							itemsToPlaceInIceChestsChoice = (itemsToPlaceInIceChestsChoice + 1) % itemsToPlaceInIceChests.Length;
							// Alternate approach: Random instead of cyclical: chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInIceChests));
							break;
						}
					}
				}
			}
		}

		public override void ResetNearbyTileEffects()
		{
			memeTiles = 0;
		}

		public override void TileCountsAvailable(int[] tileCounts)
		{
			memeTiles = tileCounts[mod.TileType("Shale")];
			}
		}
	}

