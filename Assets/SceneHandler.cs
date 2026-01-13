using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    
    public void RestartGame() 
    {

        print("The game has reset");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }


}
