using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public static int breakableCount = 0;

    public Sprite[] hitSprites;

    private LevelManager levelManager;
    private int timesHit;
    private bool isBreakable;

	// Use this for initialization
	void Start () 
    {
        isBreakable = this.tag == "Breakable";
        // Keep track of breakable bricks
        if(isBreakable)
        {
            breakableCount++;
        }
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(this.tag == "Breakable" )
        {
            HandleHits();
        }
    }

    private void HandleHits()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            breakableCount--;
            Destroy(gameObject);
            levelManager.BrickDestroyed();
        }
        else
        {
            LoadSprites();
        }
    }

    private void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }

    // TODO: Remove this method once we can actually win!!
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
