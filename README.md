# Proyecto-Final-ASIR
CosechApp: Trazabilidad alimentaria con Blockchain

CosechApp es una plataforma completa de trazabilidad que permite seguir el ciclo de vida de productos agrícolas desde la cosecha hasta el consumidor final, garantizando la inmutabilidad de los datos mediante tecnología Blockchain.


Características principales:
- Blockchain privado: Implementación propia de una cadena de bloques enlazada criptográficamente para evitar la manipulación de datos.
- Trazabilidad completa: Registro de eventos de cosecha (origen) y transporte (logística).
- IoT simulado: Registro de telemetría de transporte (temperatura, humedad y sensores de impacto).
- Acceso universal: Generación de códigos QR dinámicos para que el cliente final verifique el recorrido del producto desde su móvil.
- Alertas inteligentes: Aviso visual al consumidor si el producto ha sufrido golpes o rotura de la cadena de frío.


Tecnologías utilizadas:
- Este proyecto ha sido desarrollado en Visual Studio 2022 siguiendo una arquitectura de N-Capas:
  - Backend: ASP.NET Core Web API (.NET 8).
  - Frontend: ASP.NET Core Razor Pages + Bootstrap 5.
  - Base de datos: SQLite + Entity Framework Core.
  - Librerías clave: QRCoder (Generación de QR).
  - System.Security.Cryptography (Hashing SHA256).
  - Newtonsoft.Json / System.Text.Json (Serialización de bloques).


Arquitectura del sistema:
- La solución se divide en tres proyectos:
  1. Fruteria.API: El cerebro del sistema. Gestiona la base de datos blockchain.db, valida los hashes y expone los endpoints REST.

  2. Fruteria.WebAgricultor: La interfaz de usuario. Permite a agricultores y transportistas registrar eventos y genera las etiquetas QR.

  3. Fruteria.Modelos: Biblioteca de clases compartida que define la estructura de datos (EventoCosecha, EventoTransporte, Bloque).


Capturas de pantalla:
  1. Panel del Agricultor
  El agricultor registra el origen y cantidad. El sistema genera un QR único.
(Aquí puedes subir una imagen de tu pantalla verde con el QR)

  2. Panel del Transportista
  Registro de condiciones del viaje (temperatura, humedad y golpes).
(Aquí puedes subir una imagen del formulario del camión)

  3. Vista del Cliente (Timeline)
  Lo que ve el consumidor al escanear el QR.
(Aquí puedes subir una imagen de la línea de tiempo con las alertas)


Instalación y puesta en marcha:
Sigue estos pasos para ejecutar el proyecto en local:
  1. Clonar el repositorio: git clone [https://github.com/TU_USUARIO/AgroChain.git](https://github.com/TU_USUARIO/AgroChain.git)

  2. Abrir en Visual Studio: Abre el archivo Fruteria.sln.
  3. 
  4. Configurar Inicio múltiple: Haz clic derecho en la Solución -> Propiedades -> Proyecto de inicio -> Varios proyectos de inicio.
    · Fruteria.API: Iniciar.
    · Fruteria.WebAgricultor: Iniciar.

  4.Ejecutar: Pulsa F5. La base de datos se creará automáticamente.


Probando con el móvil:
Para escanear los QR desde un móvil en la misma red Wi-Fi:
  1. Abre el puerto 5047 (o el que use tu web) en el Firewall de Windows.
  2. En Index.cshtml.cs, cambia la variable miIp por tu IP local.
  3. Ya estaría listo para ser escaneado

Desarrollado por Joaquín García Carbonell como Proyecto Final de Segundo de ASIR.
