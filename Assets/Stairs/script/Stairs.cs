using UnityEngine.Pool;
using UnityEngine;
using System.Collections.Generic;

public class Stairs : MonoBehaviour
{
    //====== ŠK’i ======
    //ŠK’i‚Ìprefab
    [Header("ŠK’i‚Ìprefab“ü‚ê‚éêŠ")]
    [SerializeField]
    private GameObject stairsObject;

    //Å‰‚É—pˆÓ‚µ‚Ä‚¨‚­prefab”
    [Header("Å‰‚©‚ç—pˆÓ‚µ‚Ä‚¨‚­ŠK’i‚Ìprefab‚Ì”")]
    [SerializeField]
    private int startStairs = 20;

    //ŠK’i‚ÌŠÔŠu
    [Header("ŠK’i‚ÌŠÔŠuİ’è")]
    [SerializeField]
    private int IntervalStairs = 1;

    //ŠK’i‚ğƒ‹[ƒv‚·‚é‚â‚Â
    private ObjectPool<GameObject> stairsPool;
    //ŠK’i‚Ì”‚ğŠÇ—‚·‚éƒŠƒXƒg
    private List<GameObject> activeStairs = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        stairsObject.SetActive(true);   
    }
}
