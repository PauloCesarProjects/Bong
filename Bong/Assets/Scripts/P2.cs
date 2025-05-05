using UnityEngine;

public class P2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5f;

        bool ycima = Input.GetKey(KeyCode.UpArrow);
        bool ybaixo = Input.GetKey(KeyCode.DownArrow);
        if (ycima) 
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (ybaixo)
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }
}
