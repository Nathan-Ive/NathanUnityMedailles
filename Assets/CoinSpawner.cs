using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField] private GameObject _spawnCoins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(_spawnCoins, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
