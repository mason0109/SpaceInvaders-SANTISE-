using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private float runSpeed;
    
    public GameObject sanitiserAmmo;
    public GameObject sanitiserAmmoCopy;

    private Rigidbody2D rigidbody;
    private Vector2 myVelocity;

    public int playerLives = 3;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    } 

    void Start()
    {
        EventSystem.current.onPlayerHitTakeALife += takeDamage;
    }

    public void Move(Vector2 direction)
    {
        myVelocity = rigidbody.velocity;
        myVelocity.x = direction.x * runSpeed;
        rigidbody.velocity = myVelocity;
    }

    public void onMove(InputAction.CallbackContext input)
    {
        Move(input.ReadValue<Vector2>());
    }

    
    public void Fire(float shoot)
    {
        if (sanitiserAmmoCopy == null)
        {
            Vector3 v = rigidbody.transform.position + new Vector3(0, 0.8f, 0);
            sanitiserAmmoCopy = Instantiate(sanitiserAmmo, v, Quaternion.identity);
            FindObjectOfType<AudioManager>().PlaySound("Shoot");
        }

    }

    public void onFire(InputAction.CallbackContext input)
    {
        Fire(input.ReadValue<float>());
    }

    public void takeDamage()
    {
        if (playerLives == 1) 
        {
            playerLives--;
        }
        if (playerLives > 1) 
        {
            playerLives--;
        }
    }

    void OnDestroy()
    {
        EventSystem.current.onPlayerHitTakeALife -= takeDamage;
    }
}
