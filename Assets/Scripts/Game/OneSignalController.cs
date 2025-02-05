﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using OneSignalPush.MiniJSON;
using System;

public class OneSignalController : MonoBehaviour
{
    //private string appId = "ac77b1c0-12f5-4d32-b4b7-575d75538c08";
    //private static string extraMessage;
    //public string email = "Email Address";
    //public string externalId = "External User ID";

    //private static bool requiresUserPrivacyConsent = false;

    //void Start()
    //{
    //    extraMessage = null;

    //    // Enable line below to debug issues with setuping OneSignal. (logLevel, visualLogLevel)
    //    OneSignal.SetLogLevel(OneSignal.LOG_LEVEL.VERBOSE, OneSignal.LOG_LEVEL.NONE);

    //    // If you set to true, the user will have to provide consent
    //    // using OneSignal.UserDidProvideConsent(true) before the
    //    // SDK will initialize
    //    OneSignal.SetRequiresUserPrivacyConsent(requiresUserPrivacyConsent);

    //    // The only required method you need to call to setup OneSignal to receive push notifications.
    //    // Call before using any other methods on OneSignal (except setLogLevel or SetRequiredUserPrivacyConsent)
    //    // Should only be called once when your app is loaded.
    //    // OneSignal.Init(OneSignal_AppId);
    //    OneSignal.StartInit(appId)
    //        .HandleNotificationReceived(HandleNotificationReceived)
    //        .HandleNotificationOpened(HandleNotificationOpened)
    //        .HandleInAppMessageClicked(HandlerInAppMessageClicked)
    //        .EndInit();

    //    OneSignal.inFocusDisplayType = OneSignal.OSInFocusDisplayOption.Notification;
    //    OneSignal.permissionObserver += OneSignal_permissionObserver;
    //    OneSignal.subscriptionObserver += OneSignal_subscriptionObserver;
    //    OneSignal.emailSubscriptionObserver += OneSignal_emailSubscriptionObserver;

    //    var pushState = OneSignal.GetPermissionSubscriptionState();

    //    OneSignalInAppMessageTriggerExamples();
    //    OneSignalOutcomeEventsExamples();
    //}


    //// Examples of using OneSignal External User Id
    //private void OneSignalExternalUserIdCallback(Dictionary<string, object> results)
    //{
    //    // The results will contain push and email success statuses
    //    Console.WriteLine("External user id updated with results: " + Json.Serialize(results));

    //    // Push can be expected in almost every situation with a success status, but
    //    // as a pre-caution its good to verify it exists
    //    if (results.ContainsKey("push"))
    //    {
    //        Dictionary<string, object> pushStatusDict = results["push"] as Dictionary<string, object>;
    //        if (pushStatusDict.ContainsKey("success"))
    //        {
    //            Console.WriteLine("External user id updated for push with results: " + pushStatusDict["success"] as string);
    //        }
    //    }

    //    // Verify the email is set or check that the results have an email success status
    //    if (results.ContainsKey("email"))
    //    {
    //        Dictionary<string, object> emailStatusDict = results["email"] as Dictionary<string, object>;
    //        if (emailStatusDict.ContainsKey("success"))
    //        {
    //            Console.WriteLine("External user id updated for email with results: " + emailStatusDict["success"] as string);
    //        }
    //    }
    //}

    //// Examples of using OneSignal In-App Message triggers
    //private void OneSignalInAppMessageTriggerExamples()
    //{
    //    // Add a single trigger
    //    OneSignal.AddTrigger("key", "value");

    //    // Get the current value to a trigger by key
    //    var triggerKey = "key";
    //    var triggerValue = OneSignal.GetTriggerValueForKey(triggerKey);
    //    String output = "Trigger key: " + triggerKey + " value: " + (String)triggerValue;
    //    Console.WriteLine(output);

    //    // Add multiple triggers
    //    OneSignal.AddTriggers(new Dictionary<string, object>() { { "key1", "value1" }, { "key2", 2 } });

    //    // Delete a trigger
    //    OneSignal.RemoveTriggerForKey("key");

    //    // Delete a list of triggers
    //    OneSignal.RemoveTriggersForKeys(new List<string>() { "key1", "key2" });

    //    // Temporarily puase In-App messages; If true is passed in.
    //    // Great to ensure you never interrupt your user while they are in the middle of a match in your game.
    //    OneSignal.PauseInAppMessages(false);
    //}

    //private void OneSignalOutcomeEventsExamples()
    //{
    //    OneSignal.SendOutcome("normal_1");
    //    OneSignal.SendOutcome("normal_2", (OSOutcomeEvent outcomeEvent) => {
    //        printOutcomeEvent(outcomeEvent);
    //    });

