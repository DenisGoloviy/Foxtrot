using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class Boss : MonoBehaviour
{

    public TurretBoss[] _turretboss;
    public TriggerBoss _trigger;
    public GameObject enemy;
    public GameObject enemy2;

    public Animator BossAnimator;

    public Transform _CameraTrigger;

    public CinemachineVirtualCamera _camera;

    public EventPhases _EventPhases;

    public int _DestroyTurrets;
    public GameObject bullet;
    public Transform shootingPoint;

    public string currentSceneName = SceneManager.GetActiveScene().name;
    //[HideInInspector]
    public int CountEnemy;

    private void Start()
    {
        enemy.SetActive(false);
        enemy2.SetActive(false);
    }

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
        if(/*currentSceneName == "End" && */CountEnemy == 2) 
        {
            print("fd");
            SceneManager.LoadScene(6);
        }
        _EventPhases._EventPhases(true, 3, 1);
        print("EventPhases");
        InvokeRepeating(nameof(SpawnBullet), 0,2);
    }

    private void SpawnBullet()
    {
        print("SpawnBullet");
        Instantiate(bullet, shootingPoint.position, Quaternion.identity);
    }

    public void UpdateDestroyedTurrets()
    {
        _DestroyTurrets++;
        if (_DestroyTurrets == 2)
        {
            SecondPhase();
            enemy.SetActive(true);
            enemy2.SetActive(true);
        }
    }
}
