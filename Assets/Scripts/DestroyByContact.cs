using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject PlayerExplosion;
    public GameObject EnemyExplosion;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Boundry"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            if (other.CompareTag("Player"))
                Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
             else
                Instantiate(EnemyExplosion, other.transform.position, other.transform.rotation);

            Instantiate(explosion, transform.position, transform.rotation);
        }
   
        
    }
}
