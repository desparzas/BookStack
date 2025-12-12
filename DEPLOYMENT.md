# BookStack Deployment Guide

Este documento explica cómo desplegar BookStack en diferentes plataformas.

---

## Opción 1: Azure App Service (Recomendada)

### Requisitos:
- Cuenta de Azure (tier gratuito disponible)
- Azure CLI instalado

### Pasos:

1. **Instalar Azure CLI** (si no lo tienes):
   ```bash
   # Windows (PowerShell como Admin)
   winget install Microsoft.AzureCLI

   # O descarga desde: https://aka.ms/installazurecliwindows
   ```

2. **Login a Azure**:
   ```bash
   az login
   ```

3. **Crear grupo de recursos**:
   ```bash
   az group create --name bookstack-rg --location eastus
   ```

4. **Crear App Service Plan** (Tier gratuito):
   ```bash
   az appservice plan create --name bookstack-plan --resource-group bookstack-rg --sku F1 --is-linux
   ```

5. **Crear Web App**:
   ```bash
   az webapp create --resource-group bookstack-rg --plan bookstack-plan --name bookstack-yourname --runtime "DOTNET|9.0"
   ```

6. **Configurar para usar SQLite** (crear carpeta persistente):
   ```bash
   az webapp config appsettings set --resource-group bookstack-rg --name bookstack-yourname --settings ConnectionStrings__BookStackContext="Data Source=/home/data/bookstack.db"
   ```

7. **Desplegar desde carpeta local**:
   ```bash
   cd BookStack.Web
   dotnet publish -c Release -o ./publish
   cd publish
   zip -r ../deploy.zip .
   az webapp deployment source config-zip --resource-group bookstack-rg --name bookstack-yourname --src ../deploy.zip
   ```

8. **Abrir la app**:
   ```bash
   az webapp browse --resource-group bookstack-rg --name bookstack-yourname
   ```

### Notas importantes:
- Reemplaza `bookstack-yourname` con un nombre único
- El tier F1 es gratuito pero tiene limitaciones (60 minutos de CPU por día)
- Para producción real, considera el tier B1 o superior

---

## Opción 2: Docker + Railway (Gratis para empezar)

### Requisitos:
- Docker Desktop instalado
- Cuenta en Railway.app
- Git/GitHub

### Pasos:

1. **Probar localmente con Docker**:
   ```bash
   cd BookStack
   docker build -t bookstack .
   docker run -p 8080:8080 -v $(pwd)/data:/app/data bookstack
   ```

   Abre http://localhost:8080

2. **Subir a GitHub** (si no lo has hecho):
   ```bash
   cd BookStack
   git init
   git add .
   git commit -m "Initial commit"
   git branch -M main
   git remote add origin https://github.com/yourusername/BookStack.git
   git push -u origin main
   ```

