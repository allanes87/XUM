# XUM

## 1. Xamarin 3.0, Hello CSS

- Crear proyecto Xamarin de tipo "Blank Forms App".
- Actualizar paquete Nuget de "Xamarin.Forms" de todos los proyectos a v3.0.x
- Agregar archivo "Style.css"
- Marcar el archivo como "embedded resource"

![alt text](https://github.com/allanes87/XUM/blob/master/Screenshots/xamarin3_1.PNG)

- Referenciar nuestro CSS en una ContentPage

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
- Momento de aplicar nuestros conocimientos de CSS (editando 'style.css'). Por ejemplo podemos aplicar un background y padding a todos los ContentPage

```css
^ContentPage {
  background-color: lightgreen;
  padding: 20
}
```

### 1a. Selectores

- (^element): Este símbolo selecciona todos los elementos que contengan como 'clase base' el 'element'
```css
^Label {
    text-align: center;
    font-style: bold;
    font-size: 30;
    color: white;
}
```
- element>element
```css
stacklayout>label {
  color: blue;
}
```

### 1b. StyleId

- ID selector: Asignando un "StyleId" a los elementos Xaml podremos seleccionarlos en CSS
```xml
<StackLayout StyleId="LoginForm">
```
```css
#LoginForm {
    background-color: whitesmoke;
}
```

### 1c. StyleClass

- Class selector: Asignando un "StyleClass" a los elementos Xaml podremos trabajar con ellos en CSS
```xml
<Button Text="Login" StyleClass="primary"/>
```
```css
.primary {
    background-color: dodgerblue;
    color: #FFFFFF;
    font-size: 14;
    margin: 15 0;
}
```

### 1d. Elementos soportados
```css
color
background-color
font-family
font-size
font-style
height
width
border-color
border-width
visibility
opacity
text-align
margin - left | right | top | bottom
padding - left | right | top | bottom
```

## 2. SVG
[FFimageLoading](https://github.com/luberda-molinet/FFImageLoading/wiki/Xamarin.Forms-API)
[FFimageLoading SVG support](https://github.com/luberda-molinet/FFImageLoading/wiki/SVG-support)

