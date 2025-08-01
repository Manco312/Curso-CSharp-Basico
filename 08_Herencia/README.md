# 🧬 Herencia en C#

La herencia es un pilar fundamental de la programación orientada a objetos en C#. Permite que una clase derive de otra, **heredando sus atributos y métodos**.

---

## 🔹 ¿Qué es la Herencia?

- Es un mecanismo que permite a una **clase hija (o derivada)** heredar el comportamiento (métodos) y estado (campos/propiedades) de una **clase padre (o base)**.
- La clase hija puede **agregar** nuevos elementos o **modificar** el comportamiento heredado.

---

## 🧱 Terminología

| Término        | Descripción                                                        |
|----------------|--------------------------------------------------------------------|
| Clase base     | También llamada "superclase", es la clase original                 |
| Clase derivada | También llamada "subclase", es la que hereda de la clase base      |

---

## 🔧 ¿Para qué sirve?

- **Reutilización de código**: Evita escribir nuevamente código común.
- **Especialización**: Permite que una clase hija tenga funcionalidades adicionales o diferentes.
- **Jerarquía lógica**: Organiza el código en niveles conceptuales claros.

---

## ⚠️ Consideraciones

- En C#, **no hay herencia múltiple** de clases (una clase solo puede heredar de una clase base).
- Se pueden **sobrescribir métodos** usando `override`, si el método de la clase base está marcado como `virtual`.

---

## 📌 Beneficios clave

| Beneficio             | Explicación                                                                 |
|------------------------|-----------------------------------------------------------------------------|
| Reducción de duplicación | Compartir lógica común entre clases relacionadas                         |
| Mejora en mantenimiento | Cambios en la clase base se reflejan automáticamente en las clases hijas |
| Facilita extensibilidad | Se pueden crear nuevas clases derivadas con facilidad                    |
