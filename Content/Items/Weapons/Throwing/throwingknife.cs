using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Projectiles.Throwing;

namespace zeffmod.Content.Items.Weapons.Throwing
{
    public class throwingknife : ModItem
    {
        public override string Texture => "zeffmod/Assets/Items/Weapons/Throwing/" + this.Name;
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[base.Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.damage = 52;
            Item.DamageType = DamageClass.Throwing;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 333;
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = false;
            Item.maxStack = 1;
            Item.accessory = false;
            Item.consumable = false;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<throwingknifeproj>();
            Item.noMelee = true;
            Item.shootSpeed = 10;
        }
    }
}
