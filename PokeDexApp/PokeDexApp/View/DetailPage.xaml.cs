using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PokedexNET;
namespace PokeDexApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
        private Pokemon pokemon;
        public DetailPage (Pokemon _pokemon)
		{
			InitializeComponent ();
            var pokedex = new Pokedex();
            var info = pokedex.GetPokemonInfo(_pokemon);

            pokemon = _pokemon;
            txtNameDetail.Text = info.Names.En;
            txtHeightDetail.Text = info.HeightEu;
            txtWeightDetail.Text = info.WeightEu;
            txtPokemonDetail.Text = info.PokedexEntries.OmegaRuby.En;
            imgImageDetail.Source = ImageSource.FromUri(new Uri(_pokemon.ImageUrl));
        }
        private void ButtonWeb_Clicked(object sender, EventArgs e)
        {
            var url = "http://www.pokemon.com/us/pokedex/" + pokemon.Slug;
            Device.OpenUri(new Uri(url));
        }
    }
}