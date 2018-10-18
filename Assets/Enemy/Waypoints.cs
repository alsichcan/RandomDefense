
using UnityEngine;

public class Waypoints : MonoBehaviour {

    public static Transform[] points;

    private void Awake()
    {
        // Array that contains the transform of waypoints
        points = new Transform[transform.childCount];

        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
