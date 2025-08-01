# 🔄 Bucles en C#

Los **bucles** o **estructuras repetitivas** permiten ejecutar un bloque de instrucciones múltiples veces, ya sea bajo una condición, una cantidad determinada de veces, o mientras una expresión siga siendo verdadera.

## Tipos de bucles

### 🔁 `for`

- Se usa cuando se conoce **de antemano cuántas veces** se debe repetir el bloque.
- Permite iterar con un valor inicial, una condición de fin y un incremento o decremento.
- Ideal para **contar** o recorrer rangos definidos.

### 🔄 `while`

- Repite el bloque **mientras una condición sea verdadera**.
- Evalúa la condición **antes** de cada iteración.
- Puede no ejecutarse **ni una sola vez** si la condición no se cumple desde el inicio.
- Útil cuando **no se sabe cuántas veces** se debe repetir, pero hay una condición clara.

### 🔂 `do...while`

- Similar al `while`, pero **siempre se ejecuta al menos una vez**.
- Evalúa la condición **después** de ejecutar el bloque.
- Útil cuando es necesario **ejecutar primero y validar después**.

## Consideraciones

- Es importante evitar **bucles infinitos** verificando que la condición cambie adecuadamente.
- Se pueden usar las instrucciones `break` (salir del bucle) y `continue` (saltar a la siguiente iteración), aunque deben utilizarse con lógica clara.
