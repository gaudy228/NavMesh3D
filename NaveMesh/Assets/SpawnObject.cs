using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    private NavMeshSurface _surface;
    private Camera _mainCamera;
    [SerializeField] private GameObject _object;
    void Start()
    {
        _surface = GetComponent<NavMeshSurface>();
        _mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Instantiate(_object, hit.point + new Vector3(0, 0.5f, 0), Quaternion.identity);
                _surface.BuildNavMesh();
            }
        }
    }
}
