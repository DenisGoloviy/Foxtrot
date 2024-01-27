using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public TurretBoss _turretboss;
    public TriggerBoss _trigger;
    
    public CinemachineVirtualCamera _camera;

    private void FixedUpdate()
    {
        if(!_trigger)
        {
            _camera.m_Lens.OrthographicSize = 10.88f;
            _turretboss.TurretMove();
        }
    }

}
