using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public int points = 10;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Game over if enemy goes below screen
        if (transform.position.y < -6f)
        {
            GameManager.instance.GameOver();
            Destroy(gameObject);
        }
    }

    public void DestroyEnemy()
    {
        GameManager.instance.AddScore(points);
        Destroy(gameObject);
    }
}
