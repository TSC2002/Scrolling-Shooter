using UnityEngine;

public class DañoAlEnemigo : MonoBehaviour
{
    public float PuntosVida;
    public float VidaMaxima = 5;

    // Start is called before the first frame update
    void Start()
    {
        PuntosVida = VidaMaxima;
    }

    public void Takehit(float golpe)
    {
        PuntosVida -= golpe;
        if (PuntosVida <= 0)
        {
            Destroy(gameObject);
        }
    }

}
