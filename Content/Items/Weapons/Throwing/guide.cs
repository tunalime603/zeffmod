using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using zeffmod.Content.Projectiles.Throwing;

namespace zeffmod.Content.Items.Weapons.Throwing
{
    public class guide : ModItem
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
            Item.useStyle = 5;
            Item.knockBack = 6;
            Item.sellPrice(3, 3, 3, 3);
            Item.rare = ItemRarityID.Gray;
            Item.UseSound = SoundID.Chat;
            Item.autoReuse = false;
            Item.maxStack = 1;
            Item.accessory = false;
            Item.consumable = false;
            Item.noUseGraphic = false;
            Item.shoot = ModContent.ProjectileType<guidepro>();
            Item.noMelee = true;
            Item.shootSpeed = 10;
        }
    }
}