using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceBehaviour : MonoBehaviour
{

    int defenceHealth = 100;
    private SpriteRenderer renderer;
    int damage = 5;

    [SerializeField]
    private Sprite noDamage;

    [SerializeField]
    private Sprite slightDamage;

    [SerializeField]
    private Sprite decentDamage; 

    void Awake()
    {
        this.renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        EventSystem.current.onDefenceHitDamage += onDamageDecrease;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onDamageDecrease()
    {
        defenceHealth = defenceHealth - damage;
        switch (defenceHealth)
        {
            case 70:
                renderer.sprite = slightDamage;
                break;
            case 40:
                renderer.sprite = decentDamage;
                break;
            case 20:
                Destroy(gameObject);
                break;
        }
    }
}
