using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] furniturePrefabs; // oyun icindeki prefablari saklar Inseptor panelinden yeni objeler eklenebilir

    // Start is called before the first frame update
    void Awake()
    {
        FurnitureGenerator();
        StartCoroutine(FurnitureSpawner());
    }

    // belirli surede tekrar spawn olabilmesi icin cagirilir
    IEnumerator FurnitureSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            FurnitureGenerator();
        }
    }

    // random obje generate eder
    void FurnitureGenerator()
    {
        int randIdx;
        randIdx = Random.Range(0, furniturePrefabs.Length);
        Instantiate(furniturePrefabs[randIdx], transform.position, Quaternion.identity);
    }
}
