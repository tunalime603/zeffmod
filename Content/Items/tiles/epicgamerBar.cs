using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.tiles;

namespace zeffmod.Content.Items.tiles
{
    public class epicgamerBar : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/tiles/" + this.Name;
            }
        }
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }
        public override void SetDefaults()
        {
            base.Item.createTile = ModContent.TileType<epicgamerBartile>();
            base.Item.useStyle = ItemUseStyleID.Swing;
            base.Item.useTurn = true;
            base.Item.useAnimation = 15;
            base.Item.useTime = 10;
            base.Item.autoReuse = true;
            base.Item.consumable = true;
            base.Item.width = 32;
            base.Item.height = 26;
            base.Item.maxStack = 9999;
            base.Item.rare = ItemRarityID.LightRed;
            base.Item.value = Item.sellPrice(0, 1, 20, 0);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10000);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.Register();
        }
    }
}
