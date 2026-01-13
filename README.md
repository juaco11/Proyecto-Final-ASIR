# Proyecto-Final-ASIR

FRUTERIA.WEBAGRICULTOR (FRONTEND)
  Fruteria.WebAgricultor es la interfaz de usuario web del sistema CosechApp. Desarrollada con ASP.NET Core Razor Pages, proporciona una experiencia visual amigable para los agricultores, transportistas y clientes finales.

  Su objetivo es ocultar la complejidad técnica del Blockchain y ofrecer formularios sencillos e intuitivos, accesibles desde cualquier dispositivo.

DISEÑO Y EXPERIENCIA DE USAURIO
  El proyecto utiliza Bootstrap 5 junto con CSS para crear una página web visual moderna y profesional.
    - Paleta de colores del agricultor: Tonos naranja pastel, crema y marrón, recordando a la tierra y los productos frescos.
    - Paleta de colores del transportista: Tonos cálidos combinados con detalles técnicos, diferenciando el rol logístico.
    - Responsividad: Diseño totalmente adaptable, para que pueda usarse cómodamente desde el campo o la cabina del camión.


MAPA DEL SITIO

  La aplicación web consta de tres secciones principales:
  
    1. Panel del agricultor 
    Es el punto de entrada para el productor.
      - Función: Registrar el origen de un nuevo lote.
      - Datos: Identificación del agricultor, variedad de fruta, kilos y finca de origen.
      - Salida: Genera automáticamente un QR en pantalla.
      - Tecnología: Librería QRCoder para generar la imagen en tiempo real.

    2. Panel del transportista 
    Herramienta de logística para el seguimiento del envío.
      - Función: Añadir eventos de transporte a un lote existente.
      - Datos: Matrícula, ubicación GPS, temperatura y humedad.
      - IoT simulado: Interruptor para registrar alertas de impacto.
      - Conexión: Se vincula con el lote original mediante el LoteID.

    3. Vista del cliente
    Página pública de trazabilidad para el consumidor final.
      - Acceso: Se accede escaneando el QR del producto.
      - Visualización: Muestra una línea de tiempo con toda la historia del producto.
      - Alertas: Destaca visualmente si se rompió la cadena de frío o hubo golpes.


DETALLES TÉCNICOS DE IMPLEMENTACIÓN


    - Comunicación con la API: El frontend no tiene acceso directo a la base de datos. Utiliza HttpClient y IHttpClientFactory para comunicarse con el backend.
    - Configuración de Red: Para que el código QR sea escaneable desde dispositivos móviles reales, la aplicación debe ser accesible externamente.
      - Localhost: Solo funciona en el mismo PC.
      - IP local: Se configura la IP del adaptador Wi-Fi para permitir acceso en la misma red LAN.
      - Túneles: Se utilizan para pruebas desde internet.

    - Estructura de archivos clave:
    
      /Pages
      ├── Index.cshtml        # HTML del formulario de cosecha + visualización QR

      
      ├── Index.cshtml.cs     # Lógica C# (generación QR y llamada a la API)

      
      ├── Transporte.cshtml   # HTML del formulario de transporte

      
      ├── Transporte.cshtml.cs # Lógica C# (Envío de datos de sensores)

      
      ├── Cliente.cshtml      # HTML del timeline para el consumidor

      
      └── Cliente.cshtml.cs   # Lógica C# (Lectura y formateo del historial)

      
      /wwwroot

      
      ├── logo.png            # Logo de la aplicación

      
      └── camion.png          # Icono para la sección de transporte


DEPENDENCIAS (NuGet)


    - QRCoder: Generación de códigos QR en formato PNG/Base64.
    - System.Net.Http.Json: Extensiones para enviar y recibir objetos JSON fácilmente a través de HTTP.
