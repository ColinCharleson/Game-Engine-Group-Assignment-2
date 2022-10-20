using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemPickUpController : MonoBehaviour
{
    [SerializeField] List<ItemPickUps> item;

    public PlayerController player;
    int count = 0;

    private void OnEnable()
    {
        foreach (var health in item)
            health.OnItemPickUp += Health;
    }

    void Health(ItemPickUps health)
    {
        count += 1;
        player.health += 1;
        Debug.Log("Health Picked Up:" + count);
        Debug.Log("Current Health:" + player.health);
    }

}