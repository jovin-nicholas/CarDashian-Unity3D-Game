using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject crate;
    public Rigidbody car;
    float m, n, o;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Car")
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);

            Instantiate(crate, new Vector3(m, 3f + o, n), Quaternion.identity);
            Destroy(crate);
            Destroy(destroyedVersion);
        }
    }


    void Update()
    {
        m = Random.Range(car.position.x + 100, car.position.x + 200);
        n = Random.Range(car.position.z + 0, car.position.z + 5);
        o = Terrain.activeTerrain.SampleHeight(new Vector3(m, transform.position.y, n));


    }

}
