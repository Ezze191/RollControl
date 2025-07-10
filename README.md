 RollControl - Sistema de Gestión de Inventario de Rollos

Este sistema fue desarrollado en Windows Forms utilizando el lenguaje C#. Se conecta a una base de datos MySQL, la cual está alojada en la red local de la empresa, permitiendo que cualquier computadora conectada a la red interna pueda acceder fácilmente al sistema.

RollControl permite gestionar las entradas y salidas de rollos con diferentes medidas, facilitando así un mejor control del inventario y ofreciendo opciones para exportarlo de manera sencilla.

 Pantalla de Inicio de Sesión (Login)
<img width="1919" height="1039" alt="Login" src="https://github.com/user-attachments/assets/caf80102-785c-4fc6-bfbf-9654f6df48c4" />
El sistema cuenta con dos tipos de usuarios:

Administrador: Tiene acceso total, puede crear, editar y eliminar usuarios, así como gestionar todas las operaciones del inventario.

Usuario Almacén: Puede registrar entradas y salidas, así como exportar reportes e inventarios a Excel.

 Pantalla Principal
<img width="1919" height="1039" alt="homePage" src="https://github.com/user-attachments/assets/ed2ae3ed-f085-412a-b1b7-bc0d9770529b" />
Luego de iniciar sesión, se presenta la pantalla principal, que incluye:

Abrir Inventario: Permite registrar movimientos (entradas y salidas) en un inventario ya existente.

Cerrar Inventario: Finaliza las modificaciones de un inventario y lo archiva.

Usuarios: Gestión de usuarios del sistema (crear, editar o eliminar).

 Abrir Inventario
<img width="1919" height="1039" alt="OpenInventario" src="https://github.com/user-attachments/assets/84c13f44-44be-4ba8-86e2-c3980a61a1c6" />
Esta pantalla permite seleccionar el mes del inventario que se desea modificar.

 Entradas
<img width="1918" height="1039" alt="entradasPage" src="https://github.com/user-attachments/assets/88974d46-867f-4edf-b96f-6769871ae240" />
Vista donde se gestionan las entradas de rollos:

Tabla de entradas (lado izquierdo).

Importación de registros desde Excel.

Registro manual de entradas con todos sus campos.

Filtros para buscar o seguir rollos específicos.

Exportación de la tabla de entradas a Excel.

Totales automáticos al final de la tabla.

 Salidas
<img width="1919" height="1039" alt="SalidasPage" src="https://github.com/user-attachments/assets/abd5eb49-3db0-42dd-93ac-1e0fb2cb3cfa" />
Vista muy similar a la de entradas, pero destinada a gestionar las salidas de rollos:

Campos adaptados para registrar salidas.

Funciones de exportación, importación, filtros y totales.

 Inventario Final
<img width="1919" height="1039" alt="InventarioPage" src="https://github.com/user-attachments/assets/62b4ece9-3368-4f7d-a1f6-6925e0648e75" />
Aquí se muestra el inventario final consolidado del mes en curso:

Exportación simultánea de las tres tablas (entradas, salidas e inventario final) a Excel.

Filtros para revisar inventarios específicos.

✏ Edición de Registros
<img width="1919" height="1039" alt="EditPage" src="https://github.com/user-attachments/assets/73410054-8a79-44bd-859c-6e46f61b07f0" />
Pantalla para editar registros de entradas o salidas en caso de errores o ajustes necesarios.

 Gestión de Usuarios
<img width="1919" height="1039" alt="UsuariosPage" src="https://github.com/user-attachments/assets/facbc355-e11b-4ae1-92a3-5287fbf16ba7" />
Vista destinada a la administración de usuarios:

Crear, editar o eliminar usuarios registrados en el sistema.

 Funciones Clave
Inventario de entradas y salidas de rollos.

Exportación e importación desde/para Excel.

Control por usuarios con permisos diferenciados.

Filtros avanzados y totales automáticos.
