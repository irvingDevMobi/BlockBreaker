using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public int maxHits;
    public Sprite[] hitSprites;

    private LevelManager levelManager;
    private int timesHit;

	// Use this for initialization
	void Start () 
    {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        timesHit++;
        if(timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    private void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    // TODO: Remove this method once we can actually win!!
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
