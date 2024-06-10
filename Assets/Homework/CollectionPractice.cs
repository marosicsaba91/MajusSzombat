using System.Collections.Generic;
using UnityEngine;

public class CollectionPractice : MonoBehaviour
{
    [SerializeField] int[] ints;
    [SerializeField] string[] strings;
    [SerializeField] Vector2[] vectors;
    [SerializeField] Transform[] transforms;

    void Start()
    {
        int a = 33;

        int[] array1 = { 22, 44, 55, 55, 55, 55 };

        // ----------------------------------------

        string[] stringArray = { "Alma", "Körte", "Citrom", "Banán" };

        string first = stringArray[0];   // "Alma"
        string second = stringArray[1];  // "Körte"
        string fourth = stringArray[3];  // "Banán"

        int arrayLength = stringArray.Length;
        string last1 = stringArray[arrayLength];
        string last2 = stringArray[^1];

        // ----------------------------------------

        Vector2[] vectors = new Vector2[10];   // default értékek
        for (int i = 0; i < vectors.Length; i++)
        {
            vectors[i] = Random.insideUnitCircle;
        }

        // ----------------------------------------

        List<int> intList = new();
        List<string> stringList = new();
        List<Vector2> Vector2List = new();
        // List<int[]> intArrayList = new();  

        intList.Add(23);
        intList.Add(88);
        intList.Add(55);
        intList.Add(77);

        intList[3] = 999;
        Debug.Log(intList[2]); // 55

        int listLength = intList.Count;

        intList.Remove(55);
        Debug.Log(intList[2]); // 999


        intList.RemoveAt(1);  // Kivét egy indexen

        intList.Insert(2, 1000);

        intList.Sort();
        bool is1000In = intList.Contains(1000);  // true
        int indexOf1000 = intList.IndexOf(1000);  // 2     (ha egy sincs: -1)
        intList.Clear();
    }
}
