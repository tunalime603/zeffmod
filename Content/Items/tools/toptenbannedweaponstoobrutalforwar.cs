using System;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Content.Items.tools
{
    public class toptenbannedweaponstoobrutalforwar : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/tools/" + this.Name;
            }
        }
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            base.Item.damage = 15;
            base.Item.knockBack = 6f;
            base.Item.useTime = 11;
            base.Item.useAnimation = 29;
            base.Item.hammer = 60;
            base.Item.axe = 60;
            base.Item.pick = 500;
            base.Item.DamageType = DamageClass.Melee;
            base.Item.width = 44;
            base.Item.height = 44;
            base.Item.useTurn = true;
            base.Item.useStyle = 1;
            base.Item.value = 1;
            base.Item.rare = 2;
            base.Item.UseSound = new SoundStyle?(SoundID.Item1);
            base.Item.autoReuse = true;
        }
    }
}
