using UnityEngine;

public class SideMove : MonoBehaviour
{
    public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move right
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
            rb2.AddForce(new Vector2(accel, 0));
        }

        //Move right
        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
            rb2.AddForce(new Vector2(-accel, 0));
        }

    }
}
