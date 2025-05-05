using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMenager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     Invoke("TrocarDeCena", 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TrocarDeCena()
    {
        SceneManager.LoadScene(0);
    }
}
