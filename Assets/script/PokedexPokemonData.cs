using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Pokemon")]
public class PokedexPokemonData : ScriptableObject
{
    public string nationalId;
    public string pokeName;
    public string description;
    public Sprite sprite2D;
    public Sprite sprite3D;
    public AnimatorController spriteAnimation;
    public float height;
    public float weight;
    public string[] types;
    public  int hp;
    public int attack;
    public int defense;
    public int specialAttack;
    public int specialDefense;
    public int speed;
    public int total;

}
