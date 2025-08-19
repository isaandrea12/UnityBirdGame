using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float flapStrength;

    void Start()
    {
        gameObject.name = "Bob Bird";
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
