# 🔀 Condicionales en C#

Las condicionales permiten que un programa tome decisiones dependiendo del valor de ciertas condiciones. Son esenciales para controlar el flujo de ejecución.

---

## 🧠 ¿Para qué sirven?

Sirven para:

- Ejecutar instrucciones solo si se cumple cierta condición.
- Tomar distintas acciones dependiendo de diferentes valores o estados.
- Reaccionar ante entradas del usuario o resultados de operaciones.

---

## ✳️ `if`

Se utiliza para **ejecutar un bloque de código si una condición es verdadera**. Es la forma más básica de tomar decisiones.

🟢 Ideal para:
- Validar una sola condición.
- Casos simples donde solo interesa si algo se cumple o no.

---

## ➕ `else if`

Se usa junto a `if` para **evaluar múltiples condiciones mutuamente excluyentes**. Permite encadenar varios posibles escenarios.

🟢 Ideal para:
- Evaluar diferentes rangos o situaciones.
- Decidir entre varias alternativas posibles, una tras otra.

---

## ➖ `else`

Se ejecuta **si ninguna de las condiciones anteriores se cumple**. Representa el “caso por defecto” dentro de una estructura `if`.

🟢 Ideal para:
- Manejar escenarios que no se contemplan explícitamente.
- Evitar que el programa quede sin respuesta cuando no se cumple ningún `if` o `else if`.

---

## 🔘 `switch`

Se usa para **evaluar una variable contra múltiples valores posibles**. Es una alternativa más limpia y eficiente que múltiples `else if` cuando se compara una misma variable.

🟢 Ideal para:
- Seleccionar acciones según el valor exacto de una variable.
- Menús, opciones numéricas o decisiones con múltiples ramas fijas.

---

## 🧮 Comparaciones comunes

| Operador | Significado         | Ejemplo lógico                 |
|----------|---------------------|--------------------------------|
| `==`     | Igual                | ¿El valor es igual a otro?     |
| `!=`     | Distinto             | ¿Es diferente al comparado?    |
| `>`      | Mayor que            | ¿Es mayor que cierto valor?    |
| `<`      | Menor que            | ¿Es menor que cierto valor?    |
| `>=`     | Mayor o igual        | ¿Es igual o mayor?             |
| `<=`     | Menor o igual        | ¿Es igual o menor?             |
| `&&`     | Y lógico (AND)       | ¿Ambas condiciones se cumplen? |
| ||     | O lógico (OR)        | ¿Al menos una se cumple?       |
| `!`      | Negación lógica      | ¿La condición es falsa?        |
