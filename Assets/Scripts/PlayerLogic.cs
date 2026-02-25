using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float speed = 5f;
    public GameObject projectilePrefab;
    public Transform firePoint;

    void Update()
    {
        // Movement
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveInput * speed * Time.deltaTime);

        // Shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
    }
}
