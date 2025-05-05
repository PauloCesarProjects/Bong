using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public TextMeshProUGUI pontuacao1;
    public TextMeshProUGUI pontuacao2;
    public TextMeshProUGUI vencedor;
    public Transform p1;
    public Transform p2;

    float speed = 5f;
    float diagonal = 0f;
    

    int pontos1 = 0;
    int pontos2 = 0;

    void Start()
    {

    }

    void Update()
    {
        VerificarPosicao();
        transform.Translate(new Vector2(speed * Time.deltaTime, diagonal * Time.deltaTime));
        Vencedor();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pontops1"))
        {
            pontuacao2.text = $"{++pontos2}";
            transform.position = new Vector3(0, 0, 0);
            speed = 5;
            diagonal = 0;
            p1.transform.position = new Vector3(-6, 0, 0);
            p2.transform.position = new Vector3(6, 0, 0);

        }
        else if (collision.gameObject.CompareTag("pontops2"))
        {
            pontuacao1.text = $"{++pontos1}";
            transform.position = new Vector3(0, 0, 0);
            speed = -5;
            diagonal = 0;
            p2.transform.position = new Vector3(6, 0, 0);
            p1.transform.position = new Vector3(-6, 0, 0);
        }
        else if (collision.gameObject.CompareTag("p1"))
        {
            diagonal = 5;
            speed = 5f;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
        else if (collision.gameObject.CompareTag("p2"))
        {
            diagonal = -5;
            speed = -5;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
        
    }

    public void Vencedor()
    {
        if (pontos1 > 10)
        {
            vencedor.text = "Jogador 2 Venceu!";
            Invoke("Reiniciar", 5);
        }
        if (pontos2 > 10)
        {
            vencedor.text = "Jogador 1 Venceu!";
            Invoke("Reiniciar", 5);
        }
        
    }

    public void Reiniciar()
    {
        pontuacao1.text = "0";
        pontuacao2.text = "0";
        vencedor.text = "";
        pontos1 = 0;
        pontos2 = 0;
        transform.position = new Vector3(0, 0, 0);
        speed = 5;
        diagonal = 0;
    }

    public void VerificarPosicao()
    {
        if (transform.position.y <= -4.5f || transform.position.y >= 4.5f)
        {
            diagonal *= -1;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}