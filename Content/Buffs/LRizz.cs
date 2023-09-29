using System;
using Terraria;
using Terraria.ModLoader;

namespace zeffmod.Content.Buffs
{
    public class LRizz : ModBuff
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
        public override void Update(Player Player, ref int buffIndex)
        {
            Player.statDefense -= 999999;
            Player.statLifeMax -= 5;
            Player.statLife = 5;
            Player.statManaMax -= 999999;
            Player.statManaMax2 -= 999999;
            Player.statMana -= 999999;
            Player.dpsDamage -= 9999999;
        }
    }
}
