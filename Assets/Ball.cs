using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 100.0f;
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) {
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "racket_0") {
            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, 1).normalized;
            
            GetComponent<Rigidbody2D>().linearVelocity = dir * (speed * 1.2f);
        }
    }
}
