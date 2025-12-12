using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private float _speedIncrease;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    public float SpeedBoost() 
    {
        return _speedIncrease;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
