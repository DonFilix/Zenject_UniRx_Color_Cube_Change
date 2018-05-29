using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ColorsInstaller", menuName = "Installers/ColorsInstaller")]
public class ColorsInstaller : ScriptableObjectInstaller<ColorsInstaller>
{
    public override void InstallBindings()
    {
    }
}