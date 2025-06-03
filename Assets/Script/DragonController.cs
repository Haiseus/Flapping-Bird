using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public Rigidbody2D dragon;
    public float jumpForce = 2.0f;
    public int jumpHeight = 2;
    private Vector2 jump = new Vector2(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        dragon = GetComponent<Rigidbody2D>();
        jump = new Vector2(0, jumpHeight);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dragon.AddForce(jump * jumpForce, ForceMode2D.Impulse);
        }
    }
}
