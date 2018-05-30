using UnityEngine;
using Zenject;
using System.Collections.Generic;
using UnityEngine.Experimental.UIElements;

[CreateAssetMenu(fileName = "ColorInstaller", menuName = "Installers/ColorInstaller")]
public class ColorInstaller : ScriptableObjectInstaller<ColorInstaller>
{
    private CubeModel cubeModel;
    public List<Material> Materials;
    [Inject]
    void Construct()
    {
        cubeModel = new CubeModel(Color.white);
    }

    public override void InstallBindings()
    {
        Container.BindInstance(cubeModel).AsSingle();
        Container.BindInstance(Materials).AsSingle();
    }
}