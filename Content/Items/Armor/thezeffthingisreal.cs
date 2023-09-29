using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace zeffmod.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class thezeffthingisreal : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.defense = 69;
        }
        public override void UpdateArmorSet(Player player)
        {
            if (player.dead == true)
            {
                player.dangerSense = true;
            }
        }
    }
}