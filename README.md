# 1Parcial-2E
PetShop - Aplicación realizada para el primer parcial de Laboratorio II - UTN FRA

# Pet Shop 🐶

## Requisitos 🗒️

El sistema deberá poder: 

- Administrar usuarios
    
    Deberá poder administrar clientes, empleados y administradores.
    
- Administrar stock de productos
    
    El sistema deberá poder mostrar que productos tiene disponibles, y sus características.
    
- Administrar ventas
    
    La tienda ofrecerá varios tipos de productos, entre ellos alimentos, juguetes, camas, artículos para cuidado de la mascota (limpieza y farmacia).
    

- Empleado
    
    ● El empleado deberá poder dar de alta nuevos clientes o ver los anteriores. 
    
    ● Deberá poder hacer una venta a un cliente determinado siempre y cuando se den las condiciones de venta (por ej, que exista suficiente stock,que alcance el dinero del usuario, etc etc).
    
- Administrador
    
    ● Deberá poder realizar las mismas tareas que el empleado. 
    
    ● Podrá acceder a ver la información de todos los empleados registrados en la aplicación y editarlo si es necesario.
    
    ● Podrá ver la facturación total de todas las ventas realizadas hasta el momento.(hardcodeadas)
    

## Entidades 🛠️

### Usuario

- Atributos
    - Nombre de usuario
    - Contraseña
- Métodos
    - Constructor completo
    - Constructor sin Permisos
        - Por defecto lo establecerá como cliente.

### Empleado : Usuario

- Atributos
    - Legajo
    - Celular
    - 
- Métodos
    - s

### Administrador : Empleado

- Atributos
    - s
- Métodos
    - s

### Cliente : Usuario

- Atributos
    - Cartera
    - Carrito
    - Historial de compras
    - E-mail
    - 
- Métodos
    - s

### Producto

- Atributos
    - Nombre
    - Precio
    - Marca
    - Categoría (Tipo de animal)
    - SubCategoría (Tipo de producto)
    - Descripción
- Métodos
    - 

### Stock

- Atributos
    - Lista de <Producto>
- Métodos
    - 

### Venta

- Atributos
    - IVA
    - Precio total
    - Método de pago
    - Fecha
- Métodos
    - s
