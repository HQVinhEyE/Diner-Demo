using UnityEngine;

public class Table : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private Plate Plate;
    [SerializeField] float timetodestroy = 5f;
    public bool tabled  = false;
    [SerializeField] Vector3 tablePos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    
}
