using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject Som;
    public GameObject bola;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Som.SetActive(false);
        bola.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
            Som.SetActive(true);
            bola.SetActive(true);

        }
    }
}
