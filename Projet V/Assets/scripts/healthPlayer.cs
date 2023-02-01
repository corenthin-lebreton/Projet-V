using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPlayer : MonoBehaviour
{

    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("WeshwEhsg");

    }

   public void takeDamage(float amount)
   {
        currentHealth -= amount;

        if(currentHealth <= 0){
            Debug.Log("tu es mort");
        }
   }
}
