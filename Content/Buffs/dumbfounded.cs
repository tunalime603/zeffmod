using System;
using Terraria;
using Terraria.ModLoader;

namespace zeffmod.Content.Buffs
{
    public class dumbfounded : ModBuff
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Buffs/" + this.Name;
            }
        }
        public override void SetStaticDefaults()
        {
            Main.debuff[base.Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.immuneTime = 0;
        }
    }
}
