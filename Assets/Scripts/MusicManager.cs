using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MusicManager : MonoBehaviour
{
    public AudioClip[] musicTracks; // Массив музыкальных треков
    private AudioSource audioSource; // Источник звука
    private int currentTrackIndex = -1; // Текущий индекс трека
    private float currentTrackTime = 0f; // Текущее время трека

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChangeTrack(int trackIndex)
    {
        if (trackIndex < 0 || trackIndex >= musicTracks.Length)
        {
            Debug.LogError("MusicManager: Track index out of range.");
            return;
        }

        if (currentTrackIndex != trackIndex)
        {
            currentTrackTime = audioSource.time; // Сохраняем текущее время трека
            currentTrackIndex = trackIndex;
            audioSource.clip = musicTracks[currentTrackIndex];
            audioSource.time = currentTrackTime; // Устанавливаем время на новом треке
            audioSource.Play();
        }
    }

    private void Update()
    {
        Debug.Log("Massive range "+musicTracks.Length);
    }
}
