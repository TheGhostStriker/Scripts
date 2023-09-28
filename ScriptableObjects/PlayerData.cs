using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public  float defaultHealth = 100;
    public  float defaultEnergy = 100;
    public float health;
    public float energy;

    public void ResetData()
    {
        health = defaultHealth;
        energy = defaultEnergy;
    }
}
