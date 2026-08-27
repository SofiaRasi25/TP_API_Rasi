# README – API de Mascotas

## Descripción

Este proyecto consiste en una **API REST de Mascotas** desarrollada en **C# con ASP.NET Core Web API**.

La aplicación permite administrar mascotas mediante operaciones CRUD y realizar consultas adicionales según la edad y el tipo de mascota.

Se aplicó el concepto de **herencia**, utilizando una clase abstracta `Mascota` como clase base, de la cual heredan las clases `Perro` y `Gato`.

## Modelo de clases

La estructura de las entidades es:

* **Mascota**: clase abstracta que contiene los atributos comunes.

  * Id
  * Nombre
  * Edad

* **Perro**: hereda de `Mascota` y agrega:

  * Raza

* **Gato**: hereda de `Mascota` y agrega:

  * Color

## Datos iniciales

La aplicación comienza con cuatro mascotas cargadas en memoria:

| Nombre   | Tipo  | Edad | Dato particular |
| -------- | ----- | ---: | --------------- |
| Firulais | Perro |    5 | Raza            |
| Luna     | Gato  |    3 | Color           |
| Rocky    | Perro |    8 | Raza            |
| Michi    | Gato  |   10 | Color           |

Los datos se almacenan en una **lista en memoria**, por lo que no se utiliza una base de datos.

## Endpoints

### Obtener todas las mascotas

`GET /Mascota`

Devuelve la lista completa de mascotas.

### Obtener una mascota por Id

`GET /Mascota/{id}`

Busca y devuelve una mascota según su Id.

Si la mascota no existe, devuelve una respuesta indicando que no fue encontrada.

### Registrar un perro

`POST /Mascota/perro`

Permite registrar un nuevo perro enviando sus datos.

### Registrar un gato

`POST /Mascota/gato`

Permite registrar un nuevo gato enviando sus datos.

### Modificar una mascota

`PUT /Mascota/{id}`

Permite modificar los datos de una mascota existente.

### Eliminar una mascota

`DELETE /Mascota/{id}`

Elimina una mascota de la lista utilizando su Id.

## Endpoints de desafío

### Mascotas mayores a una edad

`GET /Mascota/mayores-a/{edad}`

Devuelve todas las mascotas cuya edad sea mayor al valor indicado.

Por ejemplo:

`GET /Mascota/mayores-a/5`

Devuelve:

* Rocky
* Michi

### Mascotas por tipo

`GET /Mascota/tipo/{tipo}`

Permite consultar las mascotas según su tipo.

Ejemplos:

`GET /Mascota/tipo/perro`

Devuelve solamente los perros.

`GET /Mascota/tipo/gato`

Devuelve solamente los gatos.

## Pruebas

Los endpoints fueron probados mediante **Swagger**, verificando:

* Obtener todas las mascotas.
* Buscar una mascota existente.
* Buscar una mascota inexistente.
* Registrar un nuevo perro.
* Registrar un nuevo gato.
* Modificar una mascota.
* Eliminar una mascota.
* Consultar mascotas mayores a una determinada edad.
* Consultar mascotas según su tipo.


## Autor

**Sofía Rasi**

Trabajo práctico individual.
