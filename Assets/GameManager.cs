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

    static StoryBlock block6 = new StoryBlock("Harry goes in a bit deeper. The air gets colder, but soon the draft dies down. He leans back to exhale. he sits relaxed in his thoughts.", "you are dead", "you are dead up");
    static StoryBlock block5 = new StoryBlock("Harry climbs upon a shelf and proceeds to spark. at long liesurly length, he is dazed and drifting.  He is then shocked when he sees some one walk past him and into the cave.", "wait, then leave.", "follow this person.");
    static StoryBlock block4 = new StoryBlock("Harry saunters atop the boulder and pulls out his lighter. however, the breeze makes lighting up difficult.", "give up and go home.", "go deeper...", block2, block6);
    static StoryBlock block3 = new StoryBlock("Forth goes Harry, into the mouth of the cave. He scans for a good place to sit and light up", "go to boulder on left.", "climb to a rock shelf on right", block4, block5);
    static StoryBlock block2 = new StoryBlock("back you went, on home, no need for adventure", "Quit", "restart", block0, block1);
    static StoryBlock block1 = new StoryBlock("Young Harry knows about the rumors of treasure in the cave, /n, but Harry just wants a quiet place to smoke this joint.", "Be good. Go Home", "go forth", block2, block3);
    static StoryBlock block0 = new StoryBlock("Game Over!");

    // Start is called before the first frame update
    void Start()
    {
        DisplayBlock(block1);
    }

    void DisplayBlock(StoryBlock block) {
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