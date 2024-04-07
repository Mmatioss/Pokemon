using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " Attaque ", menuName = "Attaque data/PokedexAttaqueData", order = 1)]
public class AttackDataBase : ScriptableObject
{
    public List<AttackData> data = new();

    public void CreateAttack(){
        data.Add(new AttackData());
    }
}
