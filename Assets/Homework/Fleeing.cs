using UnityEngine;

public class Fleeing : MonoBehaviour
{
    [SerializeField] Transform enemy;
    [SerializeField] float fleeingDistance = 10;
    [SerializeField] float maxSpeed = 2;
    [SerializeField] float acceleration = 5;
    [SerializeField] float deceleration = 5;

    Vector3 velocity;
    
    void FixedUpdate()
    {
        Vector3 distanceVector = transform.position - enemy.position;
        float distance = distanceVector.magnitude;

        if (distance < fleeingDistance)
        {
            Vector3 direction = distanceVector.normalized;
            velocity += direction * acceleration * Time.fixedDeltaTime;
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        }
        else
        {
            velocity = Vector3.MoveTowards(velocity, Vector3.zero, deceleration * Time.fixedDeltaTime);
        }
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        CircleDrawer.DrawCircle(transform.position, fleeingDistance);        
    }
}
