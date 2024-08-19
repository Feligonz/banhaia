# Proyecto de ejemplo

Este proyecto es una aplicación en asp.net con angular, separado en cliente y servidor

La arquitectura de la solución asp.net es de tipo "N-LAYER"

Para la aplicación de angular se dejó lo mínimo e indispensable para mostrar datos

## Requisitos

- Visual Studio 2022 / vscode latest
- Sql server express 2019
- Nodejs +v20

## Pasos de Configuración

1. **Entrar a la configuración inicial del sistema**
   - Abrir el navegador y dirigirse a
     ```
     https://localhost:7089/sistema/setup
     ```
   - Esto creará la base de datos sql server necesaria

2. **Crear contactos iniciales**
   - Para crear los contactos iniciales, dirigirse a
     ```
     https://localhost:7089/api/contactos/testdata
     ```

3. **Ver el resultado en la aplicación**
   - Finalmente, abir la app de angular:
     ```
     https://localhost:4200/
     ```

## Ejercicio

El objetivo del ejercicio es implementar nuevas funciones en el backend y frontend

Se priorizará el código del backend, siendo éste desde donde tienen que salir las nuevas funciones. Para el frontend no es necesario explayarse demasiado

Se ejemplifican dos posibles módulos a realizar para que se comprenda el nivel de complejidad que se requiere

### Ejemplo 1 - Módulo de empresas

Backend:
- Modelo Empresa. Una empresa puede tener N contactos
- Service de empresa
- Adaptacion modulo contacto

Frontend:
- Listado empresas
- Botón que crea empresa con contactos
- Botón que modifica empresa de un contacto existente

### Ejemplo 2 - Sistema de notificaciones

Backend:
- Tabla de notificaciones
- Service de notificaciones
- Adaptacion modulo contacto para relacionar notificaciones y ver cuantas tiene pendientes

Frontend:
- Listado de contactos con filtro de notificaciones pendientes
- Botón crear notificación a contacto
- Botón marcar leída notificación
- Botón envio masivo de notificaciones

---

Banhaia - NinoxNet - 2024
