Manual Técnico - Proyecto "Narices Frías"
Introducción:
Este manual proporciona detalles técnicos del sistema desarrollado para el refugio "Narices Frías". Incluye información sobre la gestión del refugio y administración de la veterinaria de este
Descripción del proyecto:
El sistema permite programar citas de adopción, enviando confirmaciones por correo electrónico. También administra actividades benéficas, con opciones para añadir imágenes y seguimiento de recaudaciones. Los roles de usuario son: admin, cajero y médico.
Roles / Integrantes:
Flavio Fusi Escalante/ DB Architect
Alejandro Pariente Merida/ Git Master
Luis Mancilla Campero/ Developer
Nicolas Barrientos Martinez/Developer
Arquitectura del software:
Desarrollado en ASP.NET con C#, la arquitectura sigue un modelo DAO(Data Access Object).Los componentes principales incluyen módulos para adopciones, actividades benéficas, autenticación de usuarios y acceso a la base de datos SQL Server.
Requisitos del sistema:
Requerimientos de Hardware (cliente): Ordenador con al menos 2GB de RAM y conexión a Internet. Requerimientos de Software (cliente): Navegador actualizado compatible con ASP.NET. Requerimientos de Hardware (server/ hosting/BD): Servidor con al menos 4GB de RAM. Requerimientos de Software (server/ hosting/BD): Sistema operativo compatible con ASP.NET, SQL Server.
Instalación y configuración:
Para la instalación del sistema no necesitara más que conexión a internet y la url de la pagina la cual se proporciona mediante el equipo.
Instalación del Software:
Descarga de Recursos: Proporciona enlaces para descargar el paquete de instalación del software necesario, incluyendo versiones específicas de ASP.NET, Visual Studio, SQL Server Management Studio, entre otros.
Guía de Instalación: Detalla los pasos específicos para la instalación de cada componente del software en el entorno de desarrollo, incluyendo ASP.NET, Visual Studio y SQL Server.
Configuración de Componentes:
Configuración de ASP.NET y Visual Studio: Instrucciones para configurar el entorno de desarrollo en Visual Studio, incluyendo la creación de proyectos ASP.NET, configuración de la estructura de archivos y ajustes iniciales.
Configuración de SQL Server: Pasos detallados para configurar la instancia de SQL Server, incluyendo la creación de bases de datos, tablas y definición de esquemas necesarios para el funcionamiento del sistema.
Establecimiento de Conexiones:
Conexión del Software con la Base de Datos: Detalles sobre cómo establecer la conexión entre la aplicación desarrollada en ASP.NET y la base de datos SQL Server, incluyendo la configuración de la cadena de conexión.
Pruebas y Verificación:
Verificación de la Instalación: Pasos para realizar pruebas de funcionalidad después de la instalación y configuración, incluyendo la ejecución de la aplicación en un entorno local para confirmar su correcto funcionamiento.
Identificación de Posibles Problemas: Se proporcionan sugerencias y soluciones para los problemas comunes que pueden surgir durante la instalación y configuración del software, con énfasis en la solución de errores de conexión o configuración.
Procedimiento de Hosteo / Hosting (configuración):
El proyecto será alojado en un contenedor de Docker con la base de datos en SQLServer y la aplicación Web de Asp que realizo el equipo este deberá ser alojado en un servidor.
Sitio Web:


Subida de Archivos:

Subir los archivos del proyecto al servidor mediante FTP o utilizar herramientas de despliegue como Visual Studio.
Configuración del Sitio:
Configurar el servidor web (IIS, Apache, etc.) para alojar el sitio ASP.NET. Asegurar la correcta configuración de las rutas y permisos de acceso.
Conexión a la Base de Datos:
Configurar la cadena de conexión en el código del sitio para que se conecte a la base de datos en el servidor.
Base de Datos (SQL Server):
Creación de la Base de Datos:
Ejecutar el script SQL de creación de la base de datos en el servidor SQL Server.
Configuración de Usuarios y Permisos:
Establecer usuarios con sus respectivos permisos en la base de datos (por ejemplo, usuario de administrador, usuarios para cajero y médico).
Seguridad y Respaldos:
Configurar medidas de seguridad, como contraseñas fuertes y políticas de acceso. Programar respaldos automáticos para asegurar la integridad de los datos.
GIT:
La versión final del proyecto se almacena en un repositorio GIT. Se detalla cómo generar compilados ejecutables desde el repositorio.
Esta es la url del repositorio con el cual se trabajo a lo largo del proyecto:
https://github.com/alejandropariente/NaricesFrias.git
Personalización y configuración:
El sistema desarrollado para Narices Frías permite cierto nivel de personalización y configuración para adaptarse a las necesidades y preferencias específicas de los usuarios. A continuación, se detallan algunas áreas que pueden ser personalizables:

Configuración de Roles y Permisos:

El administrador tiene la capacidad de personalizar los roles y sus respectivos permisos, ajustándolos a las responsabilidades y niveles de acceso requeridos por el personal del refugio.
Personalización de Campos y Formularios:

El sistema ofrece la flexibilidad de personalizar campos en formularios, permitiendo agregar, modificar o eliminar campos según las necesidades específicas de registro de información.
Gestión de Actividades Benéficas:

Los usuarios con rol de administrador pueden personalizar la información relacionada con las actividades benéficas, incluyendo la adición de nuevas actividades, edición de detalles y actualización de la información sobre los fondos recaudados.
Adaptación de Plantillas de Correo Electrónico:

