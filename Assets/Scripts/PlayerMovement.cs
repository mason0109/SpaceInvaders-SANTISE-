using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private float runSpeed;

    [SerializeField]
    private PlayerStats playerStats;
    
    public GameObject sanitiserAmmo;
    public GameObject sanitiserAmmoCopy;

    private Rigidbody2D rigidbody;
    private Vector2 myVelocity;

    private int maxBullets = 3;
    private int currentBullets = 0;

    private void Awake()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    } 

    void Start()
    {
        EventSystem.current.onPlayerHitTakeALife += takeDamage;
        EventSystem.current.onBulletHitBoundary += decreaseBulletCount;
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
        if (currentBullets < maxBullets)
        {
            currentBullets++;
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
        if (playerStats.playerLives == 1) 
        {
            playerStats.playerLives--;
        }
        if (playerStats.playerLives > 1) 
        {
            playerStats.playerLives--;
        }
    }

    public void decreaseBulletCount()
    {
        currentBullets--;
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(playerStats);
    }

    void OnDestroy()
    {
        EventSystem.current.onPlayerHitTakeALife -= takeDamage;
    }
}
