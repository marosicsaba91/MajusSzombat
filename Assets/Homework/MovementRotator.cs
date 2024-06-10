using UnityEngine;

public class MovementRotator : MonoBehaviour
{
    Vector3 lastPosition;

    private void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 step = currentPosition - lastPosition;

        if (step != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(step);       
        }

        lastPosition = currentPosition;
    }
}
