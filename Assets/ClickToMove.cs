using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    private NavMeshAgent _agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Ensure the main camera exists
            if (Camera.main == null)
                return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                // Add a small random offset to the destination
                Vector3 randomOffset = Random.insideUnitSphere * 0.5f;
                randomOffset.y = 0;
                _agent.destination = hitInfo.point + randomOffset;
            }
        }
    }
}
