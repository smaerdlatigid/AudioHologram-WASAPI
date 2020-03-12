using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Animations;
using UnityEngine.Playables;

public class AudioSpeed : MonoBehaviour
{
    Animator m_Animator;
    public LoopbackAudio Audio;
    public float speed = 1f;  
    public PlayableDirector playableDirector; 

    void Start()
    {
        playableDirector = gameObject.GetComponent<PlayableDirector>();
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayableExtensions.SetSpeed(playableDirector.playableGraph.GetRootPlayable(0),( Audio.WeightedAverage) * speed ); 
        //m_Animator.speed =;
        //.SetSpeed();
    }
}
