using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public TurretBoss[] _turretboss;
    public TriggerBoss _trigger;

    public Animator BossAnimator;

    public Transform _CameraTrigger;

    public CinemachineVirtualCamera _camera;

    private void Update()
    {
        if(!_trigger)
        {
            _camera.m_Follow = _CameraTrigger;
            _camera.m_Lens.OrthographicSize = 6.88f;
            FirstPhase();
        }
    }

    private void FirstPhase()
    {
        BossAnimator.SetTrigger("FirstPhase");
        _turretboss[0].TurretMove();
        _turretboss[1].TurretMove();
    }

}
