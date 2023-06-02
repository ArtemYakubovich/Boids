using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonolithicEnemyController : MonoBehaviour
{
    public List<GameObject> enemies;
    public float speed = 10f;

    private void Update()
    {
        Vector3 tempPos;

        foreach (GameObject enemy in enemies)
        {
            tempPos = enemy.transform.position;

            switch (enemy.name)
            {
                case "EnemyGO":
                    tempPos.y -= speed * Time.deltaTime;
                    break;
                    case  "EnemyZigGO":
                    tempPos.x = 4 * Mathf.Sin(Time.time * Mathf.PI * 2);
                    tempPos.y -= speed * Time.deltaTime;
                    break;
                    case  "EnemyZigGOGO":
                        tempPos.y += speed * Time.deltaTime;
                    break;
            }

            enemy.transform.position = tempPos;
        }
    }
}
