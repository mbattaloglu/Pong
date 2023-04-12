using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ballRb;

    private void FixedUpdate()
    {
        if (this.ballRb.velocity.x > 0)
        {
            if (this.ballRb.position.y > this.transform.position.y)
            {
                this.rb.AddForce(Vector2.up * this.speed);
            }
            else if (this.ballRb.position.y < this.transform.position.y)
            {
                this.rb.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if(this.transform.position.y > 0f)
            {
                rb.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0f)
            {
                rb.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
