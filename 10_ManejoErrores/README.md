# ⚠️ Manejo de Errores en C#

El manejo de errores en C# permite controlar situaciones inesperadas durante la ejecución del programa, evitando que el sistema falle de forma abrupta y ofreciendo una forma segura de reaccionar ante fallos.

---

## 🔹 ¿Qué es una excepción?

- Una **excepción** es un evento que ocurre cuando algo sale mal durante la ejecución de un programa.
- C# proporciona un sistema robusto para **capturar, manejar y lanzar** excepciones.

---

## 🧱 Estructura básica del manejo de errores

| Bloque      | Descripción                                                                 |
|-------------|-----------------------------------------------------------------------------|
| `try`       | Contiene el código que puede generar una excepción                         |
| `catch`     | Captura y maneja una excepción específica o genérica                       |
| `finally`   | Contiene código que se ejecuta siempre, ocurra o no una excepción          |
| `throw`     | Permite lanzar manualmente una excepción                                   |

---

## 📚 Tipos comunes de excepciones en C#

| Excepción                 | Cuándo ocurre                                                    |
|---------------------------|------------------------------------------------------------------|
| `NullReferenceException`  | Al intentar acceder a un objeto que es `null`                   |
| `IndexOutOfRangeException`| Al acceder a una posición inexistente de un arreglo o lista     |
| `DivideByZeroException`   | Al dividir un número entre cero                                 |
| `FormatException`         | Al convertir un string a otro tipo de forma incorrecta          |
| `IOException`             | Errores relacionados con archivos o dispositivos de E/S         |

---

## 🎯 ¿Por qué manejar errores?

- Evita que el programa se detenga inesperadamente.
- Permite mostrar mensajes de error claros y personalizados.
- Mejora la **experiencia del usuario**.
- Facilita el **debugging** y el **registro de errores**.

---

## ✅ Buenas prácticas

- Captura **solo las excepciones que puedas manejar** correctamente.
- Usa excepciones **específicas** en lugar de genéricas.
- No abuses de `try-catch` para controlar lógica normal del programa.
- Siempre incluye un bloque `finally` si necesitas liberar recursos.
- Agrega mensajes claros o loguea detalles técnicos para soporte.

---

El manejo adecuado de errores es esencial para crear aplicaciones robustas, seguras y confiables.
