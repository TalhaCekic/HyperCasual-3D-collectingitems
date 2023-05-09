using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSpawner : MonoBehaviour
{
    [SerializeField] GameObject item;

    public void oneTH()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-50, 50), 0, Random.Range(-30, -150));
        Instantiate(item, randomSpawnPosition, Quaternion.identity);
        
    }
    public void twoTH()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(30, 150), 0, Random.Range(-150, 150));
        Instantiate(item, randomSpawnPosition, Quaternion.identity);

    }
    public void threeTH()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-150, 150), 0, Random.Range(30, 150));
        Instantiate(item, randomSpawnPosition, Quaternion.identity);

    }
    public void fourTH()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-50, -150), 0, Random.Range(-150, 150));
        Instantiate(item, randomSpawnPosition, Quaternion.identity);
    }



}
