using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Hyperionandmaybeotherstuff.Items.armor.Mercenary_armor
{
	[AutoloadEquip(EquipType.Body)]
	public class Mercenary_Breastplate : ModItem
	{
		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.defense = 3;
		}
		/*public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EquipMaterial>(), 60);
			recipe.AddTile(ModContent.TileType<ExampleWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}