using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public TriggerBoss _trigger;
    
    public GameObject _camera;

    private void Update()
    {
        if(_trigger)
        {
            _camera.gameObject.GetComponent<Size>();
        }
    }
}
