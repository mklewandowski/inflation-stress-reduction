using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    bool startingIntro = false;

    float particleTimer = 0f;
    float particleTimerMax = .5f;

    // Start is called before the first frame update
    void Start()
    {
        HUDTitle.GetComponent<MoveNormal>().MoveDown();
        HUDFooter.GetComponent<MoveNormal>().MoveUp();
        HUDStart.GetComponent<MoveNormal>().MoveLeft();
        startingIntro = true;
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
        ParticlesCash.Play();
        ParticlesCoin.Play();
        particleTimer = particleTimerMax;
    }
}
