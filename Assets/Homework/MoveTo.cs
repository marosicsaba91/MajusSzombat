using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float distance;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 distanceVector = target.position - transform.position;
            float distance = distanceVector.magnitude;
            if(distance == 0) return;

            Vector3 direction = distanceVector / distance; // Optimálisabb egy kicsit.

            distance = Mathf.Min(distance, this.distance);
            transform.position += direction * distance;
        }
    }
}
