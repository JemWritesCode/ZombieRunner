using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float hitPoints = 100f;


    public void playerTakeDamage(float damage)
    {
        hitPoints -= damage;
        if(hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }

}
