using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemPickUpController : MonoBehaviour
{
    [SerializeField] List<ItemPickUps> item;

    public PlayerController player;
    int count = 0;
    private void Start()
    {
        foreach (var health in item)
            health.OnItemPickUp += Health;
    }

   
    void Health(ItemPickUps health)
    {
        count += 1;
        Debug.Log("Health Picked Up:");
        Debug.Log(count);
        player.health += 1;
        Destroy(health);

        
         
    }

}