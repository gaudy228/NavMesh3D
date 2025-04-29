using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchNavMesh : MonoBehaviour
{
    [SerializeField] private GameObject _leftWay;
    [SerializeField] private GameObject _centerWay;
    [SerializeField] private GameObject _rightWay;

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _leftWay.SetActive(true);
            _centerWay.SetActive(false);
            _rightWay.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            _leftWay.SetActive(false);
            _centerWay.SetActive(true);
            _rightWay.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            _leftWay.SetActive(false);
            _centerWay.SetActive(false);
            _rightWay.SetActive(true);
        }
    }
}
