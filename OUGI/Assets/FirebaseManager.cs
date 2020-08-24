using System;
using System.Collections;
using System.Collections.Generic;
using Firebase;
using Firebase.Auth;
using Firebase.Extensions;
using Firebase.Storage;
using Firebase.Database;
using UnityEngine;
using UnityEngine.Events;

public class FirebaseManager : MonoBehaviour
{
    private static FirebaseManager _instance;

    public static FirebaseManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = LazyInitFirebaseManager();
            }

            return _instance;
        }
    }

    private static FirebaseManager LazyInitFirebaseManager()
    {
        throw new NotImplementedException();
    }

    private FirebaseAuth _auth;

    public FirebaseAuth Auth
    {
        get
        {
            if (_auth == null)
            {
                _auth = FirebaseAuth.GetAuth(App);
            }

            return _auth;
        }
    }

    private FirebaseApp _app;

    public FirebaseApp App
    {
        get
        {
            if (_app == null)
            {
                _app = GetAppSychronous();
            }

            return _app;
        }
    }

    private FirebaseApp GetAppSychronous()
    {
        throw new NotImplementedException();
    }

    public UnityEvent OnFirebaseInitialized = new UnityEvent();

    private async void Awake()
    {
        if (_instance == null)
        {
            DontDestroyOnLoad(gameObject);
            _instance = this;
            var dependencyResult = await FirebaseApp.CheckAndFixDependenciesAsync();
            if (dependencyResult == DependencyStatus.Available)
            {
                _app = FirebaseApp.DefaultInstance;
                OnFirebaseInitialized.Invoke();
            }
            else
            {
                Debug.LogError($"Failed to Initialize Firebase with {dependencyResult}");
            }
        }
        else
        {
            Debug.LogError($"An instance of {nameof(FirebaseManager)} already exists!");
        }
    }

    private void OnDestory()
    {
        _auth = null;
        _app = null;
        if (_instance == this)
        {
            _instance = null;
        }
    }
}
