using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodTrailSpawn_script : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;

    public GameObject bloodTrail;
    private animationScript player;

    private void Start()
    {
        player = GetComponent<animationScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.moveSpeed != 0)
        {
            if (timeBtwSpawn <= 0)
            {
                GameObject Instance = Instantiate(bloodTrail, transform.position, Quaternion.identity);
                Destroy(Instance, 5f);
                timeBtwSpawn = startTimeBtwSpawn;
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }

    }
}
