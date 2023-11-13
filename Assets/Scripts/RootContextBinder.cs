using UnityEngine;
using SimpleInjector;
public class RootContextBinder:MonoBehaviour
{
    private Container container;
    private void Awake()
    {
        container = new Container();
        BindLogger(container);
        
        
    }

    private void BindLogger(Container con)
    {
#if UNITY_EDITOR
        con.Register<ILogger, UnityLogger>(Lifestyle.Singleton);
#elif UNITY_ANDROID
        container.Register<ILogger, AndroidLogger>(Lifestyle.Singleton);
#elif UNITY_IOS
        container.Register<ILogger, IOSLogger>(Lifestyle.Singleton);
#endif
    }

}
