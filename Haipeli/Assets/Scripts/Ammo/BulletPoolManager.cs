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
        instance = this;
        InitializePool();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitializePool() {

        for(int i = 0; i < bulletAmount; i++) {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletPool.Enqueue(bullet);
        }

    }

    public GameObject GetBullet() {

        if(bulletPool.Count > 0) {
            GameObject bullet = bulletPool.Dequeue();
            bullet.SetActive(true);
            return bullet;
        } else {
            return null;
        }
        
    }
}
