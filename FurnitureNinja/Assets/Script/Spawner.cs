using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] furniturePrefabs; // oyun icindeki prefablari saklar Inseptor panelinden yeni objeler eklenebilir
    public float waitSecond;

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
            yield return new WaitForSeconds(waitSecond);
            FurnitureGenerator();
        }
    }

    // random obje generate eder
    void FurnitureGenerator()
    {
        int randIdx;
        UpdatePosition();
        randIdx = Random.Range(0, furniturePrefabs.Length);
        Instantiate(furniturePrefabs[randIdx], transform.position, Quaternion.identity);
    }

    void UpdatePosition()
    {
        transform.position = new Vector3(Random.Range(-1, 1), transform.position.y, transform.position.z);
    }
}
