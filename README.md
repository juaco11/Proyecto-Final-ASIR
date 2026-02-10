# Bitácora de desarrollo semanal: Proyecto AgroChain

Este documento registra la evolución cronológica del sistema de trazabilidad AgroChain durante sus 12 semanas de desarrollo, detallando las actividades, modificaciones y generaciones de código realizadas semana a semana.


**Semana 1: Lógica del Blockchain**

Objetivo: Crear el motor criptográfico base.

  - Desarrollo: Implementación de las clases Bloque y Blockchain en una aplicación de consola.

  - Seguridad: Programación del algoritmo de hash SHA-256 para enlazar bloques.

  - Pruebas: Verificación de integridad de la cadena en memoria.


**Semana 2: Arquitectura del sistema**

Objetivo: Migrar de consola a una arquitectura web escalable.

  - Estructura: División de la solución en capas:

    - Fruteria.Modelos (Biblioteca de clases)

    - Fruteria.API (Servidor)

    - Fruteria.WebAgricultor (Cliente)

  - Definición de datos: Creación de los modelos base (EventoCosecha).


**Semana 3: Persistencia de datos**

Objetivo: Que los datos sobrevivan al reinicio.

  - Tecnología: Instalación de Entity Framework Core y SQLite.

  - Implementación:

    - Creación de BlockchainDbContext.

    - Configuración de la inyección de dependencias en Program.cs.

    - Automatización de la creación de la base de datos.


**Semana 4: Desarrollo de la API REST**

Objetivo: Exponer la lógica al exterior.

  - Endpoints: Creación de controladores.

  - Funcionalidad: Programación del endpoint POST /api/cosecha para recibir datos y firmar bloques.

  - Validación: Pruebas de endpoints usando Swagger UI.


**Semana 5: Interfaz del agricultor**

Objetivo: Primera interfaz de usuario utilizable.

  - Tecnología: Desarrollo con Razor Pages.

  - Implementación:

    - Formulario de registro de cosecha.

    - Conexión HTTP (HttpClient) con la API.

    - Feedback visual de éxito y error al usuario.


**Semana 6: Módulo de logística (Transporte)**

Objetivo: Ampliar la trazabilidad más allá del origen.

  - Backend:

    - Nuevo modelo EventoTransporte.

    - Nuevo endpoint POST /api/transporte con lógica de enlace al bloque anterior.

  - Frontend: Creación de la página Transporte.cshtml.

**Semana 7: Simulación IoT**

Objetivo: Enriquecer los datos con sensores.

  - Funcionalidad:

    - Añadidos campos de telemetría: temperatura y humedad.

    - Implementación de lógica de alertas.

  - UI: Diseño de controles específicos para los sensores.

**Semana 8: Identidad digital (Códigos QR) - Parte 1**

Objetivo: Generación de etiquetas.

  - Integración: Instalación de la librería QRCoder.

  - Prototipo: Implementación inicial donde el QR se generaba en la fase del Agricultor.

  - Problema detectado: El flujo no era lógico para la etiqueta final de venta.

**Semana 9: Refactorización de flujo y QR**

Objetivo: Corregir el proceso de etiquetado.

  - Cambio: Se movió la generación del QR al final de la fase de Transporte.

  - Resultado: El Agricultor ahora genera un ID de lote, y el Transportista genera el QR final que enlaza a la vista del cliente.

**Semana 10: Despliegue y acceso móvil**

Objetivo: Pruebas en entorno real (fuera del PC).

  - Redes:

    - Configuración de launchSettings.json para escuchar en 0.0.0.0.

    - Apertura de puertos en Firewall de Windows (5047/5104).

    - Túneles: Configuración de Dev Tunnels para permitir acceso público vía 4G/5G.

**Semana 11: Monitorización y transparencia**

Objetivo: Demostrar la veracidad del Blockchain.

  - Desarrollo: Creación del Monitor de Blockchain (Monitor.cshtml).

  - Visualización: Interfaz estilo técnico que muestra los hashes en crudo y los enlaces JSON para auditoría en tiempo real.

**Semana 12: Diseño final y entrega**

Objetivo: Pulido visual y documentación.

  - UI/UX:

    - Rediseño completo de la interfaz con paletas de colores personalizadas.

    - Agricultor: Página donde predomina el naranja suave.

    - Transportista: Página donde predomina el marrón claro.

    - Documentación: Redacción de manuales técnicos, diagramas de arquitectura y este historial de cambios.

Desarrollado por Joaquín García Carbonell como Proyecto Final de Segundo de ASIR.
