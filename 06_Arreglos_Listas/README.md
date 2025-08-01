# 📦 Arreglos y Listas en C#

En C#, los **arreglos (arrays)** y **listas (listas genéricas)** permiten almacenar y manipular colecciones de elementos.

## 🔹 Arreglos (`array`)

- Son estructuras **de tamaño fijo** que almacenan elementos del mismo tipo.
- Cada elemento se accede mediante un **índice numérico**.
- Útiles cuando **se conoce de antemano** la cantidad de elementos.

### Ventajas:
- Acceso rápido a elementos por índice.
- Eficientes en memoria cuando el tamaño es constante.

### Limitaciones:
- No se puede cambiar su tamaño después de ser creado.
- No tienen métodos integrados para modificar su contenido dinámicamente.

---

## 🔸 Listas (`List<T>`)

- Son colecciones **dinámicas** que pueden crecer o reducirse en tiempo de ejecución.
- Forman parte de la biblioteca `System.Collections.Generic`.
- Usan métodos como `Add`, `Remove`, `Contains`, entre otros.

### Ventajas:
- Se pueden **agregar y quitar elementos fácilmente**.
- Tienen métodos integrados para ordenamiento, búsqueda, filtrado, etc.
- Se adaptan a situaciones donde **el número de elementos no es fijo**.

### Consideraciones:
- Ligeramente menos eficientes en memoria que los arreglos fijos.
- Deben usarse con cuidado en estructuras muy grandes o con muchas operaciones frecuentes.

---

## 🧠 ¿Cuándo usar uno u otro?

| Necesidad                        | Usa esto     |
|----------------------------------|--------------|
| Tamaño fijo y rendimiento óptimo | Arreglo      |
| Tamaño variable y flexibilidad   | Lista (`List<T>`) |
