using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAttack : MonoBehaviour
{

    [SerializeField] private float damage = 30f;
   private void OnTriggerEnter(Collider player)
   {
        if (player.tag == "Player")
        {
            Debug.Log("Wesh");
            player.GetComponent<healthPlayer>().takeDamage(damage);


        }
   }

    
}
