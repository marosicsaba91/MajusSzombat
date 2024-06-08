using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float stepLength = 1;

    Vector3 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        StepTarget();
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    void StepTarget()
    {
        if (transform.position != targetPosition) return;

        Vector3 dir = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.UpArrow))
            dir = Vector3.up;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            dir = Vector3.down;
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            dir = Vector3.right;
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            dir = Vector3.left;

        targetPosition += dir * stepLength;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(targetPosition, 0.25f);
    }
}
