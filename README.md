# 1.2 Entorno Unity 3D

Esta practica tiene como objetivo familiarizarse con la interfaz de Unity

## 1. Crear un proyecto Unity 3D básico que cumpla los siguientes requisitos:

### 1. Cargar la escena de prueba de los starter assets Third Person.

Lo primero será abrir un nuevo proyecto en **Unity** y en el Package Manager tendremos que importar el asset [Starter Assets -ThirdPerson](https://assetstore.unity.com/packages/essentials/starter-assets-thirdperson-updates-in-new-charactercontroller-pa-196526?srsltid=AfmBOop__8gMldwqqDKB6wuGe8HuW3qSYCCY8pPUHq_iwbpWsDcbrR8q).

![asset](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/StarterAsset3d.PNG)

Una vez importado en el proyecto, tendremos que ir a la escena **Playground** en ``Assets/StarterAssets/ThirdPersonController/Scenes/Playground``.

![playground](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/CapturaPlayground.PNG)

### 2. Conservar de la escena el personaje y elimina el entorno.

Eliminamos todo el entorno del escenario y conservamos el personaje.

![entorno](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/Punto2.PNG)

### 3. Incluye GameObjects del menú

Ahora incluiremos objetos al escenario, en este caso, un plano, un cubo y una esfera.

![objetos](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/Punto3.PNG)

### 4. Incluye GameObjects de la Asset Store

Para ello iremos a la Asset Store de Unity y elegiremos un asset con objetos, en nuestro caso [Sci-Fi Styled Modular Pack](https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913?srsltid=AfmBOooTZ1MAtxDySI9X6GnGh7VkUA0s8SRLcIvUSv5mpdVX1njEJBoW). Una vez añadido, lo importaremos a nuestro proyecto.

![asset2](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/Punto4.1.PNG)

Tras eso se añadirán algunos gameObjects que incluye como una cama y un escritorio al entorno.

![entorno](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/Punto4.2.PNG)

### 5. Convierte uno de los GameObjects incluido en el personaje

Utilizaremos el cubo añadido anteriormente y para poder hacerlo controlable, tendremos que añadir algunos componentes tales como **CharacterController**, **PlayerInput**, **ThirdPersonController** y **StarterAssetsInputs**

![personajeObjeto](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/Punto5.PNG)

### 6. Agregar una fuente de iluminación y configurarla con luz de algún color distinto del blanco

Dentro del gameObject **Directional Light** configuraremos la variable **color** a un tono distinto del blanco para resaltar el contraste.

![luz](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/Punto6.PNG)

### 7. Generar un script que muestre en consola un mensaje

Para esto crearemos un script que dependiendo de la tecla que pulsemos mostrará el mensaje y cada vez que colisione con un objeto del entorno.

![script](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/Punto7.PNG)

Se muestra un gif con la ejecución del juego.

![gif](https://github.com/Alu0101030562/Screenshots/blob/main/Screenshots/1.2EntornoUnity3D/GifEjecuci%C3%B3n1.2.gif)
