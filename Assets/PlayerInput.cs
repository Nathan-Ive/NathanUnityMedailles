using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private string _coinTag = "Coin";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //transform.rotation = Quaternion.Euler(0, 0, 0);
        //transform.localScale = new Vector3(0,0,0);



        if (Input.GetKey(KeyCode.W)) {
            print("I pressed W!");
            transform.position += new Vector3(0, 1, 0) * (Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("I pressed A!");
            transform.position -= new Vector3(1, 0, 0) * (Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            print("I pressed S!");
            transform.position -= new Vector3(0, 1, 0) * (Time.deltaTime * _speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            print("I pressed D!");
            transform.position += new Vector3(1, 0, 0) * (Time.deltaTime * _speed);
        }




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.transform.position);
        if (collision.gameObject.CompareTag(_coinTag)) 
        {
            Destroy(collision.gameObject);
        
        }


    }

}
