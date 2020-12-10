using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platform;
    public int count;
    private Vector3 SpawnPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        if (platform.name.Equals("Platform"))
        {
            SpawnPosition.y = 0;
        }

        if (platform.name.Equals("MovementPlatform"))
        {
            SpawnPosition.y = 15;
        }

        if (platform.name.Equals("CrashPlatform"))
        {
            SpawnPosition.y = 30;
        }

        if (platform.CompareTag("Enemy"))
        {
            SpawnPosition.y = 15;
        }
        for (int i = 0; i < count; i++)
        {
            SpawnPosition.x = Random.Range(-1.7f, 1.7f);
            SpawnPosition.y += Random.Range(1.2f, 1.5f);
            Instantiate(platform, SpawnPosition, Quaternion.identity);
        }
    }

// Update is called once per frame
    void Update()
    {
        
    }
}
