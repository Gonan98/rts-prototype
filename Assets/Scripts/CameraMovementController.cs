using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour
{

    public float Speed = 10.0f;
    [SerializeField] private float _borderSize;
    //[SerializeField] private Vector2 _borderLimit;
    //[SerializeField] private float _scrollSpeed;
    //[SerializeField] private float _minHeight;
    //[SerializeField] private float _maxHeight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - _borderSize)
        {
            position.z += Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) || Input.mousePosition.y <= _borderSize)
        {
            position.z -= Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - _borderSize)
        {
            position.x += Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) || Input.mousePosition.x <= _borderSize)
        {
            position.x -= Speed * Time.deltaTime;
        }

        //float scroll = Input.GetAxis("Mouse ScrollWheel");
        //Debug.Log(scroll);
        //position.y += -scroll * _scrollSpeed * 100f * Time.deltaTime;
        //position.y = Mathf.Clamp(position.y, _minHeight, _maxHeight);

        //position.x = Mathf.Clamp(position.x, -_borderLimit.x, _borderLimit.x);
        //position.z = Mathf.Clamp(position.z, -_borderLimit.y, _borderLimit.y);

        transform.position = position;
    }
}
