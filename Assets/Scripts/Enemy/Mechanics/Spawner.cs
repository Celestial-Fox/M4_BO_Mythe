using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject[] hazards;

    [SerializeField] private float timeBtwSpawn;
    [SerializeField] public static int startTimeBtwSpawn = 5;



    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            //Spawn hazard
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];
            Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity, null);
            timeBtwSpawn = startTimeBtwSpawn;
        }
            timeBtwSpawn -= Time.deltaTime;
        
    }
}
