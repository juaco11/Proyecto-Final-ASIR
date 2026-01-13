FRUTERIA.API: BACKEND DE TRAZABILIDAD CON BLOCKCHAIN

    Este es el proyecto de servidor (Backend) para el sistema de trazabilidad de una frutería. Su función es recibir datos de los agricultores y transportistas, y guardarlos de forma segura en una base de datos inmutable usando tecnología Blockchain.

    
FICHA TÉCNICA 

    - Rol: Servidor backend
    - Lenguaje: C# 
    - Base de Datos: SQLite 
    - Seguridad: Hashing SHA-256 para integridad de datos
    - Protocolo: HTTP/HTTPS 
    - Puertos por defecto:
        HTTP: 5104
        HTTPS: 7199


¿COMO FUNCIONA EL SISTEMA?

El sistema no es una base de datos normal donde se puede editar y borrar. Funciona como un libro de registro donde solo se puede escribir.

  1. El Concepto de cadena: cada vez que guardamos un dato (un lote de tomates o un viaje de camión), creamos un bloque.
  Cada bloque contiene:

    - Datos: La información (kilos, temperatura, origen) en formato JSON.
    - Huella: Un código único calculado con SHA-256. Si cambias un solo bit de los datos, este código cambia radicalmente.
    - Huella anterior: El código del bloque anterior.

  ¿Por qué es seguro?
  
  Si un hacker modifica un dato antiguo en la base de datos, el hash de ese bloque cambiará. Como el bloque siguiente tiene guardado el hash antiguo, la cadena se rompe y el sistema detecta la manipulación.

  2. Base de datos con SQLite
    Usamos SQLite por sencillez. Toda la base de datos es un único archivo llamado blockchain.db que se crea automáticamente.
    - Tabla principal: bloques


PUNTOS DE ACCESO 

La API expone 3 puertas para que las aplicaciones web se conecten:

Método    URL                      Descripción
POST      /api/cosecha              Registro inicial. Recibe datos del agricultor y crea el primer bloque de un lote.
POST      /api/transporte           Logística. Recibe datos de sensores del camión y los añade a la cadena.
GET       /api/trazabilidad/{id}    Consulta. Busca toda la historia de un lote específico para mostrarla al cliente.


GUÍA DE DESPLIEGUE RÁPIDO

Requisitos
  - Tener instalado el SDK de .NET 8.0
  - Opcional: Visual Studio 2022 o VS Code

Cómo arrancar el servidor
  1. Abre una terminal en la carpeta del proyecto
  2. Ejecuta: dotnet run
  3. El servidor arrancará escuchando en http://localhost:5104
  4. La base de datos blockchain.db se creará sola la primera vez

Comprobación de estado
  Para ver si funciona sin usar la web, abre en tu navegador: http://localhost:5104/swagger.
  Verás un panel de control técnico (Swagger UI) para probar los endpoints manualmente.


Desarrollado por Joaquín García Carbonell como Proyecto Final de Segundo de ASIR.
