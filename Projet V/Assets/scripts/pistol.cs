using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistol : MonoBehaviour
{
    [SerializeField] GameObject firepoint;
    [SerializeField] float pistolDamage = 15;

    public void fire()
    {
        RaycastHit hitInfo;

        bool hit = Physics.Raycast(firepoint.transform.position, firepoint.transform.forward, out hitInfo);

        if(hit && hitInfo.collider.tag == "destructible")
        {
            Rigidbody rb = hitInfo.transform.gameObject.GetComponent<Rigidbody>();
            rb.AddForceAtPosition(firepoint.transform.forward * 10, hitInfo.point, ForceMode.Impulse);
        }

        if(hit && hitInfo.transform.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy");
            enemyHealth eh = hitInfo.transform.gameObject.GetComponent<enemyHealth>();
            eh.takeDamage(pistolDamage, hitInfo.collider.gameObject);
        }

    }
}
