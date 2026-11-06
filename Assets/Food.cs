using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Food1
{
    [SerializeField] GameObject FoodPrefab;

    public override void SetFoodPrefab(GameObject gb)
    {
        FoodPrefab = gb;
    }


    public override GameObject GetFoodPrefab()
    {
        return FoodPrefab;
    }
}