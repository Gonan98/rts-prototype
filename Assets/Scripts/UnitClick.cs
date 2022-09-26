using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitClick : MonoBehaviour
{
    private Camera _camera;

    // public GameObject GroundMarker;
    public LayerMask Clickable;
    public LayerMask Ground;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);    
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, Clickable))
            {
                UnitSelections.Instance.ClickSelect(hit.collider.gameObject);
            }
            else
            {
                UnitSelections.Instance.DeselectAll();
            }
        }
        //if (Input.GetMouseButtonDown(1))
        //{
        //    RaycastHit hit;
        //    Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity, Ground))
        //    {
        //        GroundMarker.transform.position = hit.point;
        //        GroundMarker.SetActive(false);
        //        GroundMarker.SetActive(true);
        //    }
        //}
    }
}
