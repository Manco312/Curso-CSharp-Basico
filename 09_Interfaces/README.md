# 🔌 Interfaces en C#

Las interfaces son contratos que definen qué métodos, propiedades o eventos debe implementar una clase, **sin proporcionar implementación**.

---

## 🔹 ¿Qué es una interfaz?

- Es una **estructura abstracta** que solo declara miembros (métodos, propiedades, eventos, indexadores).
- **No contiene lógica ni implementaciones reales.**
- Las clases o estructuras que implementan una interfaz deben proporcionar la implementación de todos sus miembros.

---

## 🧱 Características de las interfaces

| Característica                   | Descripción                                                                 |
|----------------------------------|-----------------------------------------------------------------------------|
| Solo declaraciones               | No pueden contener implementaciones (excepto métodos `default` desde C# 8) |
| Soporta herencia múltiple       | Una clase puede implementar varias interfaces                              |
| Ideal para abstraer comportamientos | Separa el "qué hace" del "cómo lo hace"                                 |

---

## 🔧 ¿Para qué sirven?

- **Definir contratos** que las clases deben cumplir.
- **Permitir polimorfismo** sin herencia directa.
- **Facilitar la inyección de dependencias**, pruebas unitarias y programación orientada a interfaces.

---

## 📚 Diferencia entre clase abstracta e interfaz

| Aspecto               | Clase abstracta                  | Interfaz                                |
|------------------------|----------------------------------|------------------------------------------|
| Implementación         | Puede contener métodos definidos | No puede (salvo `default` desde C# 8)    |
| Herencia múltiple      | No (solo una clase base)         | Sí (múltiples interfaces)                |
| Flexibilidad           | Menor flexibilidad               | Alta flexibilidad                        |
| Uso típico             | Relación jerárquica (is-a)       | Contrato de comportamiento (can-do)      |

---

## ✅ Ventajas de usar interfaces

- Mayor flexibilidad en el diseño.
- Facilita el mantenimiento y la extensión del código.
- Ayuda a desacoplar componentes.
- Favorece el uso de principios SOLID (especialmente Interface Segregation e Inversión de Dependencias).
