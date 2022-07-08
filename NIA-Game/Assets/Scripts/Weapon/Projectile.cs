using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    public float lifeTime;

    private void Start()
    {
        Invoke("DestrpyProjectile", lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

    void DestrpyProjectile()
    {
        Destroy(gameObject);
    }
}