3. **Desplegar en Railway**:
   - Ve a [Railway.app](https://railway.app)
   - Crea una cuenta (gratis con GitHub)
   - Click "New Project" → "Deploy from GitHub repo"
   - Selecciona tu repositorio BookStack
   - Railway detectará automáticamente el Dockerfile
   - Configura variables de entorno:
     - `ASPNETCORE_ENVIRONMENT=Production`
     - `ASPNETCORE_URLS=http://+:8080`
   - Click "Deploy"

4. **Obtener URL pública**:
   - En Railway, ve a Settings → Generate Domain
   - Copia la URL generada

### Notas:
- Railway ofrece $5 de crédito gratis al mes
- Perfecto para demos y proyectos pequeños
- La base de datos SQLite se perderá al reiniciar (considera usar un volumen persistente)

---

## Opción 3: Docker + Render.com (Gratis)

### Pasos:

1. **Crear cuenta en Render.com**:
   - Ve a [Render.com](https://render.com)
   - Regístrate con GitHub

2. **Nuevo Web Service**:
   - Click "New" → "Web Service"
   - Conecta tu repositorio de GitHub
   - Configuración:
     - **Name**: bookstack
     - **Region**: Oregon (US West)
     - **Branch**: main
     - **Build Command**: (vacío, usa Dockerfile)
     - **Docker Command**: (vacío)
   - Click "Create Web Service"

3. **Variables de entorno**:
   - Agrega en el panel de Render:
     - `ASPNETCORE_ENVIRONMENT=Production`
     - `ASPNETCORE_URLS=http://+:8080`

4. **Esperar despliegue**:
   - Render automáticamente construirá y desplegará
   - Obtendrás una URL como `https://bookstack.onrender.com`

### Notas:
- El tier gratuito tiene "cold starts" (se duerme después de inactividad)
- Limitado a 750 horas al mes
- Bueno para demos y portfolios

---

## Opción 4: Fly.io (Gratis hasta cierto uso)

### Requisitos:
- Fly CLI instalado

### Pasos:

1. **Instalar Fly CLI**:
   ```bash
   # Windows (PowerShell)
   iwr https://fly.io/install.ps1 -useb | iex
   ```

2. **Login**:
   ```bash
   fly auth login
   ```

3. **Inicializar app**:
   ```bash
   cd BookStack
   fly launch
   ```

   Responde las preguntas:
   - App name: bookstack (o el que prefieras)
   - Region: Elige el más cercano
   - Database: No (ya usamos SQLite)
   - Deploy: Yes

4. **Configurar volumen para SQLite**:
   ```bash
   fly volumes create bookstack_data --size 1 --region ord
   ```

5. **Actualizar fly.toml**:
   Agrega la sección de montaje de volumen (fly launch ya creó este archivo)

6. **Desplegar**:
   ```bash
   fly deploy
   ```

7. **Abrir app**:
   ```bash
   fly open
   ```

---

## Opción 5: IIS en Windows Server

### Requisitos:
- Windows Server con IIS instalado
- .NET 9.0 Runtime instalado

### Pasos:

1. **Publicar la aplicación**:
   ```bash
   cd BookStack.Web
   dotnet publish -c Release -o C:\inetpub\wwwroot\bookstack
   ```

2. **Configurar IIS**:
   - Abre IIS Manager
   - Clic derecho en Sites → Add Website
   - Site name: BookStack
   - Physical path: C:\inetpub\wwwroot\bookstack
   - Binding: http, port 80 (o el que prefieras)

3. **Instalar .NET Hosting Bundle**:
   - Descarga desde: https://dotnet.microsoft.com/download/dotnet/9.0
   - Busca "Hosting Bundle" e instala

4. **Reiniciar IIS**:
   ```bash
   iisreset
   ```

---

## Recomendaciones según caso de uso:

| Caso de uso | Plataforma recomendada | Razón |
|-------------|------------------------|-------|
| Demo/Presentación | Railway o Render | Rápido, gratis, fácil |
| Proyecto escolar | Azure (tier F1) | Integración con .NET, aprenderás Azure |
| Portfolio personal | Fly.io o Railway | Gratis, rápido, profesional |
| Producción real | Azure App Service (B1+) | Escalable, confiable, soporte |
| Servidor propio | IIS o Docker | Control total |

---

## Consideraciones sobre SQLite en producción:

SQLite tiene limitaciones en entornos de producción:
- No soporta múltiples escritores concurrentes
- Los archivos pueden perderse al reiniciar en algunos servicios
- No es ideal para alta concurrencia

**Para producción real**, considera migrar a:
- PostgreSQL (Render, Railway, Supabase tienen tiers gratuitos)
- Azure SQL Database
- MySQL/MariaDB

---

## Solución de problemas comunes:

### Error: "Database is locked"
- SQLite no maneja bien concurrencia alta
- Solución: Usar PostgreSQL o SQL Server

### Error: "Database file not found after restart"
- El contenedor perdió el volumen
- Solución: Configurar volúmenes persistentes

### Error: "HTTPS redirect not working"
- Algunos servicios manejan SSL en el proxy
- Solución: Remover `app.UseHttpsRedirection()` en producción o configurar correctamente

---

## Próximos pasos después del despliegue:

1. Configurar dominio personalizado (opcional)
2. Configurar SSL/HTTPS (la mayoría de plataformas lo hacen automáticamente)
3. Monitorear logs y errores
4. Configurar backup de la base de datos SQLite
5. Considerar migrar a PostgreSQL para mejor rendimiento

---

**¿Necesitas ayuda con alguna opción específica?** Puedo guiarte paso a paso.
