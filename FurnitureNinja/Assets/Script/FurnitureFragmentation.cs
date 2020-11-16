using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureFragmentation : MonoBehaviour
{
    GamePlayUI gamePlayUI;
    [SerializeField] GameObject pieces;
    [SerializeField] GameObject piecesParticle;
    Rigidbody rbFurniture;
    public float forceModifier;

    // Start is called before the first frame update
    void Start()
    {
        gamePlayUI = FindObjectOfType<GamePlayUI>();
        rbFurniture = GetComponent<Rigidbody>();
        rbFurniture.AddForce(transform.up * forceModifier, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        // objeye dokunusu dinler
        if (other.CompareTag("Blade"))
        {
            gamePlayUI.ScoreWinner();
            Instantiate(pieces, transform.position, Quaternion.identity);
            Instantiate(piecesParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        // objeye dokunulmadi ise lose ye degerek destroy olur ve cani 1 azalir
        if (other.CompareTag("Lose"))
        {
            gamePlayUI.HealthLose();
            Destroy(gameObject);
        }
    }
}
