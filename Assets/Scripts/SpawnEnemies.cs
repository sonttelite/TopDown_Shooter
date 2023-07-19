using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab của quái
    public float spawnInterval = 1f; // Thời gian giữa mỗi lần spawn
    public float spawnRadius = 5f; // Bán kính khu vực spawn
    public Transform mainCharacter; // Transform của main character
    //public float moveSpeed = 3f; // Tốc độ di chuyển của quái

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }


    void SpawnEnemy()
    {
        Vector3 spawnPosition = mainCharacter.position + Random.insideUnitSphere * spawnRadius;
        //Quaternion spawnRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, mainCharacter.rotation);
    }

    
}
 