using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Items.tiles;

namespace zeffmod.Content.Items.Materials
{
    public class epicgamerore : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/Materials/" + Name;
            }
        }
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }
        public override void SetDefaults()
        {
            Item.createTile = ModContent.TileType<epicgamerBartile>();
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.width = 32;
            Item.height = 26;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.LightRed;
            Item.value = Item.sellPrice(0, 1, 20, 0);
        }
    }
}
