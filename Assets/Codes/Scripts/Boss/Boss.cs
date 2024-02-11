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
    public GameObject bullet;
    public Transform shootingPoint;
    private float timer = 2f;
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    private bool mobsSpawned = false;

    private void Update()
    {
        timer -= Time.deltaTime;

        if (_DestroyTurrets == 2f)
        {
            if(timer <= 0)
            {
                Shoot();
                timer = 2f;
            }
        }

        SpawnMobs();
    }

    public void StartPhase()
    {
        _camera.m_Follow = _CameraTrigger;
        _camera.m_Lens.OrthographicSize = 6.88f;
        FirstPhase();
    }

    private void Shoot()
    {
        Instantiate(bullet, shootingPoint.position, Quaternion.identity);
    }

    private void SpawnMobs()
    {
        if(_DestroyTurrets == 2 && !mobsSpawned)
        {
            Instantiate(enemyPrefab, spawnPoints[0]);
            Instantiate(enemyPrefab, spawnPoints[1]);
            Instantiate(enemyPrefab, spawnPoints[2]);
            Instantiate(enemyPrefab, spawnPoints[3]);
            mobsSpawned = true;
        }
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
        //Функії, які відповідають за спавн та за стрельбу боса    
    }

}
