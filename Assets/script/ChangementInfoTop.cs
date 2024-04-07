using UnityEngine;
using TMPro;

public class ChangementInfoTop : MonoBehaviour
{
    public GameObject zoneSpritePokemon2D;
    public GameObject zoneIDPokemon;
    public GameObject zoneNamePokemon;
    public GameObject zoneDescriptionPokemon;
    public GameObject zonePoid;
    public GameObject zoneTaille;
    public GameObject zoneType1;
    public GameObject zoneType2;

    public PokemonDataManager pokemonData;

    private pokemonData GetData(int id)
    {
        return pokemonData.data[id];
    }

    public void Changement()
    {

        // Change the name of the Pokemon
        //zoneNamePokemon.GetComponent<TextMeshProUGUI>().text = pokemonData.data.Info.pokeName;
        // Change the weight of the Pokemon
        //zonePoid.GetComponent<TextMeshProUGUI>().text = pokemonData.weight.ToString();
        // Change the height of the Pokemon
        //zoneTaille.GetComponent<TextMeshProUGUI>().text = pokemonData.height.ToString();
        // Change the type of the Pokemon
        // Change the sprite of the Pokemon
        //zoneSpritePokemon2D.GetComponent<UnityEngine.UI.Image>().sprite = pokemonData.sprite3D;
        //zoneSpritePokemon2D.GetComponent<Animator>().runtimeAnimatorController = pokemonData.spriteAnimation;
        // Change the description of the Pokemon
        //zoneDescriptionPokemon.GetComponent<TextMeshProUGUI>().text = pokemonData.description;
        //zoneIDPokemon.GetComponent<TextMeshProUGUI>().text = pokemonData.nationalId.ToString();

    }
    void Start()
    {
        this.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(Changement);
        Changement();
    }
    void Update()
    {
        zoneSpritePokemon2D.GetComponent<UnityEngine.UI.Image>().sprite = zoneSpritePokemon2D.GetComponent<SpriteRenderer>().sprite;

    }
}
