using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using zeffmod.Projectiles;
using System;

namespace zeffmod.Content.Items.Weapons.Throwing
{
    public class stickwmagic : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/Weapons/Throwing/" + this.Name;
            }
        }
        Random rnd = new Random();
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[base.Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.damage = 1;
            Item.DamageType = DamageClass.Throwing;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 1;
            Item.useAnimation = 20;
            Item.useStyle = rnd.Next(1, 14);
            Item.knockBack = 600000;
            Item.sellPrice(0, 0, 0, 1);
            Item.rare = 0;
            Item.UseSound = SoundID.DSTMaleHurt;
            Item.autoReuse = true;
            Item.maxStack = 9999;
            Item.accessory = true;
            Item.consumable = true;
            Item.noUseGraphic = false;
            Item.shoot = ModContent.ProjectileType<throwingstick>();
            Item.noMelee = true;
            Item.shootSpeed = 0;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.Trees);
            recipe.Register();
        }
    }
}