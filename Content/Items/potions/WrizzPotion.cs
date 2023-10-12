using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Buffs;
using zeffmod.Content.Items.Materials;

namespace zeffmod.Content.Items.potions
{
    public class WrizzPotion : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/potions/" + this.Name;
            }
        }
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 31;
        }
        public override void SetDefaults()
        {
            base.Item.width = 28;
            base.Item.height = 18;
            base.Item.useTurn = true;
            base.Item.maxStack = 1;
            base.Item.value = Item.buyPrice(0, 0, 20, 0);
            base.Item.rare = ItemRarityID.Master;
            base.Item.useAnimation = 17;
            base.Item.useTime = 5400;
            base.Item.useStyle = 9;
            base.Item.useAnimation = 600;
            base.Item.UseSound = new SoundStyle?(SoundID.Item3);
            base.Item.consumable = true;
            base.Item.buffType = ModContent.BuffType<WRizz>();
            base.Item.buffTime = 4200;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ModContent.ItemType<pureWrizz>(), 1);
            recipe.AddCustomShimmerResult(ItemID.PoopBlock, 1);
            recipe.Register();
        }
    }
}
