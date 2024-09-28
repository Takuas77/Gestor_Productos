# Sistema de Gestión de Productos

## Descripción del Proyecto:

Este proyecto consiste en el desarrollo de un sistema de gestión de productos, implementado en **VB.NET** con una base de datos **MySQL**. El sistema permite gestionar tanto a los usuarios del sistema como los productos que se manejan en el inventario. Además, implementa un sistema de roles para controlar las acciones que pueden realizar los diferentes tipos de usuarios.

## Funcionalidades Principales:

### 1. Gestión de Usuarios:
- Permite agregar, modificar y eliminar usuarios.
- Los usuarios pueden tener diferentes roles: **Administrador** o **Usuario**.
- Solo los administradores pueden agregar o modificar otros usuarios.
- Los usuarios están registrados con los siguientes campos:
  - **Username**
  - **Password** (hasheada)
  - **Email**
  - **Categoría** (rol)
  - **Estado** (activo/inactivo)
  - **Fecha de creación**

### 2. Sistema de Autenticación:
- Los usuarios deben iniciar sesión con un nombre de usuario y contraseña.
- Se verifica el rol del usuario para definir qué acciones puede realizar.
- Los usuarios inactivos (Estado = 0) no pueden iniciar sesión.

### 3. Gestión de Productos:
- Los administradores pueden agregar, modificar y eliminar productos en el inventario.
- Los productos tienen las siguientes propiedades:
  - **Nombre**
  - **Precio**
  - **Cantidad**
  - **Categoría**
  - **Marca**
  - **Fecha de vencimiento**
- Permite realizar ventas y gestionar el stock de productos, actualizando automáticamente las cantidades disponibles.

### 4. Sistema de Ventas:
- Los productos seleccionados pueden añadirse a una canasta, generando una factura para el cliente.
- Al finalizar una compra, el sistema descuenta automáticamente las cantidades vendidas del inventario.

### 5. Jerarquía de Roles:
- El sistema implementa una jerarquía basada en roles, donde los **Administradores** tienen permisos completos, mientras que los **Usuarios** tienen acceso restringido a ciertas funciones.
- Los administradores pueden modificar, agregar y eliminar usuarios y productos, mientras que los usuarios estándar solo pueden consultar los productos.

## Tecnologías Utilizadas:
- **VB.NET** para la lógica del sistema y la interfaz de usuario.
- **MySQL** para gestionar la base de datos y almacenar la información de los usuarios, productos y ventas.
- **Hashing** para proteger las contraseñas de los usuarios.



------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Para el funcionamiento se usaron las siguientes librerias:

-mysql.data
-dos extenciones que se encuentran en la caparpeta de archivos necesarios.

Tambien dejo la base de datos en Mysql, actual usada y aparte un txt con el query.

Se podria usar otra Base de datos, con similar estructura, para lo cual abria que modificar "AModulos.vd" "Linea: 8"



Credenciales de ingreso.
egarcia 123456	Administrador
hsilva	123456	Usuario

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
