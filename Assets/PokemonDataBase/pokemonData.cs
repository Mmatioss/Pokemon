using UnityEngine;
using UnityEditor.Animations;
using System;
using System.Linq;
using Random = System.Random;
using System.Threading;
using JetBrains.Annotations;

[Serializable]
public class pokemonData
{
    [SerializeField]
    public Info info;
    [SerializeField]
    private Stats stats;
    private int currentHp;
    private int statsPoints;
    [SerializeField]
    private PokemonData[] PokemonOpponent;

    [Serializable]
    public struct Stats
    {
        public int hp;
        public int attack;
        public int defense;
        public int specialAttack;
        public int specialDefense;
        public int speed;
    }
    [Serializable]
    public struct Info
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
    public string[] faiblesse;
    public string[] resistance;
    }

    public void PokemonData(Info info, Stats stats)
    {
        this.info = info;
        this.stats = stats;
    }

    void start()
    {
        InitCurrentLife();
        InitStatsPoints();
        //DelayAttack();
    }

    void InitCurrentLife()
    {
        currentHp = stats.hp;
    }

    void InitStatsPoints()
    {
        statsPoints = stats.attack + stats.defense + stats.specialAttack + stats.specialDefense + stats.speed;
    }

    bool IsPokemonAlive()
    {
        return currentHp > 0;
    }

    void TakeDamage(int damage, string type)
    {
        if (info.faiblesse.Contains(type))
        {
            currentHp -= damage * 2;
            Debug.Log("dégat prit (faiblesse): "+damage*2);
        }
        else if (info.resistance.Contains(type))
        {
            currentHp -= damage / 2;
            Debug.Log("dégat prit (résistance): "+damage/2);
        }
        else
        {
            currentHp -= damage;
            Debug.Log("dégat prit: "+damage);
        }
    }

    /*void AttackOpponent()
    {
        if (IsPokemonAlive()==true && PokemonOpponent[0].IsPokemonAlive()==true)
        {
            PokemonOpponent[0].TakeDamage(stats.attack, info.types[0]);
        }else
        {
            Debug.Log("Le pokemon ne peut plus attaquer");
        }
    }*/

    Random rnd = new Random();
    /*void DelayAttack()
    {
        AttackOpponent();
        if (PokemonOpponent[0].IsPokemonAlive()==true)
        {
            int num = rnd.Next(1250,3100);
            Thread.Sleep(num);
        }
    }*/
}
