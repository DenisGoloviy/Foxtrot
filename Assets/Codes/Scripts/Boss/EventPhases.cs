using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPhases : MonoBehaviour
{
    public GameObject[] eventPhases;
    public Sprite[] Phases;
    public void _EventPhases(bool PassPhase, int wait, int massive)
    {
        StartCoroutine(disappear());
        eventPhases[1].GetComponent<SpriteRenderer>().sprite = Phases[massive];
        IEnumerator disappear()
        {
            foreach (var ObjectEventPhases in eventPhases)
            {
                ObjectEventPhases.SetActive(PassPhase);
                yield return new WaitForSeconds(wait);
                ObjectEventPhases.SetActive(!PassPhase);
            }
        }
    }


}