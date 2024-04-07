using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " Pokemon ", menuName = "Pokemon data/PokedexPokemonData", order = 0)]
public class PokemonDataManager : ScriptableObject
{
    public List<pokemonData> data = new();

    public void CreateData(){
        data.Add(new pokemonData());
    }
}
