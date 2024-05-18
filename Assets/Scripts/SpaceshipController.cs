using UnityEngine;

class SpaceshipController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeedInIdle = 360;
    [SerializeField] float angularSpeedInMovement = 180;

    [SerializeField] float maxNitro = 2;
    [SerializeField] float turboMultiplier = 1.5f;

    float nitro;

    void Start()
    {
        nitro = maxNitro;
    }

    void Update()
    {
        // Input
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        // Forgatás
        float angularSpeed = inputY == 0 ? angularSpeedInIdle : angularSpeedInMovement;
        transform.Rotate(0, 0, -inputX * angularSpeed * Time.deltaTime);

        // Reset
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 euler = transform.rotation.eulerAngles;
            euler.z = 0;
            transform.rotation = Quaternion.Euler(euler);
        }

        // Mozgatás
        if (inputY != 0)
        {
            Vector3 direction = transform.up * inputY;
            float realSpeed = speed;
            if (nitro > 0 && Input.GetKey(KeyCode.LeftShift))
            {
                realSpeed *= turboMultiplier;
                nitro -= Time.deltaTime;
                nitro = Mathf.Max(nitro, 0);
            }

            transform.position += direction * realSpeed * Time.deltaTime;   // Lépés
        }
        else
        {
            nitro += Time.deltaTime;
            nitro = Mathf.Min(nitro, maxNitro);
        }
    }
}
