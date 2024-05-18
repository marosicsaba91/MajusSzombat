using UnityEngine;

class MyFirstScript : MonoBehaviour
{
    [SerializeField] int num;

    void Start()
    {
        int i = 1;
        while (i <= 1000000)
        {
            Debug.Log(i);
            i++;
        }

        for (int j = 1000000; j > 1; j--)
        {
            Debug.Log(j);
        }
    }
}