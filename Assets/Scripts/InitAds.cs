using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitAds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start(){}");
        IronSource.Agent.init ("a9efbced");
        Debug.Log("IronSource Agent has been Initiated");
    }

    void Update()
    {
        //IronSource.Agent.validateIntegration();
    }

    void OnEnable () {
        Debug.Log("OnEnable(){}");
        IronSourceEvents.onInterstitialAdReadyEvent += InterstitialAdReadyEvent;
        IronSourceEvents.onInterstitialAdLoadFailedEvent += InterstitialAdLoadFailedEvent;        
        IronSourceEvents.onInterstitialAdShowSucceededEvent += InterstitialAdShowSucceededEvent; 
        IronSourceEvents.onInterstitialAdShowFailedEvent += InterstitialAdShowFailedEvent; 
        IronSourceEvents.onInterstitialAdClickedEvent += InterstitialAdClickedEvent;
        IronSourceEvents.onInterstitialAdOpenedEvent += InterstitialAdOpenedEvent;
        IronSourceEvents.onInterstitialAdClosedEvent += InterstitialAdClosedEvent;
        Debug.Log("OnEnable(){} OUT");
    }

    //Invoked when the initialization process has failed.
    //@param description - string - contains information about the failure.
    void InterstitialAdLoadFailedEvent (IronSourceError error) {
    }
    //Invoked right before the Interstitial screen is about to open.
    void InterstitialAdShowSucceededEvent() {
    }
    //Invoked when the ad fails to show.
    //@param description - string - contains information about the failure.
    void InterstitialAdShowFailedEvent(IronSourceError error) {
    }
    // Invoked when end user clicked on the interstitial ad
    void InterstitialAdClickedEvent () {
    }
    //Invoked when the interstitial ad closed and the user goes back to the application screen.
    void InterstitialAdClosedEvent () {
    }
    //Invoked when the Interstitial is Ready to shown after load function is called
    void InterstitialAdReadyEvent() {
        Debug.Log("InterstitialAdReadyEvent(){}");
        IronSource.Agent.showInterstitial("EndGame");
        Debug.Log("You just watched EndGame");
    }
    //Invoked when the Interstitial Ad Unit has opened
    void InterstitialAdOpenedEvent() {
        Debug.Log("InterstitialAdOpenedEvent(){}");
    }

    public void LoadInterstitial() {
        Debug.Log("LoadInterstitial(){}");
        IronSource.Agent.loadInterstitial();
        Debug.Log("The ad has been loaded");
    }
}
