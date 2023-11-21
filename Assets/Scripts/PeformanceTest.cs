using System;
using System.Collections;
using UnityEngine;
using Random = System.Random;

public class PeformanceTest : MonoBehaviour
{
    public GameObject[] SlimePrefab = {};

    public int Count = 0;
    public Random RandomSeed;

    private void Awake()
    {
        RandomSeed = new Random(new System.DateTime().Millisecond);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(co_SpawningSlime());

    }

    // Update is called once per frame

    IEnumerator co_SpawningSlime()
    {
        while (Count < 100)
        {
            Count++;
            yield return new WaitForSeconds(0.5f);
            
            Instantiate(SlimePrefab[RandomSeed.Next(0, SlimePrefab.Length)], Vector3.zero+Vector3.up*Count, Quaternion.identity);    
        }
        
    }
    void Update()
    {
        
    }
}
