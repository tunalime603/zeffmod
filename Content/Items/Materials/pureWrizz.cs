using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Content.Items.Materials
{
    public class pureWrizz : ModItem
    {
        public override string Texture
        {
            get
            {
                return "zeffmod/Assets/Items/Materials/" + this.Name;
            }
        }
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.ItemNoGravity[base.Type] = true;
        }
        public override void SetDefaults()
        {
            base.Item.width = 44;
            base.Item.height = 44;
            base.Item.value = 1;
            base.Item.rare = 2;
        }
    }
}
