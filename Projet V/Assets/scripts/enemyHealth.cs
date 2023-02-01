using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    [SerializeField] private float health = 50;
    // Start is called before the first frame update
    
    public void takeDamage(float amount, GameObject bodyPartHit)
    {
        float totalDamage = 0;
    
        switch(bodyPartHit.tag)
        {
            case "Untagged":
                totalDamage -= amount;
                break;
            case "Head":
                totalDamage -= amount * 5f;
                break;
            default:
                totalDamage -= amount;
                break;
        }


        health -= amount;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
