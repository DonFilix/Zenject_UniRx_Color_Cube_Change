using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ColorInstaller", menuName = "Installers/ColorInstaller")]
public class ColorInstaller : ScriptableObjectInstaller<ColorInstaller>
{
    private CubeModel cubeModel;

    [Inject]
    void Construct()
    {
        cubeModel = new CubeModel("black");
    }
    public override void InstallBindings()
    {
        Container.BindInstance(cubeModel).AsSingle();
    }
}