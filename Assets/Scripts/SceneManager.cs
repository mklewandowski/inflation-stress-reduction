using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    GameObject HUDTitle;
    [SerializeField]
    GameObject HUDFooter;
    [SerializeField]
    GameObject HUDStart;

    [SerializeField]
    GameObject HUDItemContainer1;

    [SerializeField]
    ParticleSystem ParticlesCash;
    [SerializeField]
    ParticleSystem ParticlesCoin;

    [SerializeField]
    Sprite[] ItemSprites;
    [SerializeField]
    string[] ItemNames;
    [SerializeField]
    int[] ItemIdealPrices;

    [SerializeField]
    TextMeshProUGUI HUDItemName;
    [SerializeField]
    GameObject HUDItemImage;
    [SerializeField]
    TextMeshProUGUI HUDItemPrice;
    [SerializeField]
    GameObject HUDInstructions;
    [SerializeField]
    GameObject HUDDeflated;
    [SerializeField]
    GameObject HUDNext;

    bool startingIntro = false;

    float particleTimer = 0f;
    float particleTimerMax = .5f;

    int itemIndex = 0;
    int currentPrice = 0;

    // Start is called before the first frame update
    void Start()
    {
        HUDTitle.GetComponent<MoveNormal>().MoveDown();
        HUDFooter.GetComponent<MoveNormal>().MoveUp();
        HUDStart.GetComponent<MoveNormal>().MoveLeft();
        startingIntro = true;

        SetItem();
    }

    void SetItem()
    {
        itemIndex = Random.Range(0, ItemNames.Length);
        currentPrice = Random.Range(ItemIdealPrices[itemIndex] * 30, ItemIdealPrices[itemIndex] * 50);
        HUDItemPrice.text = "Price: $" + currentPrice;
        HUDItemName.text = ItemNames[itemIndex];
        HUDItemImage.GetComponent<Image>().sprite = ItemSprites[itemIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (startingIntro && !HUDStart.GetComponent<MoveNormal>().IsMoving())
        {
            startingIntro = false;
            HUDStart.GetComponent<MoveNormal>().SetNewLeftEndPos(new Vector2(-1000f, 0));
        }

        if (particleTimer > 0)
        {
            particleTimer -= Time.deltaTime;
            if (particleTimer <= 0)
            {
                ParticlesCash.Stop();
                ParticlesCoin.Stop();
            }
        }
    }

    public void StartGame()
    {
        HUDTitle.GetComponent<MoveNormal>().MoveUp();
        HUDFooter.GetComponent<MoveNormal>().MoveDown();
        HUDStart.GetComponent<MoveNormal>().MoveLeft();
        HUDItemContainer1.GetComponent<MoveNormal>().MoveLeft();
    }

    public void Deflate()
    {
        HUDItemImage.GetComponent<GrowAndShrink>().StartEffect();
        ParticlesCash.Play();
        ParticlesCoin.Play();
        particleTimer = particleTimerMax;

        int priceDecrement = Random.Range(ItemIdealPrices[itemIndex] * 1, ItemIdealPrices[itemIndex] * 5);
        currentPrice = Mathf.Max(currentPrice - priceDecrement, ItemIdealPrices[itemIndex]);
        HUDItemPrice.text = "Price: $" + currentPrice;
    }
}
