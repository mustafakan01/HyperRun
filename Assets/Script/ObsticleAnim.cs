using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleAnim : MonoBehaviour
{
    public float speed=1f;
    public float streng = 2.5f;
    public float randomOffset;
    void Start()
    {
        randomOffset = Random.Range(-2.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos= transform.position;
        pos.x = Mathf.Sin(Time.time * speed + randomOffset) * streng;
        transform.position = pos; 
    }
}
