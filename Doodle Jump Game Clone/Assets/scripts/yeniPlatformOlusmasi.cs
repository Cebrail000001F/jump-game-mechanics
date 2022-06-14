using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeniPlatformOlusmasi : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] int platformSayisi = 100;

    void Start()
    {
        yeniPlatformKonumu();
    }
    void yeniPlatformKonumu()
    {
        Vector2 yeniPlatformKonumu = new Vector2();
        for (int i = 0; i < platformSayisi; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            yeniPlatformKonumu.x = Random.Range(-1.63f, 1.67f);
            yeniPlatformKonumu.y += Random.Range(1.7f, 2);
            tempPlatform.transform.position= yeniPlatformKonumu;
        }
    }
}
