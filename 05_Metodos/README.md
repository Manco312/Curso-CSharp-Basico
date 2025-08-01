# 🧩 Métodos en C#

Los **métodos** son bloques de código reutilizables que ejecutan una tarea específica. Permiten organizar mejor el programa, dividir la lógica en partes pequeñas y evitar repetir instrucciones.

## ¿Para qué sirven?

- Encapsulan lógica que puede repetirse en distintas partes del programa.
- Mejoran la **legibilidad** y el **mantenimiento** del código.
- Permiten **dividir responsabilidades** dentro de una clase.

## Tipos de métodos

### 🔸 Métodos sin parámetros ni retorno

- Ejecutan una acción sin requerir datos ni devolver resultados.
- Útiles para tareas simples o mensajes fijos.

### 🔸 Métodos con parámetros

- Reciben datos externos al ser llamados.
- Permiten reutilizar el mismo método con diferentes valores.

### 🔸 Métodos con valor de retorno

- Devuelven un resultado al final de su ejecución.
- Ideales cuando se necesita **procesar información** y obtener un resultado.

### 🔸 Métodos con parámetros y retorno

- Los más comunes.
- Permiten **recibir datos, procesarlos y devolver un resultado**.

## Consideraciones

- Los métodos se **declaran dentro de clases**.
- Su nombre debe ser **descriptivo y en PascalCase**.
- Se puede usar `void` cuando no se desea retornar nada.
- El tipo de retorno debe coincidir con el tipo de dato devuelto.
