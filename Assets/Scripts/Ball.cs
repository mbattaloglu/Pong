using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 200f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void AddStartingForce()
    {
        float x = Random.Range(0, 2) == 0 ? -1f : 1f;
        float y = Random.Range(0, 2) == 0 ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }

    public void ResetPosition()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;
    }
}
