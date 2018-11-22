using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace MemesUnleashed
{
    public class MemePlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool treeMinion = false;
		public bool thunderMinion = false;
        public static bool hasProjectile;
 
        public override void ResetEffects()
        {
			treeMinion = false;
			thunderMinion = false;
		}
    }
}