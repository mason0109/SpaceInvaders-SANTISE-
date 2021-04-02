using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RonaMovement : MonoBehaviour
{
    float timer = 0;
    float timerMax = 0.5f;
    float speed = 0.01f;
    bool boundaryReached = false;
    int ronaAmmoCount = 0;

    public GameObject RonaAmmo;
    public GameObject ronaAmmoCopy;

    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (boundaryReached == false)
        {
            timer += Time.deltaTime;
            if (timer < timerMax)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;
            }
        }
        if (boundaryReached == true)
        {
            boundaryReached = false;
            transform.Translate(new Vector3(0, -1, 0));
            speed = -speed;
        }
        fireRonaAmmo();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RBoundary" || collision.gameObject.tag == "LBoundary")
        {
            boundaryReached = true;
        }
    }

    private void fireRonaAmmo()
    {
        if (Random.Range(0f, 1500f) < 1)
        {
            if (ronaAmmoCount < 3)
            {
                Vector3 v = rigidbody.transform.position + new Vector3(0, -0.8f, 0);
                ronaAmmoCopy = Instantiate(RonaAmmo, v, Quaternion.identity);
                ronaAmmoCount++;
            } else {
                ronaAmmoCount = 0;
            }
        }
    }
}
