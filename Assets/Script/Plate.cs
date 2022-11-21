using UnityEngine;

public class Plate : MonoBehaviour
{
    GameObject player;
    PlayerController controller;
    bool grabplate;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        controller = player.GetComponent<PlayerController>();
        grabplate = controller.grabPlate;
        
    }


    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        
        if (grabplate == false && Input.GetMouseButtonDown(0) && controller.ReachTable(this.transform.position) == true)
        {           
            controller.grabPlate = true;
            transform.SetParent(controller.transform);
            transform.localPosition = new Vector3(0, 1.5f, 0);
        }
    }

}
