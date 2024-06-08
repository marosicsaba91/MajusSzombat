using UnityEngine;

public class Fleeing : MonoBehaviour
{
    [SerializeField] Transform enemy;
    [SerializeField] float fleeingDistance = 10;
    [SerializeField] float speed = 2;

    void Update()
    {
        Vector3 distanceVector = transform.position - enemy.position;
        float distance = distanceVector.magnitude;
        // distance = Vector3.Distance(enemy.position, transform.position);

        if (distance < fleeingDistance)
        {
            Vector3 direction = distanceVector.normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
