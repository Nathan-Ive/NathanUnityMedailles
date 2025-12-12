using UnityEngine;
using System.Collections.Generic;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _coinObject;
    [SerializeField] private List<Transform> _coinSpawnLocations = new List<Transform>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
        foreach(Transform location in _coinSpawnLocations) 
        {
            Instantiate(_coinObject, location.position, location.rotation);




        }



    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
