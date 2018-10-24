using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
	public static int redScore = 0;
	public static int blueScore = 0;
	public int maxScore;

	public GameObject redPanel;
	public GameObject bluePanel;
	public GameObject startPanel;
	public GameObject options;
	public GameObject winPanel;

    [SerializeField]
	private Text blue;
	[SerializeField]
	private Text red;



	void Start(){
		redScore = 0;
		blueScore = 0;
		maxScore = 5;


	}
	
	public void startGame(){
		redPanel.SetActive (true);
		bluePanel.SetActive (true);
		options.SetActive (false);
		startPanel.SetActive (false);
		winPanel.SetActive (false);

		redScore = 0;
		blueScore = 0;
	}

    public void MaxUp() {
        maxScore++;
    }

    public void MaxDown() {
        if(maxScore > 1) {
            maxScore--;
        } else {
            return;
        }
    }

    public void setMax(float var){
		maxScore = (int) var;
	}
	public void setMax1(string var){
		int var1 = int.Parse (var);
		maxScore = var1;
	}
	public void scoreRed(){
		redScore++;
	}

	public void scoreBlue(){
		blueScore++;
	}

	public void stopGame(){
		options.SetActive (true);
		startPanel.SetActive (true);
		winPanel.SetActive (false);
    }

	

	void Update () {
		if(redScore >= maxScore){
			bluePanel.SetActive (false);
			redPanel.SetActive (false);
			winPanel.SetActive (true);


			red.text = redScore.ToString();
			blue.text = blueScore.ToString();

			redScore = 0;
			blueScore = 0;


		}

		if(blueScore >= maxScore){
			redPanel.SetActive (false);
			bluePanel.SetActive (false);
			winPanel.SetActive (true);


			red.text = redScore.ToString();
			blue.text = blueScore.ToString();

			redScore = 0;
			blueScore = 0;
		}
	}
}
