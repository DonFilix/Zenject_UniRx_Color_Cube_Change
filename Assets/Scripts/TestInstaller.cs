using System;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "TestInstaller", menuName = "Installers/TestInstaller")]
public class TestInstaller : ScriptableObjectInstaller<TestInstaller>
{

    public Player.Settings Player;
    // ... etc.

    public override void InstallBindings()
    {
        Container.BindInstances(Player);
    }
}

public class Player : ITickable
{
    readonly Settings _settings;
    Vector3 _position;

    public Player(Settings settings)
    {
        _settings = settings;
    }

    public void Tick()
    {
        _position += Vector3.forward * _settings.Speed;
    }
    [Serializable]
    public class Settings
    {
        public float Speed;
    }
}