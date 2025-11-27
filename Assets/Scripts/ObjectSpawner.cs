using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int count = 10;
    public Vector3 areaSize = new Vector3(20, 0, 20);

    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = new Vector3(
                Random.Range(-areaSize.x, areaSize.x),
                0.5f,
                Random.Range(-areaSize.z, areaSize.z)
            );

            Instantiate(obstaclePrefab, pos, Quaternion.identity);
        }
    }
}