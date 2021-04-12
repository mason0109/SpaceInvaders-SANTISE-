using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RonaMovement : MonoBehaviour
{
    float timer = 0;
    float timerMax = 0.5f;
    float speed = 0.005f;

    int ronaAmmoCount = 0;

    public GameObject RonaAmmo;
    public GameObject ronaAmmoCopy;

    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        EventSystem.current.onLeftBoundaryTurn += onTurnRight;
        EventSystem.current.onRightBoundaryTurn += onTurnLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
            fireRonaAmmo();
            move();
        
    }

    public void move()
    {
        transform.Translate(new Vector3(speed, 0, 0));
    }

    public void onTurnRight() 
    {
        
            float temp = System.Math.Abs(speed);
            transform.Translate(new Vector3(0, -0.5f, 0));
            speed = temp;
        
    }

    public void onTurnLeft()
    {
        
            float temp = System.Math.Abs(speed);
            transform.Translate(new Vector3(0, -0.5f, 0));
            speed = -temp;
        
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

    void onDestroy()
    {
       EventSystem.current.onLeftBoundaryTurn -= onTurnRight; 
       EventSystem.current.onRightBoundaryTurn -= onTurnLeft;
    }
}
