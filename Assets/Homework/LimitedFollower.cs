using UnityEngine;

public class LimitedFollower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    [SerializeField] float minDistance;

    void Update()
    {
        Vector3 distanceVector = target.position - transform.position;
        float distance = distanceVector.magnitude;

        if (distance > minDistance)
        {
            Vector3 direction = distanceVector / distance;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
