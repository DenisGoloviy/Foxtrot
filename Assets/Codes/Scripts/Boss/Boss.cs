using Cinemachine;
using System;
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
    public GameObject bullet;
    public Transform shootingPoint;
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    private bool mobsSpawned = false;
    Enemy enemy;

    public void StartPhase()
    {
        _camera.m_Follow = _CameraTrigger;
        _camera.m_Lens.OrthographicSize = 6.88f;
        FirstPhase();
    }

    private void SpawnMobs()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(enemyPrefab, spawnPoints[i]);
        }
        mobsSpawned = true;
        enemy.secondPhaseisActive = true;
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
        if (!mobsSpawned)
        {
            SpawnMobs();
        }
        _EventPhases._EventPhases(true, 3, 1);
        InvokeRepeating(nameof(SpawnBullet), 0,2);
        //Функії, які відповідають за спавн та за стрельбу боса    
    }

    private void SpawnBullet()
    {
        Instantiate(bullet, shootingPoint.position, Quaternion.identity);
    }

    public void UpdateDestroyedTurrets()
    {
        _DestroyTurrets++;
        if (_DestroyTurrets == 2)
        {
            SecondPhase();
        }
    }
}