El sistema permite la personalización de plantillas de correo electrónico que se envían automáticamente, como confirmaciones de citas de adopción o notificaciones sobre actividades benéficas. Los administradores pueden modificar el contenido de estos correos según las necesidades.
Parámetros de Configuración del Sitio:

Los ajustes generales del sitio, como colores, logos o información básica, pueden ser modificados por el administrador para mantener la identidad visual y la información actualizada del refugio.
Configuración de Notificaciones y Alertas:

Los usuarios pueden configurar sus preferencias de notificaciones y alertas dentro del sistema, estableciendo qué tipo de eventos desean recibir y cómo desean ser notificados (correo electrónico, notificaciones en la interfaz, etc.).
Personalización de Informes y Reportes:

El sistema permite generar informes y reportes personalizados según los datos relevantes para el refugio. Los administradores pueden seleccionar los parámetros de filtrado y los campos específicos a incluir en estos informes.

Seguridad:
La seguridad es una prioridad fundamental para proteger los datos y el funcionamiento del sistema en Narices Frías. Se implementan las siguientes consideraciones y prácticas recomendadas:
Control de Acceso y Roles:
El sistema tiene un control de acceso basado en roles. Los usuarios solo pueden acceder a las funciones y datos para los que tienen permisos específicos según su rol (admin, cajero, médico). Se siguen los principios de privilegios mínimos necesarios.
Autenticación Segura:
Se utiliza un mecanismo de autenticación segura, como el uso de contraseñas fuertes y su almacenamiento encriptado en la base de datos. Además, se recomienda implementar la autenticación de dos factores para una capa adicional de seguridad.
Actualizaciones y Parches:
Se mantienen actualizados todos los componentes del sistema, incluyendo el software de servidor, bibliotecas externas y frameworks utilizados. Se aplican regularmente parches de seguridad para mitigar vulnerabilidades conocidas.
Encriptación de Datos Sensibles:
Los datos sensibles, como información médica de los animales o detalles financieros, se almacenan y transmiten de manera encriptada para protegerlos de accesos no autorizados.
Auditorías y Registro de Eventos:
Se realizan auditorías periódicas para revisar el acceso a los datos y se mantiene un registro de eventos para detectar posibles anomalías o intentos de acceso no autorizados.
Depuración y solución de problemas:
El sistema proporciona recursos y procedimientos para identificar y resolver problemas que puedan surgir durante su uso. Las instrucciones para la depuración y solución de problemas incluyen:
Registro de Errores y Monitoreo:
El sistema tiene mecanismos para registrar errores y eventos inesperados. Se implementa un sistema de monitoreo para identificar problemas en tiempo real y se registra la información relevante para facilitar la solución.
Documentación de Errores Comunes:

Se mantiene una documentación detallada sobre errores comunes, mensajes de error y posibles causas. Esta documentación incluye pasos de diagnóstico y solución para problemas conocidos.
Soporte y Canal de Ayuda:
Se ofrece un canal de soporte (por ejemplo, un servicio de tickets) para que los usuarios puedan reportar problemas. Se asignan recursos para atender y resolver estos problemas de manera oportuna.
Pruebas y Debugging:
Se llevan a cabo pruebas exhaustivas durante el desarrollo del sistema para identificar posibles errores antes de la implementación. Se utilizan herramientas de debugging para identificar y solucionar problemas específicos.
Comunicación de Actualizaciones y Soluciones:
Se comunica de manera proactiva a los usuarios sobre actualizaciones del sistema, parches de seguridad y soluciones a problemas conocidos a través de comunicados y actualizaciones.
Glosario de términos:
Glosario de términos:
ASP.NET: Framework de desarrollo web de Microsoft para crear sitios y aplicaciones web dinámicas.
C#: Lenguaje de programación desarrollado por Microsoft, utilizado en el entorno de desarrollo .NET.
Base de Datos (BD): Sistema de almacenamiento estructurado de datos que permite el acceso, gestión y actualización de la información.
SQL Server: Sistema de gestión de bases de datos relacional desarrollado por Microsoft.
Encriptación: Proceso de transformación de datos en un formato ilegible para proteger su confidencialidad.
Framework: Conjunto de herramientas, bibliotecas y estándares que proporcionan una estructura para el desarrollo de software.
FTP (Protocolo de Transferencia de Archivos):Protocolo estándar para transferir archivos entre sistemas en una red.
Hosting:Servicio que permite a los usuarios publicar sitios web o aplicaciones en internet.
Debugging: Proceso de identificación y corrección de errores o bugs en el código de un programa.
Tokens de Acceso: Códigos o claves únicas utilizadas para acceder a recursos o servicios dentro de una aplicación o sistema.
Referencias y recursos adicionales:
Documentación técnica oficial de ASP.NET y C#:
Documentación ASP.NET
Documentación de C#
Foros y Comunidades:
Foros de ASP.NET
Stack Overflow - C#
Tutoriales y Guías:
Tutorial de ASP.NET en W3Schools
Tutorial de C# en Tutorialspoint
Recursos sobre SQL Server:
Documentación oficial de SQL Server
Foros de SQL Server en MSDN
Referencias sobre Seguridad Informática:

Herramientas de Implementación:
Lenguaje de programación: C#, Framework: ASP.NET, Base de datos: SQL Server.
Bibliografía:
https://learn.microsoft.com/en-us/sql/ssms/sql-server-management-studio-ssms?view=sql-server-ver16
https://learn.microsoft.com/en-us/dotnet/csharp/
https://dotnet.microsoft.com/es-es/apps/aspnet


