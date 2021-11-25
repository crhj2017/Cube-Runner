using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObstacleGenerate : MonoBehaviour
{
    // Prefab from assets
    [SerializeField]
    private GameObject obstPrefab;
    [SerializeField]
    private Rigidbody player;
    [SerializeField]
    private Text score;

    // Timing for spawning obstacles
    [SerializeField]
    private float Difficulty;

    public float respawnTime;

    private float nextSpawnTime;


    void Generate()
    {

        // Initialise ObstPosition relative to player
        var y = 1; // player.position[1];
        var z = player.position[2] + 30f;

        // Create a block in 30% of x coords
        for (int x = -6; x < 7; x = x + 2) {
            var rand = Random.Range(0f, 1f);
            if (rand < 0.3f)
            {
                GameObject.Instantiate(obstPrefab, new Vector3(x, y, z), transform.rotation);
            }
        }
    }

    void Update()
    {
        // Time interval mangager
        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + respawnTime;
            if (respawnTime > 0.3f)
            {
                respawnTime -= (Time.time / Difficulty);
            }
            Generate();
        }

        // Time interval mangager
        if (player.position[1] <= -4)
        {
            respawnTime = 1;
        }
    }
}
