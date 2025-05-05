using UnityEngine;

public class MusicBehavier : MonoBehaviour
{

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
