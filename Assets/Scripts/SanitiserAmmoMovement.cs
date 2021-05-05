using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanitiserAmmoMovement : MonoBehaviour

    
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            EventSystem.current.enemyKilled();
            EventSystem.current.enemyKilledIncreaseScore();
            EventSystem.current.bulletHitBoundary();
        }
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
            EventSystem.current.bulletHitBoundary();
        }
        if (collision.gameObject.tag == "Defence"){
            Destroy(gameObject);
            EventSystem.current.bulletHitBoundary();
        }
    }
}
