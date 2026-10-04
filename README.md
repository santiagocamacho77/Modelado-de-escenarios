# Planeta Veldin — Escena en Unity

Escena 3D creada en Unity con estilo de plataformas sci‑fi colorido (homenaje no oficial a la saga Ratchet & Clank, con fines académicos). Representa un puesto de avanzada en un planeta alienígena al atardecer: terreno esculpido con cráter y montañas, plataforma de aterrizaje, torre de vigilancia, cajas de suministros, plataformas flotantes y un robot centinela construido con cubos.

**Autor:** Santiago Camacho — Ingeniería en Software, UDLA
**Video de demostración:** [YouTube](PEGAR_ENLACE_AQUI)

---

## Requisitos

- Unity **6000.x** (Unity 6) — plantilla *Universal 3D (URP)*
- Unity Hub
- Git (opcional, para clonar)

## Cómo ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/santiagocamacho77/Modelado-de-escenarios
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

- **Terreno:** esculpido con las herramientas *Raise/Lower*, *Set Height* y *Smooth Height*; 4 capas de textura (pasto alienígena, roca, arena y metal).
- **Cubos (más de 10):** cajas de suministros, plataformas flotantes, plataforma de aterrizaje, torre de vigilancia y robot centinela.
- **Materiales:** URP/Lit con metálicos y emisión (neón) para luces de la base.
- **Iluminación:** luz direccional cálida de atardecer, luces puntuales de neón, skybox personalizado y niebla.
- **Post‑procesado:** Bloom, Color Adjustments, Tonemapping (ACES) y Vignette.

## Scripts

| Script | Descripción |
|---|---|
| `FreeFlyCamera.cs` | Cámara libre para recorrer la escena con teclado y mouse. |
| `FloatAndSpin.cs` | Hace que objetos giren y floten (tornillos, plataformas, cristales). |

## Estructura del proyecto

```
Assets/
├── Materials/
├── Prefabs/
├── Scenes/
│   └── PlanetaVeldin.unity
├── Scripts/
│   ├── FreeFlyCamera.cs
│   └── FloatAndSpin.cs
├── Terrain/
└── ThirdParty/      (assets gratuitos usados)
Packages/
ProjectSettings/
```

## Créditos de assets

- Texturas: [Poly Haven](https://polyhaven.com) (CC0)
- Modelos: [Kenney — Space Kit](https://kenney.nl/assets/space-kit) (CC0)
- Skybox: AGREGAR_NOMBRE_Y_ENLACE
