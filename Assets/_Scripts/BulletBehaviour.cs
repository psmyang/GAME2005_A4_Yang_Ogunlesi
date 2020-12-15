using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletBehaviour : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float range;

    // Start is called before the first frame update
    void Start()
    {
        //CollisionManager.Instance.Spheres.Add(this);

        //forwardDirection = GameObject.FindWithTag("Player").transform.forward;
        //forwardVelocity = 12;
        //rigidBody.velocity = new Vector3(0, 0, 0);
        //rigidBody.acceleration = new Vector3(0, -0.5f, 0);
        //rigidBody.nass = 1;
        //rigidBody.restitution = 1;
        //rigidBody.friction = 0.5f;
        //rigidBody.anchored = false;

        //rigidBody.velocity = forwardDirection * forwardVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (Vector3.Distance(transform.position, Vector3.zero) > range)
        {
            Destroy(gameObject);
        }
    }
}
