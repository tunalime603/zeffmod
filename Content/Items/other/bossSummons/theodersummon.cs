using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using zeffmod.Content.Items.tiles;

namespace zeffmod.Content.Items.other.bossSummons
{
    public class theodersummon : ModItem
    {
        public override string Texture => "zeffmod/Assets/Items/other/bossSummons/" + this.Name;
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
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
        public override bool CanUseItem(Player player)
        {
            // "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
            return player.ZoneForest;
        }
    }
}
