# File-Explorer

Un explorador de archivos simple y potente, desarrollado para ofrecer una gestión de archivos y directorios intuitiva y eficiente.

## Descripción General

File-Explorer es una aplicación de escritorio moderna que permite a los usuarios navegar por el sistema de archivos, visualizar el contenido de los directorios y realizar operaciones esenciales con archivos y carpetas. La interfaz de usuario está construida con Angular, proporcionando una experiencia fluida y reactiva, mientras que la lógica del backend se maneja con .NET Core, asegurando robustez y rendimiento.

## Características Principales

*   **Navegación Intuitiva:** Explore su sistema de archivos con una estructura de árbol de directorios clara y fácil de usar.
*   **Visualización Detallada:** Vea el contenido de las carpetas, incluyendo detalles de archivos y previsualizaciones (si aplica).
*   **Operaciones Básicas de Archivos:** (Añade aquí más características a medida que las desarrolles, por ejemplo: copiar, pegar, renombrar, eliminar archivos/carpetas, crear nuevas carpetas, búsqueda de archivos, etc.)

## Vistazo a la Aplicación

*(Aquí puedes añadir una captura de pantalla general de la aplicación)*

`![Vista Principal de File-Explorer](ruta/a/tu/imagen_principal.png)`

## Tecnologías Utilizadas

*   **Frontend:** Angular
*   **Backend:** .NET Core

## Requisitos Previos

Para compilar y ejecutar este proyecto, necesitarás:

*   [.NET SDK](https://dotnet.microsoft.com/download) (Se recomienda la versión X.X o superior)
*   [Node.js y npm](https://nodejs.org/) (Para la parte de Angular, se recomienda la versión X.X de Node y X.X de npm o superior)
*   Angular CLI: `npm install -g @angular/cli` (Versión X.X o superior)
*   Visual Studio 2019/2022 (Opcional, pero recomendado para el desarrollo de .NET)
*   Un editor de código como Visual Studio Code (Recomendado para el desarrollo de Angular)

## Instalación y Ejecución

Sigue estos pasos para poner en marcha el proyecto:

1.  **Clona el repositorio:**
    ```bash
    git clone <URL_DEL_REPOSITORIO>
    cd File-Explorer
    ```

2.  **Configuración del Backend (.NET Core):**
    *   Navega al directorio del proyecto backend (donde se encuentra el archivo `.csproj`):
        ```bash
        cd src/File-Explorer.Api # Ajusta esta ruta si es diferente
        ```
    *   Restaura las dependencias:
        ```bash
        dotnet restore
        ```
    *   Ejecuta la API (esto podría variar según tu configuración):
        ```bash
        dotnet run
        ```

3.  **Configuración del Frontend (Angular):**
    *   En una nueva terminal, navega al directorio del proyecto frontend:
        ```bash
        cd src/File-Explorer.Web # Ajusta esta ruta si es diferente
        ```
    *   Instala las dependencias:
        ```bash
        npm install
        ```
    *   Inicia el servidor de desarrollo de Angular:
        ```bash
        ng serve --open
        ```

    La aplicación debería abrirse automáticamente en tu navegador predeterminado.

## Uso

Una vez que la aplicación esté en ejecución, podrás:

*   Navegar por el árbol de directorios en el panel izquierdo.
*   Ver el contenido de la carpeta seleccionada en el panel principal.
*   *(Añade aquí instrucciones más detalladas sobre cómo usar las diferentes características)*

*(Aquí puedes añadir capturas de pantalla de características específicas)*

`![Navegación de Directorios](ruta/a/tu/imagen_navegacion.png)`

`![Visualización de Archivos](ruta/a/tu/imagen_archivos.png)`

## Contribuir

¡Las contribuciones son bienvenidas! Si deseas contribuir, por favor:

1.  Haz un Fork del proyecto.
2.  Crea tu Feature Branch (`git checkout -b feature/AmazingFeature`).
3.  Realiza tus Commits (`git commit -m 'Add some AmazingFeature'`).
4.  Haz Push a la Branch (`git push origin feature/AmazingFeature`).
5.  Abre un Pull Request.

Por favor, abre un *issue* para discutir cambios importantes antes de realizar un *pull request*.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles (si añades uno).