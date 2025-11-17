# Proyecto: Sistema de Gestión para Parque Tecnológico Innovatec

## Descripción
Este proyecto implementa un sistema de gestión para el Parque Tecnológico "Innovatec" que incluye dos componentes principales:

1. **Árbol de Jerarquía Organizativa**: Representa la estructura organizacional del parque
2. **Grafo de Rutas Internas**: Modela las conexiones entre edificios del parque

## Estructura del Proyecto

### Componentes Principales

#### 1. Árbol General (Jerarquía Organizativa)
- **Clase `NodoArbol`**: Representa un nodo con ID, nombre y lista de hijos
- **Clase `ArbolGeneral`**: Implementa operaciones del árbol
- **Formulario `FrmArbol`**: Interfaz gráfica para administrar el árbol

**Funcionalidades del Árbol:**
- Crear raíz de la organización
- Insertar nodos hijos
- Recorrido en preorden
- Conteo de nodos
- Cálculo de niveles organizativos

#### 2. Grafo No Dirigido Ponderado (Sistema de Rutas)
- **Clase `Grafo`**: Implementa un grafo con diccionario de adyacencia
- **Formulario `FrmGrafo`**: Interfaz para gestionar el grafo

**Funcionalidades del Grafo:**
- Agregar nodos (edificios)
- Agregar aristas ponderadas (rutas con distancia)
- Mostrar adyacencias
- Verificar conectividad del parque
- Calcular ruta más corta (Algoritmo de Dijkstra)

## Requisitos Técnicos

### Tecnologías Utilizadas
- **Lenguaje**: C#
- **Plataforma**: .NET Framework
- **Interfaz**: Windows Forms
- **Estructuras de Datos**: Árbol general, Grafo no dirigido ponderado

### Algoritmos Implementados
- **Recorrido en preorden** para el árbol
- **Breadth-First Search (BFS)** para verificar conectividad
- **Algoritmo de Dijkstra** para rutas más cortas

## Estructura de Archivos

```
Innovatec/
├── Estructura/
│   ├── NodoArbol.cs
│   ├── ArbolGeneral.cs
│   └── Grafo.cs
├── Vista/
│   ├── FrmArbol.cs
│   └── FrmGrafo.cs
└── README.md
```

## Instrucciones de Uso

### Para el Árbol Organizativo
1. Ejecutar la aplicación
2. La raíz "Innovatec" se crea automáticamente
3. Seleccionar un nodo padre en la lista
4. Ingresar nombre del nuevo nodo y hacer clic en "Insertar"
5. Usar botones para contar nodos, ver niveles o recorrer

### Para el Grafo de Rutas
1. Agregar nodos (nombres de edificios)
2. Conectar edificios con aristas (especificar peso/distance)
3. Verificar conectividad del parque
4. Calcular rutas más cortas entre cualquier par de edificios

## Características de Implementación

### Árbol
- Búsqueda recursiva por ID
- Conteo recursivo de nodos
- Cálculo de niveles usando BFS
- Visualización con sangría por niveles

### Grafo
- Representación con lista de adyacencia
- Validación de nodos únicos
- Aristas no dirigidas con pesos
- Dijkstra con reconstrucción de camino

## Criterios de Evaluación Cumplidos

- Implementación correcta del árbol general (10 puntos)
- Implementación funcional del grafo con Dijkstra (10 puntos)
- Estructura de proyecto organizada (5 puntos)
- Documentación clara y técnica (5 puntos)

## Notas Técnicas

- El árbol garantiza IDs únicos automáticamente
- El grafo valida existencia de nodos antes de operaciones
- Dijkstra maneja correctamente caminos inexistentes
- La interfaz proporciona feedback claro al usuario

Este proyecto demuestra la aplicación práctica de estructuras de datos avanzadas en un contexto de gestión empresarial y logística.
