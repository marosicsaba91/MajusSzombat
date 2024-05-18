using UnityEngine;

class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float duration = 5;

    void Start()
    {
        Destroy(gameObject, duration);
    }
     

    void Update()
    {
        transform.position += 
            transform.up * speed * Time.deltaTime;
    }
}
