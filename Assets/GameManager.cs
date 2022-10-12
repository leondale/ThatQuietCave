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

    //the code function won't let us point to an incomplete array.
    static StoryBlock block1000 = new StoryBlock("  The End.\n At some point during  the ritual,  you lose consciousness.  And yet it seems, you have met your destiny. Your family will come looking. The priest will find them and do his dark deeds. You journey however ends here.", "done", "temparary", block10, block10);
    //static StoryBlock block550 = new StoryBlock("Chance to escape, varies based on which for treasure rooms you entered.\r\nYour attempt will fail.", "what option", "what option2", block1000, block1000);
    static StoryBlock block525 = new StoryBlock("The priest is upon me! So strong! So fast! I'm being dragged deeper into the cave, twisting into its bowels!\r\nThis is a convergence of the two tracks", "choice1", "choice2");

    static StoryBlock block700 = new StoryBlock("Some gold and a ritual knife.\r\nA true trove of treasure! Gold in uncountable amounts! Baubles and trinkets galore  and above it all a knife so encrusted and adorned it must have at some time been a Pharoah's favorite.  You fill your pockets,  you grasp the knife. You move on, with confidence.", "to Nexus", "to nexus", block525, block525);
    static StoryBlock block500 = new StoryBlock("Little glowing stone.\r\nAs you enter, you are flooded with pride, you feel amazing,  but a small glowing stone tells you with out it you'll just be normal again.  You stuff the stone into your pocket and move on like a champion!", "to Nexus", "to nexus", block525, block525);
    static StoryBlock block400 = new StoryBlock("The friendly cat.\r\nAt first nothing...and then, hugging the edge of the entrance,  a cat. A cat deep black like some sleek shadow. You move to meet the cat but it simply isn't there.... nevertheless,  you can still hear a purring....its emanating from everywhere...", "to Nexus", "to nexus", block525, block525);
    static StoryBlock block200 = new StoryBlock("The sea Quill.\r\nIn a darkened room there are two points of light. One that exits the room. One that is small and blue.....its...its a feather, within it the lapping of some ocean against a foreign shore. You can even hear the waves crashing.....", "to Nexus", "to nexus", block525, block525);

    //loop back leads to nexus. 
    static StoryBlock block70 = new StoryBlock("you try to just go on home, but to your shock, the entrance is sealed. it looks like it was never there. you panic, as is only right. ", "you are dead", "you are dead up", block1000, block1000);
    
    static StoryBlock block60 = new StoryBlock("You light up and inhale the magic flower that eases your mind. ahhhh. a private adventure. a time to stretch the mind, explore surroundings and take in this glorious life!", "go through intersting gap", "go down winding path", block200, block400);
    static StoryBlock block50 = new StoryBlock("YOLO! you think! you spark up and take a puff....at long last, you are dazed and drifting, deep in thought.  \n Suddenly, you hear something! it seems you see some one walk past, below and deeper into the cave. it takes a moment for him to pass and for you to climb down. you aim to investigate. He either went down that slope or around that twist.", "Down that Slope.", "Go around the twist.", block500, block700);
    //static StoryBlock block40 = new StoryBlock("Harry saunters atop the boulder and pulls out his lighter. however, the breeze makes lighting up difficult.", "give up and go home.", "go deeper...", block20, block60);
    
    static StoryBlock block30 = new StoryBlock("You saunter atop the boulder and pull out your lighter. it's nice up here, it crosses your mind that know one knows you're here. maybe you should go back home?", "take this chance to leave", "just go head smoke one", block70, block50);
    static StoryBlock block20 = new StoryBlock("a little deeper the breeze is alayed. The quiet of the cave is comforting if a little musty. you lean against the cave wall, but have second thoughts about this whole thing. ", "Do the responsible thing.", " Nah, smoke one", block70, block60);
    
    static StoryBlock block10 = new StoryBlock("You enter the quiet cave to smoke a joint. It's just a joint, but mom trips if she smells it. Plus its exams, you need to relax.\n you know about the treasure in the cave. rumors at most. \n To much breeze at the entrance of the cave. \n \nTo the left, deeper into the cave might work, or atop that boulder to the right...", "Go left, Deeper", "go right to boulder", block20, block30);
   

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