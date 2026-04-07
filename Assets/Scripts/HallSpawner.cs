using UnityEngine;

public class HallSpawner : MonoBehaviour
{
    public int SpawnCount;
    public GameObject Hallway;

    private float Distance = -28.0f;

    void Start()
    {
        for (int x = 0; x <= SpawnCount; x++)
        {
            Summon(Distance);
        }
    }

    void Summon(float Z)
    {
        Vector3 spawnPosition = new Vector3(0, 0, Z);
        Quaternion spawnRotation = Quaternion.identity;

        Instantiate(Hallway, spawnPosition, spawnRotation);
        Distance += -28.0f;
    }
}
