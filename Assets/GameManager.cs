using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class StoryBlock {
    public string story;
    public string option1Text;
    public string option2Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;

    public StoryBlock(string story, string option1Text = "", string option2Text = "", 
    StoryBlock option1Block = null, StoryBlock option2Block = null) {
        this.story = story;
        this.option1Text = option1Text;
        this.option2Text = option2Text;
        this.option1Block = option1Block;
        this.option2Block = option2Block;
    }
}

public class GameManager : MonoBehaviour
{
    public Text MainText;
    public Button option1;
    public Button option2;

    StoryBlock currentBlock;

    static StoryBlock block1000 = new StoryBlock("the code function won't let us point to an incomplete array", "done", "temparary", block10, block10);

    static StoryBlock block60 = new StoryBlock("Harry goes in a bit deeper. The air gets colder, but soon the draft dies down. He leans back to exhale. he sits relaxed in his thoughts.", "you are dead", "you are dead up", block1000, block1000);
    static StoryBlock block50 = new StoryBlock("Harry climbs upon a shelf and proceeds to spark. at long liesurly length, he is dazed and drifting.  He is then shocked when he sees some one walk past him and into the cave.", "wait, then leave.", "follow this person.", block1000, block1000);
    static StoryBlock block40 = new StoryBlock("Harry saunters atop the boulder and pulls out his lighter. however, the breeze makes lighting up difficult.", "give up and go home.", "go deeper...", block20, block60);
    static StoryBlock block30 = new StoryBlock("Forth goes Harry, into the mouth of the cave. He scans for a good place to sit and light up", "go to boulder on left.", "climb to a rock shelf on right", block40, block50);
    static StoryBlock block23 = new StoryBlock("Young Harry finds himself back at the entrance of the cave, /n, but Harry just wants a quiet place to smoke this joint.", "Be good. Go Home", "go forth", block20, block30);

    static StoryBlock block22 = new StoryBlock("Game Over!", "replay", "Quit", block23, block10);
    static StoryBlock block20 = new StoryBlock("back you went, on home, no need for adventure", "Quit", "restart", block22, block23);
    static StoryBlock block10 = new StoryBlock("Young Harry knows about the rumors of treasure in the cave, /n, but Harry just wants a quiet place to smoke this joint.", "Be good. Go Home", "go forth", block20, block30);
   

    // Start is called before the first frame update
    void Start()
    {
        DisplayBlock(block10);
    }

    void DisplayBlock(StoryBlock block) 
    {
        MainText.text = block.story;
        option1.GetComponentInChildren<Text>().text = block.option1Text;
        option2.GetComponentInChildren<Text>().text = block.option2Text;

        currentBlock = block;
    }
    public void Button1Clicked() {
        DisplayBlock(currentBlock.option1Block);
    }

    public void Button2Clicked() {
        DisplayBlock(currentBlock.option2Block);
    }
}