using PokemoReviewApp.Models;

namespace PokemoReviewApp.Interfaces
{
    public interface IPokemonRepository 
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);

        decimal GetPokemonRating(int pokeId);

        bool PokemonExist(int pokeId);

        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        bool UpdatePokemon(int pokeId, int categoryId, Pokemon pokemon);

        bool DeletePokemon(Pokemon pokemon);

        bool Save();
    }
}
