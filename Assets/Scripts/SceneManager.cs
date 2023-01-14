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

    bool startingIntro = false;

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
    }

    public void StartGame()
    {
        HUDTitle.GetComponent<MoveNormal>().MoveUp();
        HUDFooter.GetComponent<MoveNormal>().MoveDown();
        HUDStart.GetComponent<MoveNormal>().MoveLeft();
        HUDItemContainer1.GetComponent<MoveNormal>().MoveLeft();
    }
}
