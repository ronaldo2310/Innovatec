Proyecto: Árboles y Grafos en C# — Innovatec
Descripción General

Este proyecto implementa dos estructuras fundamentales para el caso de estudio del Parque Tecnológico “Innovatec”:

Parte A — Árbol General (Jerarquía Organizativa)

Modela la estructura jerárquica del parque utilizando un árbol general, permitiendo:

Registrar nodos (departamentos, áreas, unidades).

Insertar hijos bajo cualquier nodo padre.

Recorrer el árbol en preorden.

Buscar nodos por ID.

Contar nodos totales.

Obtener niveles de cada nodo dentro de la jerarquía.

Parte B — Grafo (Rutas del Parque)

Simula el sistema interno de caminos entre edificios mediante un grafo no dirigido y ponderado, con funcionalidades para:

Agregar nodos (edificios o puntos).

Crear aristas con pesos (distancias).

Mostrar adyacencias con pesos.

Validar si el grafo es conexo.

Calcular la ruta más corta entre dos edificios usando el algoritmo de Dijkstra.

Este proyecto corresponde al Caso de Estudio: Árboles y Grafos en C# de la Universidad Americana (UAM).


Caso_de_Estudio_Arboles_Grafos

Tecnologías Utilizadas

C# (.NET Framework / Windows Forms)

Clases propias para Árbol y Grafo

Visual Studio

Estructura del Proyecto
Innovatec
 ├── Estructura
 │     ├── ArbolGeneral.cs
 │     ├── NodoArbol.cs
 │     └── Grafo.cs
 ├── Vista
 │     ├── FrmArbol.cs
 │     ├── FrmGrafo.cs
 │     └── Archivos de diseño (Windows Forms)
 └── README.md

Árbol General — Funcionalidades
Crear raíz
arbol.CrearRaiz(1, "Innovatec");

Insertar nodos hijos
arbol.Insertar(padreId, nuevoId, "Nuevo Nodo");

Recorrer en preorden
arbol.RecorrerPreorden(arbol.Raiz, listBox);

Contar nodos
int total = arbol.ContarNodos();

Obtener niveles
Dictionary<int, int> niveles = arbol.ObtenerNiveles();

Grafo — Funcionalidades
Agregar un nodo
grafo.AgregarNodo("Edificio A");

Crear arista con peso
grafo.AgregarArista("A", "B", 12.5);

Mostrar adyacencias

Ejemplo:

A -> B(12.5), C(8)
B -> A(12.5)

Verificar conectividad
grafo.EsConexo();

Calcular ruta más corta (Dijkstra)
var resultado = grafo.Dijkstra("A", "D");
double distancia = resultado.Item1;
var camino = resultado.Item2;

Instrucciones de Ejecución

Abrir el archivo .sln en Visual Studio.

Ejecutar el proyecto (F5).

Desde la interfaz se puede:

Administrar la jerarquía del árbol.

Construir la red de rutas del grafo.

Obtener rutas óptimas mediante Dijkstra.
