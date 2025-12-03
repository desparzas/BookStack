# W05 Checkpoint - Checklist

## 📋 Rúbrica de Calificación (10 puntos)

| Criterio | Puntos | Qué Incluir | Estado |
|----------|--------|-------------|---------|
| **Summary** | 3 pts | Challenges, successes, nuevas tareas, change orders | ✅ En W05_CANVAS_SUBMISSION.txt |
| **Participants** | 2 pts | Lista de participantes de la reunión | ✅ En W05_CANVAS_SUBMISSION.txt |
| **Azure DevOps URL** | 2 pts | URL funcional del proyecto | ⏳ Necesitas agregar |
| **Project Task** | 3 pts | Referencia a una tarea + descripción detallada | ✅ En W05_CANVAS_SUBMISSION.txt |

---

## ✅ Lo Que Ya Está Listo

- ✅ **Summary completo** con challenges, successes, new tasks, change orders
- ✅ **Lista de participantes** (David Esparza - individual work)
- ✅ **Descripción detallada de tarea**: "Setup Database Layer"
  - Descripción técnica completa
  - Challenges y soluciones
  - Fit dentro del proyecto
  - Funcionalidad entregada
  - Ubicaciones de código
  - Testing realizado
- ✅ **Tareas adicionales** trabajadas esta semana
- ✅ **Estado del proyecto** actualizado

---

## ⏳ Lo Que Necesitas Completar (15-20 minutos)

### 1. Crear Azure DevOps Project (si aún no lo hiciste)

Ve a **[https://dev.azure.com](https://dev.azure.com)** (NO portal.azure.com)

#### A. Crear Proyecto:
1. Click **+ New project**
2. Name: `BookStack`
3. **Visibility: Public** ⚠️ (IMPORTANTE)
4. Work item process: Agile
5. Click **Create**

#### B. Crear Work Items:

Ve a **Boards** → **Work Items** → **+ New Work Item** → **User Story**

**Completados** (State: Done, Assigned: David Esparza):
1. Setup Project Infrastructure
2. Implement Data Models
3. **Setup Database Layer** ⭐ (Esta es tu tarea detallada)
4. Build REST API Controllers
5. Create Blazor UI Components

**Pendientes** (State: New, Unassigned):
6. Add Book Creation Dialog
7. Implement Book Details Page
8. Add User Authentication

#### C. Copiar URL:

Después de crear el proyecto, copia la URL:
```
https://dev.azure.com/{tu-organizacion}/BookStack
```

O la URL del board:
```
https://dev.azure.com/{tu-org}/BookStack/_boards
```

---

### 2. Actualizar W05_CANVAS_SUBMISSION.txt

Abre: `W05_CANVAS_SUBMISSION.txt`

Busca:
```
[INSERT YOUR AZURE DEVOPS URL HERE]
```

Reemplaza con tu URL real.

También actualiza:
```
AZURE DEVOPS WORK ITEM ID: [Your work item ID]
```

Con el ID real del work item #3 (Setup Database Layer)

---

### 3. Entregar en Canvas

1. Abre Canvas → W05 Team Activity
2. Copia TODO el contenido de `W05_CANVAS_SUBMISSION.txt`
3. Pega en el text entry box
4. Click **Submit**

---

## 🎯 Puntos Clave de Tu Entrega

### Tarea Destacada: "Setup Database Layer"

**Por qué esta tarea es importante:**
- ⭐ Es el **fundamento** de todo el proyecto
- ⭐ Demuestra conocimiento de **EF Core avanzado** (Fluent API)
- ⭐ Implementa **relaciones complejas** (3 many-to-many)
- ⭐ Incluye **seed data completo** para testing
- ⭐ Muestra **best practices** (.NET 9, async/await)

**Detalles técnicos incluidos:**
- ✅ 75 líneas de código en DbContext
- ✅ 280 líneas de seed data
- ✅ 8 entidades configuradas
- ✅ 3 relaciones many-to-many
- ✅ Composite keys configurados
- ✅ Error handling implementado

---

## 📊 Diferencias W04 vs W05

| Aspecto | W04 | W05 |
|---------|-----|-----|
| **Enfoque** | Trabajo completado general | Una tarea específica en detalle |
| **Descripción** | Lista de features | Descripción técnica profunda |
| **Detalles** | Qué se hizo | Cómo se hizo, por qué, challenges |
| **Código** | General | Ubicaciones específicas, líneas |
| **Testing** | Build status | Testing específico de la feature |

---

## 🔍 Verificación Final

Antes de entregar, verifica:

- [ ] Azure DevOps project está **Public**
- [ ] Tienes 8 User Stories creados
- [ ] 5 User Stories marcados como "Done" y asignados a ti
- [ ] Work Item #3 tiene título "Setup Database Layer"
- [ ] URL de Azure DevOps está en el documento
- [ ] Work Item ID está en el documento
- [ ] El documento tiene >100 palabras (tienes ~600+)
- [ ] Incluye challenges, successes, new tasks, change orders
- [ ] Lista de participantes está presente

---

## 💡 Tips para Azure DevOps

**Hacer Público el Proyecto:**
1. Project Settings (⚙️ abajo izquierda)
2. Overview
3. Visibility → Change → Public
4. Save

**Verificar que es Público:**
1. Copia tu URL
2. Abre ventana incógnito
3. Pega la URL
4. Si puedes verlo sin login = ✅ Público

**Encontrar Work Item ID:**
Cada work item tiene un número (ej: #3, #5, etc.)
Lo ves en la lista de work items o en el título cuando abres uno.

---

## 📁 Archivos del Proyecto

```
BookStack/
├── W05_CANVAS_SUBMISSION.txt    ⭐ Usar este para entregar
├── W05_CHECKLIST.md             📋 Esta guía
├── W04_CANVAS_SUBMISSION.md     (W04 anterior)
├── W04_CANVAS_TEXT.txt          (W04 anterior)
├── AZURE_DEVOPS_SETUP_GUIDE.md  📖 Guía detallada
├── README.md
└── BookStack.Web/               ✅ Código completo
```

---

## ⏱️ Tiempo Estimado

- **Crear Azure DevOps + Work Items:** 15-20 min
- **Actualizar documento con URL:** 2 min
- **Entregar en Canvas:** 1 min

**Total:** ~20 minutos

---

## 🆘 ¿Necesitas Ayuda?

Si tienes problemas:
1. **Azure DevOps:** Sigue `AZURE_DEVOPS_SETUP_GUIDE.md`
2. **Hacer Público:** Ver sección "Hacer Público el Proyecto" arriba
3. **Work Items:** Crear como User Stories, no Tasks

---

¡Éxito! 🚀
