using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesGenerator : MonoBehaviour
{
    public GameObject tube;
    public GameObject floor;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawningTube());
    }

    // Update is called once per frame
    void Update()
    {
    }
    private IEnumerator SpawningTube()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(0, Random.Range(-3f, 3f), transform.position.z + 10);
            GameObject.Instantiate(tube, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
