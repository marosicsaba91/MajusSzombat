using UnityEngine;

class SpaceshipController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeed = 360;

    void Update()
    {
        // Input
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        // Forgatás
        transform.Rotate(0, 0, -inputX * angularSpeed * Time.deltaTime);

        // Reset
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 euler = transform.rotation.eulerAngles;
            euler.z = 0;
            transform.rotation = Quaternion.Euler(euler);
        }


        // Mozgatás
        Vector3 direction = new(0, inputY);         // Egy hosszú (vagy nulla)
        direction.Normalize();                           // Ne mozogjon keresztbe gyorsabban
        transform.position += direction * speed * Time.deltaTime;   // Lépés
    }
}
