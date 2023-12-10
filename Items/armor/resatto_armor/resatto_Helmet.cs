using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Hyperionandmaybeotherstuff.Items.armor.resatto_armor
{
	[AutoloadEquip(EquipType.Head)]
	public class resatto_Helmet : ModItem
	{
		public override void SetStaticDefaults() {
			// ticksperframe, frameCount
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.defense = 1;
		}
	}
}