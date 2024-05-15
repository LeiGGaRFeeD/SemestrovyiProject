using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public int trackIndex; // Индекс трека, который будет проигрываться при активации триггера
    [SerializeField]private MusicManager musicManager;

    void Start()
    {
    //    musicManager = FindObjectOfType<MusicManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Проверяем, что в триггер вошел игрок
        {
            musicManager.ChangeTrack(trackIndex);
        }
    }
}
