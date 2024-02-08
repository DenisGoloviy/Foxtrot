using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Boss : MonoBehaviour
{

    public TurretBoss[] _turretboss;
    public TriggerBoss _trigger;

    public Animator BossAnimator;

    public Transform _CameraTrigger;

    public CinemachineVirtualCamera _camera;

    public EventPhases _EventPhases;

    public int _DestroyTurrets;

    public void StartPhase()
    {
        _camera.m_Follow = _CameraTrigger;
        _camera.m_Lens.OrthographicSize = 6.88f;
        FirstPhase();
    }

    private void FirstPhase()
    {
        BossAnimator.SetTrigger("FirstPhase");
        foreach (var turret in _turretboss)
        {
            turret.canMove = true;
            turret.shootingTrigger = true;
        }
    }

    public void SecondPhase()
    {
        //���곿, �� ���������� �� ����� �� �� �������� ����    
    }

}
