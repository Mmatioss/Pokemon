using System.Collections;
using UnityEngine;
using System.Linq;
using TMPro;


public class PokemonData : MonoBehaviour
{
    public string namePoke = "Gardevoir";
    public int lifeStart = 68;
    private int currentLife;
    public int attack = 65;
    public int defense = 65;
    public int specialAttack = 125;
    public int specialDefense = 115;
    private int statsPoints;
    public float weight = 48.4f;
    public float height = 1.6f;
    public int speed = 80;
    public enum allTypes {
        Normal,
        Fire,
        Water,
        Electric,
        Grass,
        Ice,
        Fighting,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dragon,
        Dark,
        Steel,
        Fairy
    
    }
    public string[] type = {"Psychic", "Fairy"};
    public string[] weakness = {"Steel", "Poison","Ghost"};
    public string[] resistance = {"Psychic", "fighting"};
    public string[] immunity = {"Dragon"};
    public Sprite sprite;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI lifeText;
    public GameObject zoneSprite;

    // Start is called before the first frame update
    void Start()
    {
        InitCurrentLife();
        InitStatsPoints();
        DisplayName();
        DisplayLife();
        DisplayAttack();
        DisplayDefense();
        DisplaySpecialAttack();
        DisplaySpecialDefense();
        DisplayStatsPoints();
        DisplayWeight();
        DisplayHeight();
        DisplaySpeed();
        DisplayType();
        DisplayWeakness();
        DisplayResistance();
        DisplayImmunity();
        nameText.text = namePoke;
        lifeText.text = "PV: "+currentLife+"/"+lifeStart;
        zoneSprite.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
        StartCoroutine(Battle());
    }

    // Update is called once per frame
    void Update()
    {
        //CheckIfPokemonAlive();
    }

    void InitCurrentLife()
    {
        currentLife = lifeStart;
    }

    void InitStatsPoints()
    {
        statsPoints = lifeStart + attack + defense + specialAttack + specialDefense + speed;
    }

    int GetAttackDamage()
    {
        return attack;
    }


    void DisplayName()
    {
        Debug.Log("name: "+namePoke);
    }
    void DisplayLife()
    {
        Debug.Log("life: "+currentLife);
    }
    void DisplayAttack()
    {
        Debug.Log("attack: "+attack);
    }
    void DisplayDefense()
    {
        Debug.Log("defense: "+defense);
    }
    void DisplaySpecialAttack()
    {
        Debug.Log("special attack: "+specialAttack);
    }
    void DisplaySpecialDefense()
    {
        Debug.Log("special defense"+specialDefense);
    }
    void DisplayStatsPoints()
    {
        Debug.Log("stats points: "+statsPoints);
    }
    void DisplayWeight()
    {
        Debug.Log("weight: "+weight);
    }
    void DisplayHeight()
    {
        Debug.Log("height: "+height);
    }
    void DisplaySpeed()
    {
        Debug.Log("speed: "+speed);
    }
    void DisplayType()
    {
        foreach (string t in type)
        {
            Debug.Log("type: "+t);
        }
    }
    void DisplayWeakness()
    {
        foreach (string w in weakness)
        {
            Debug.Log("weakness: "+w);
        }
    }
    void DisplayResistance()
    {
        foreach (string r in resistance)
        {
            Debug.Log("resistance: "+r);
        }
    }
    void DisplayImmunity()
    {
        foreach (string i in immunity)
        {
            Debug.Log("immunity: "+i);
        }
    }

    void TakeDamage(int damage, string type)
    {
        if (weakness.Contains(type))
        {
            currentLife -= damage * 2;
            Debug.Log("dégat prit (faiblesse): "+damage*2);
        }
        else if (resistance.Contains(type))
        {
            currentLife -= damage / 2;
            Debug.Log("dégat prit (résistance): "+damage/2);
        }
        else if (immunity.Contains(type))
        {
            currentLife -= 0;
            Debug.Log("dégat prit: 0 (immunisé)");
        }
        else
        {
            currentLife -= damage;
            Debug.Log("dégat prit: "+damage);
        }
        if (currentLife <= 0)
            {
                currentLife = 0;
            }
        Debug.Log("current life after attack: "+currentLife+" type: "+type);
    }

    void CheckIfPokemonAlive()
    {
        if (currentLife <= 0)
        {
            Debug.Log("Pokemon is dead");
        }
        else{
            Debug.Log("Pokemon is alive");
        }
    }

    IEnumerator Battle()
    {
        while (currentLife > 0)
        {
            yield return new WaitForSeconds(2.5f);
            var typeAttack = (allTypes)Random.Range(0,18);
            TakeDamage(Random.Range(5,15), typeAttack.ToString());
            lifeText.text = "PV: "+currentLife+"/"+lifeStart;
            CheckIfPokemonAlive();
        }

    }

}
