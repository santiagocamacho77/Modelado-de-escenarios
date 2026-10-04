# Planeta Veldin — Escena en Unity

Escenario creado por Santiago Camacho.

Escena 3D de un planeta desértico rodeado de montañas. El escenario tiene una nave y una base de operaciones, edificios con antenas y cráteres que decoran el ambiente, junto con un hangar, una puerta espacial y otros detalles que dan vida al lugar.

**Autor:** Santiago Camacho — Ingeniería en Software, UDLA
**Video de demostración:** [YouTube](PEGAR_ENLACE_AQUI)

---

## Requisitos

- Unity **6.6 (6000.6.4f1)** — plantilla *Universal 3D (URP)*
- Unity Hub
- Git (opcional, para clonar)

## Cómo ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/santiagocamacho77/Modelado-de-escenarios.git
   ```
2. Abre **Unity Hub** → **Add** → **Add project from disk** → selecciona la carpeta clonada.
3. Ábrelo con Unity 6 (la primera vez tarda unos minutos porque se regenera la carpeta `Library`).
4. En la ventana **Project**, abre `Assets/Scenes/PlanetaVeldin.unity`.
5. Presiona **Play** ▶.

## Controles

| Tecla | Acción |
|---|---|
| W A S D | Moverse |
| Mouse | Mirar alrededor |
| E / Q | Subir / bajar |
| Shift | Moverse más rápido |
| Esc | Liberar el cursor |
| Clic izquierdo | Volver a capturar el cursor |

## Elementos de la escena

- **Terreno:** esculpido con las herramientas *Raise/Lower*, *Set Height* y *Smooth Height*, formando montañas alrededor del escenario; pintado con varias capas de textura (tierra, roca y camino).
- **Cubos:** más de 10 cubos que forman los edificios y la base de la estación.
- **Modelos:** nave, hangar, puerta espacial, antenas, cráteres y otros elementos decorativos.
- **Materiales:** material de metal oxidado (URP/Lit) aplicado a la base.
- **Iluminación:** luz direccional cálida de atardecer.
- **Post‑procesado:** Global Volume para mejorar el color y la iluminación de la escena.

## Scripts

| Script | Descripción |
|---|---|
| `FreeFlyCamera.cs` | Cámara libre para recorrer la escena con teclado y mouse. |

## Estructura del proyecto

```
Assets/
├── Materiales/
├── Prefabs/
├── Scenes/
│   └── PlanetaVeldin.unity
├── Scripts/
│   └── FreeFlyCamera.cs
├── Settings/
├── Terreno/
└── Thirdpary/
Packages/
ProjectSettings/
```

## Créditos de assets

- Texturas: [Poly Haven](https://polyhaven.com) (CC0)
- Modelos: [Kenney — Space Kit](https://kenney.nl/assets/space-kit) (CC0)
