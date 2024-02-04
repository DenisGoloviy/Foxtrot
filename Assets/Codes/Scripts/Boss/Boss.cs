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
    BossPhase Phases;

    public void StartPhase()
    {
        Phases = BossPhase.First_Phase;
        _camera.m_Follow = _CameraTrigger;
        _camera.m_Lens.OrthographicSize = 6.88f;
        switch (Phases)
        {
            case BossPhase.First_Phase:
                FirstPhase();
                break;
                //case BossPhase.Second_Phase:
                //    SecondPhase();
                //    break;
                //case BossPhase.Third_Phase:
                //    ThirdPhase();
                //    break;
        }
    }

    private void FirstPhase()
    {
        if(Phases == BossPhase.First_Phase)
        {
            BossAnimator.SetTrigger("FirstPhase");
            foreach (var turret in _turretboss)
            {
                turret.canMove = true;
            }
        }
    }

    enum BossPhase
    {
        First_Phase,
        Second_Phase,
        Third_Phase
    }

}
