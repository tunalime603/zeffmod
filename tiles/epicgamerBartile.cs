using Terraria.ModLoader;
using zeffmod.Content.Items.tiles;

namespace zeffmod.tiles
{
    public class epicgamerBartile : ModTile
    {
        public override void SetStaticDefaults()
        {
            base.DustType = 187;
            base.RegisterItemDrop(ModContent.ItemType<epicgamerBar>());
        }
    }
}
