using Terraria.ModLoader;
using zeffmod.Content.Items.Materials;

namespace zeffmod.Content.Items.tiles
{
    public class epicgamerBartile : ModTile
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
            DustType = 187;
            RegisterItemDrop(ModContent.ItemType<epicgamerBar>());
        }
    }
}
