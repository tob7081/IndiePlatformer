using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");

        // Movimiento proporcional al tiempo para que sea consistente en todos los framerates
        transform.position += new Vector3(inputHorizontal * velocidad * Time.deltaTime, 0f, 0f);
    }
}
