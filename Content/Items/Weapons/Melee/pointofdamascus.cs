using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Projectiles.Melee;

namespace zeffmod.Content.Items.Weapons.Melee
{
    public class pointofdamascus : ModItem
    {
        public override string Texture => "zeffmod/Assets/Items/Weapons/Melee/" + this.Name;
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.damage = 32;
            Item.DamageType = DamageClass.Melee;
            Item.width = 56;
            Item.height = 128;
            Item.useTime = 10;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.knockBack = 10;
            Item.value = 1;
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.maxStack = 1;
            Item.shootSpeed = 2;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<pointofdamascusproj>();
        }
    }
}
