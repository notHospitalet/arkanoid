using UnityEngine;

public class brick : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
