using UnityEngine;

public class CoinValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private int _coinScore;
    void Start()
    {
        
    }
    public int GetScoreWorth()
    {
        return _coinScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
