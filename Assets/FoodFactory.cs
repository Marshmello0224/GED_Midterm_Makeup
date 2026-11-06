using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFactory : MonoBehaviour
{
    [SerializeField] GameObject FoodPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject food = Instantiate(FoodPrefab, new Vector3(Random.Range(-6f, 6f), Random.Range(-4f, 4f), 0), Quaternion.identity);
            Destroy(food, 5f);
        }
    }
}

