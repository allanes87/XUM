# XUM

## 1. Xamarin 3.0, Hello CSS

- Crear proyecto Xamarin de tipo "Blank Forms App".
- Actualizar paquete Nuget de "Xamarin.Forms" de todos los proyectos a v3.0.x
- Agregar archivo "Style.css"
- Marcar el archivo como "embedded resource"

![alt text](https://github.com/allanes87/XUM/blob/master/Screenshots/xamarin3_1.PNG)



```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XUM.Mobile.HelloCssView"
             Title="CSS">
    
    <ContentPage.Resources>
        <StyleSheet Source="Styles.css" />
    </ContentPage.Resources>

    <StackLayout>
        <!--Code here-->
    </StackLayout>
</ContentPage>
```


## 2. SVG
[FFimageLoading](https://github.com/luberda-molinet/FFImageLoading/wiki/Xamarin.Forms-API)
[FFimageLoading SVG support](https://github.com/luberda-molinet/FFImageLoading/wiki/SVG-support)

