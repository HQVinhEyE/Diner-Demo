using UnityEngine;

public class Foodtable : MonoBehaviour
{
    [SerializeField] GameObject plate;
    public PlayerController controller;
    [SerializeField] private float platesize = 3f;
    [SerializeField] private float handposition = 1f;
    private float startTimer = 3;
    private float spawnDelay = 8;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPlate", startTimer, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPlate()
    {
        Instantiate(plate, new Vector3(12, 3.5f, 17), Quaternion.identity);
    }

}