    //    OneSignal.SendUniqueOutcome("unique_1");
    //    OneSignal.SendUniqueOutcome("unique_2", (OSOutcomeEvent outcomeEvent) => {
    //        printOutcomeEvent(outcomeEvent);
    //    });

    //    OneSignal.SendOutcomeWithValue("value_1", 3.2f);
    //    OneSignal.SendOutcomeWithValue("value_2", 3.2f, (OSOutcomeEvent outcomeEvent) => {
    //        printOutcomeEvent(outcomeEvent);
    //    });
    //}

    //private void printOutcomeEvent(OSOutcomeEvent outcomeEvent)
    //{
    //    Console.WriteLine(outcomeEvent.session + "\n" +
    //            string.Join(", ", outcomeEvent.notificationIds) + "\n" +
    //            outcomeEvent.name + "\n" +
    //            outcomeEvent.timestamp + "\n" +
    //            outcomeEvent.weight);
    //}

    //private void OneSignal_subscriptionObserver(OSSubscriptionStateChanges stateChanges)
    //{
    //    Debug.Log("SUBSCRIPTION stateChanges: " + stateChanges);
    //    Debug.Log("SUBSCRIPTION stateChanges.to.userId: " + stateChanges.to.userId);
    //    Debug.Log("SUBSCRIPTION stateChanges.to.subscribed: " + stateChanges.to.subscribed);
    //}

    //private void OneSignal_permissionObserver(OSPermissionStateChanges stateChanges)
    //{
    //    Debug.Log("PERMISSION stateChanges.from.status: " + stateChanges.from.status);
    //    Debug.Log("PERMISSION stateChanges.to.status: " + stateChanges.to.status);
    //}

    //private void OneSignal_emailSubscriptionObserver(OSEmailSubscriptionStateChanges stateChanges)
    //{
    //    Debug.Log("EMAIL stateChanges.from.status: " + stateChanges.from.emailUserId + ", " + stateChanges.from.emailAddress);
    //    Debug.Log("EMAIL stateChanges.to.status: " + stateChanges.to.emailUserId + ", " + stateChanges.to.emailAddress);
    //}

    //// Called when your app is in focus and a notificaiton is recieved.
    //// The name of the method can be anything as long as the signature matches.
    //// Method must be static or this object should be marked as DontDestroyOnLoad
    //private static void HandleNotificationReceived(OSNotification notification)
    //{
    //    OSNotificationPayload payload = notification.payload;
    //    string message = payload.body;

    //    print("GameControllerExample:HandleNotificationReceived: " + message);
    //    print("displayType: " + notification.displayType);
    //    extraMessage = "Notification received with text: " + message;

    //    Dictionary<string, object> additionalData = payload.additionalData;
    //    if (additionalData == null)
    //        Debug.Log("[HandleNotificationReceived] Additional Data == null");
    //    else
    //        Debug.Log("[HandleNotificationReceived] message " + message + ", additionalData: " + Json.Serialize(additionalData) as string);
    //}

    //// Called when a notification is opened.
    //// The name of the method can be anything as long as the signature matches.
    //// Method must be static or this object should be marked as DontDestroyOnLoad
    //public static void HandleNotificationOpened(OSNotificationOpenedResult result)
    //{
    //    OSNotificationPayload payload = result.notification.payload;
    //    string message = payload.body;
    //    string actionID = result.action.actionID;

    //    print("GameControllerExample:HandleNotificationOpened: " + message);
    //    extraMessage = "Notification opened with text: " + message;

    //    Dictionary<string, object> additionalData = payload.additionalData;
    //    if (additionalData == null)
    //        Debug.Log("[HandleNotificationOpened] Additional Data == null");
    //    else
    //        Debug.Log("[HandleNotificationOpened] message " + message + ", additionalData: " + Json.Serialize(additionalData) as string);

    //    if (actionID != null)
    //    {
    //        // actionSelected equals the id on the button the user pressed.
    //        // actionSelected will equal "__DEFAULT__" when the notification itself was tapped when buttons were present.
    //        extraMessage = "Pressed ButtonId: " + actionID;
    //    }
    //}

    //public static void HandlerInAppMessageClicked(OSInAppMessageAction action)
    //{
    //    String logInAppClickEvent = "In-App Message Clicked: " +
    //        "\nClick Name: " + action.clickName +
    //        "\nClick Url: " + action.clickUrl +
    //        "\nFirst Click: " + action.firstClick +
    //        "\nCloses Message: " + action.closesMessage;

    //    print(logInAppClickEvent);
    //    extraMessage = logInAppClickEvent;
    //}
}
