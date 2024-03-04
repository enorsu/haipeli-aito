using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolManager : MonoBehaviour
{
    public static BulletPoolManager instance;

    // this is a prefab that will be copied to create bullets
    public GameObject bulletPrefab;

    // ammo amount
    public int bulletAmount = 20;

    // this is the ammo pool
    private Queue<GameObject> bulletPool = new Queue<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
