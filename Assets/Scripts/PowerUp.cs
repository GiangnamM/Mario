using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum Type
    {
        Coins, 
        ExtraLife,
        MagicMushroom,
        StarPower,
    }
    public Type type;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collect(collision.gameObject);
        }

    }

    private void Collect(GameObject player)
    {
        switch (type)
        {
            case Type.Coins:
                GameManager.Instance.AddCoin();
                break;
            case Type.ExtraLife:
                GameManager.Instance.AddLife();
                break;
            case Type.MagicMushroom:
                player.GetComponent<Player>().Grow();
                break;
            case Type.StarPower:
                player.GetComponent<Player>().StarPower();
                break;

        }
        Destroy(gameObject);
    }

    

}
