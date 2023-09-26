using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCoinScript : MonoBehaviour
{
    public GameObject theCoin;
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(theCoin);
            Vector3 randomPosition = new Vector3(Random.Range(510, 520), 2, Random.Range(420, 410));
            Instantiate(theCoin, randomPosition, Quaternion.identity);
        }
    }
}