using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinFunction : MonoBehaviour
{
    
    public Sprite[] coinsSides;
    public bool coinSpinning;
    public float rotateSpeed=500;
    public Animator coinAnimator;

    public TextMeshProUGUI tossResultText; 
    
    private int coinSide;
    // Start is called before the first frame update
    void Start()
    {
        tossResultText.text="Toss";
    }

    // Update is called once per frame
    private void FixedUpdate() {
        if(coinSpinning){
            coinSide=Random.Range(0,2);
            transform.Rotate( Vector3.right * rotateSpeed );
            gameObject.GetComponent<SpriteRenderer>().sprite=coinsSides[coinSide];
        }
    }
    
     public void SpinCoin(){
        tossResultText.text="";
        coinSpinning=true;
        coinAnimator.SetBool("Spinning", true);
     }
     public void StopFlip(){
         coinSpinning=false;
         //transform.rotation.x = new Vector2(0,0);
         //transform.Rotate(0,0,0);
         
         transform.localEulerAngles= new Vector3(0,0,0);
         coinAnimator.SetBool("Spinning", false);
     }
    public void ShowResult(){
        if(coinSide==0){
            tossResultText.text="Heads";
        }else{
            tossResultText.text="Tails";
        }
    }
}
