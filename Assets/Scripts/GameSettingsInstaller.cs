using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
{
   public class ChangeColor : MonoBehaviour
   {
       public Material[] Materials;
       public Renderer Renderer;

       private  int index = 1;

       public void buttonPressed()
       {
           Renderer.sharedMaterial = Materials [index];
       }
      
    }
   
    public override void InstallBindings()
    {
       // Container.Bind<ChangeColor>().To<colors1>().AsSingle();
        //Container.Bind<IColor>().To<colors2>().AsSingle();
        //Container.Bind<IColor>().To<colors3>().AsSingle();
        //Container.Bind<Material>().To<>(Material).AsSingle().WhenInjectedInto<Material>();
    }

   
}



public interface IColor
{

}