using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public GameManager gameManager;
    private float tickRate = 1;
    private float tick = 0;
    private float despawnTimer = 5;

    private double height = 0.5;
    // Start is called before the first frame update
    void Start()
    {
        //PipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameStatus == true)
        {
            PipeRespawn();
        }
    }

    void PipeSpawn()
    {
        float fheight = (float)height;
        //Spawn first pipe
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-fheight, fheight), 0);
        Destroy(newPipe, despawnTimer);
    }

    void PipeRespawn()
    {
        float fheight = (float)height;
        //Spawn a new pipe every tick
        if (tick > tickRate)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-fheight, fheight), 0);
            //Despawn Pipe after time
            Destroy(newPipe, despawnTimer);
            tick = 0;
        }
        tick += Time.deltaTime;
    }
}
