using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Maine : MonoBehaviour
{
    //====== Playerの速度 ======
    //下り速度
    [Header("下りる速度")]
    [Tooltip("階段を下りていく速度の変更")]
    [SerializeField]
    private float downhillSpeed = 0.01f;

    //上り速度
    [Header("上り速度")]
    [Tooltip("階段を上る速度の変更")]
    [SerializeField]
    private float UpSpeed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //実は人間は左 → 右へ視線を動かす習性があるだから階段を上るときは右上に上る　ストレス解消に効く


    }
}
