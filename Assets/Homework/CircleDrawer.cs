using UnityEngine;

public class CircleDrawer : MonoBehaviour
{
    [SerializeField] float radius = 1;
    [SerializeField, Min(3)] int segmentCount = 50;
    [SerializeField] Color color = Color.white;

    void OnDrawGizmos()
    {
        Gizmos.color = color;
        DrawCircle(transform.position, radius, segmentCount);        
    }

    static public void DrawCircle(Vector3 center, float radius, int segmentCount = 100)
    {
        for (int i = 0; i <= segmentCount; i++)
        {
            float angleA = (2 * Mathf.PI) * (i / (float)segmentCount);
            float angleB = (2 * Mathf.PI) * ((i + 1) / (float)segmentCount);

            float ax = Mathf.Cos(angleA);
            float ay = Mathf.Sin(angleA);
            Vector3 a = new(ax, ay);
            a *= radius;
            a += center;

            float bx = Mathf.Cos(angleB);
            float by = Mathf.Sin(angleB);
            Vector3 b = new(bx, by);
            b *= radius;
            b += center;

            Gizmos.DrawLine(a, b);
        }
    }
}
