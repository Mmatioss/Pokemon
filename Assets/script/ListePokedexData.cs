using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ListePokedexData : MonoBehaviour
{
    public List<PokedexPokemonData> ListPokedexPokemonData;
    public GameObject pokedexPokemonPrefab;

    void Start()
    {
        foreach (PokedexPokemonData pokemon in ListPokedexPokemonData)
        {
            GameObject newPokemon = Instantiate(pokedexPokemonPrefab, transform);
            newPokemon.GetComponent<ChangementInfoTop>().pokemonData = pokemon;
            GameObject spritePokemon2D = newPokemon.transform.GetChild(0).gameObject;
            GameObject iDPokemon = newPokemon.transform.GetChild(1).gameObject;
            spritePokemon2D.GetComponent<UnityEngine.UI.Image>().sprite = pokemon.sprite2D;
            iDPokemon.GetComponent<TextMeshProUGUI>().text = pokemon.nationalId;
            newPokemon.transform.SetParent(transform, false);
        }
    }
}
