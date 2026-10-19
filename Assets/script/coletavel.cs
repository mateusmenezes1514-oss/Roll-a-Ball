
using UnityEngine;

public class coletavel : MonoBehaviour
{
    public int valor = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}