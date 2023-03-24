using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    void Start()
    {
        Vector3 position = transform.position;
        var spawnedEnemy = Instantiate(Enemy, position, Quaternion.identity);
        spawnedEnemy.name = "Enemy";
    }
}
