using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent navMesh;
    public bool grabPlate = false;
    [SerializeField] private float reach = 8f;
    private float tableHeight = 1.5f;
    [SerializeField] GameObject PlateDestroyer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                navMesh.SetDestination(hit.point);
                
                if(grabPlate== true&& hit.collider != null && hit.collider.gameObject.CompareTag("Table") && ReachTable(hit.collider.gameObject.transform.position)==true)
                {
                    Transform child = transform.GetChild(1);
                    child.transform.position = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y+ tableHeight, hit.collider.gameObject.transform.position.z);
                    child.transform.SetParent(PlateDestroyer.transform);
                    grabPlate = false;
                }
            }
        }
    }
    public bool ReachTable(Vector3 pointer)
    {
        float range = Vector3.Distance(transform.position, pointer);
        if (range <= reach)
            return true;
        else
            return false;
    }
}
