# Hornet API rest

This API provides access to the collections of Motorcycles, Automobiles, and Bodyworks registered in Hornet SA, allowing users to perform CRUD operations and retrieve data based on various filters.

## Motorcycle Endpoints

### GET /motorcycles/get

Returns a list of all motorcycles registered.

**Example response:**
```json
[
  {
    "id": 1,
    "brand": "susuki",
    "price": 10,
    "snid": "41MZCZ202135",
    "abs": true,
    "forkType": "Normal",
    "helmetIncluded": true,
    "arrivalDate": "2024-09-29T12:45:00"
  },
  {
    "id": 2,
    "brand": "yamaha",
    "price": 10,
    "snid": "41MZCZ202136",
    "abs": true,
    "forkType": "upside-down",
    "helmetIncluded": true,
    "arrivalDate": "2024-09-29T12:45:00"
  }
]
```
### GET /motorcycles/search?
Returns a single motorcycle by ID or SNID.

**Parameters:**
- `id`: The ID of the motorcycle to retrieve.
- `snid`: The SNID of the motorcycle to retrieve.

**Example response:**
```json
{
  "id": 1,
  "brand": "susuki",
  "price": 10,
  "snid": "41MZCZ202135",
  "abs": true,
  "forkType": "Normal",
  "helmetIncluded": true,
  "arrivalDate": "2024-09-29T12:45:00"
},
```
### POST /motorcycles/add
Creates a new motorcycle.

**Parameters:**
- `id`: The ID of the motorcycle.
- `brand`: The brand of the motorcycle.
- `price`: The price of the motorcycle.
- `snid`: The SNID of the motorcycle.
- `abs`: Describes if the motorcycle has o not ABS brakes.
- `forkType`: Fork typoe of the motorcycle.
- `helmetIncluded`: Describes if the motorcycles comes with helmet included
- `arrivalDate`: Describes the date when the mortorcycle arrived to the concecionar

**Example request body:**
```json
{
  "id": 2,
  "brand": "yahama",
  "price": 10,
  "snid": "41MZCZ202136",
  "abs": true,
  "forkType": "upside-down",
  "helmetIncluded": true,
  "arrivalDate": "2024-09-29T12:45:00"
}
```
### PUT /motorcycles/update/:id
Updates an existing motorcycle.

**Parameters:**
- `id`: The ID of the motorcycle.
- `brand`: The brand of the motorcycle.
- `price`: The price of the motorcycle.
- `snid`: The SNID of the motorcycle.
- `abs`: Describes if the motorcycle has o not ABS brakes.
- `forkType`: Fork typoe of the motorcycle.
- `helmetIncluded`: Describes if the motorcycles comes with helmet included
- `arrivalDate`: Describes the date when the mortorcycle arrived to the concecionar

**Example request body:**
```json
{
  "brand": "Honda", <-----changed
  "price": 10,
  "snid": "51MZCZ202147", <-----changed
  "abs": true,
  "forkType": "telescopic", <-----changed
  "helmetIncluded": true,
  "arrivalDate": "2024-09-29T12:45:00"
}
```
### DELETE /motorcycles/delete/:id
Deletes a motorcycle record by its ID.

**Parameters:**
- `id`: The ID of the motorcycle to delete.

## Bodywork Endpoints

### GET /bodyworks/get

Retrieves a list of all available bodyworks.

**Example response:**
```json
[
  {
    "id": 1,
    "name": "Sedan"
  },
  {
    "id": 2,
    "name": "SUV"
  },
  {
    "id": 3,
    "name": "Convertible"
  }
]
```
### GET /bodyworks/search?
Retrieves a single bodywork based on its ID or Name.

**Parameters:**
- `id`: The ID of the bodywork.
- `name`: The name of the bodywork.

**Example response:**
```json
{
  "id": 1,
  "name": "Sedan"
}
```
### POST /bodyworks/add
Creates a new bodywork entry in the system.

**Parameters:**
- `id`: The ID of the bodywork.
- `name`: The name of the bodywork.

**Example request body:**
```json
{
  "id": 4,
  "name": "Hatchback"
}
```
### PUT /bodyworks/update/:id
Updates the name of an existing bodywork by its ID.

- `id`: The ID of the bodywork.
- `name`: The name of the bodywork.

**Example request body:**
```json
{
  "name": "Compact" <-----changed
}
```
### DELETE /bodyworks/delete/:id
Deletes a bodywork entry from the system using its ID.

**Parameters:**
- `id`: The ID of the bodywork.

## Automobile Endpoints

### GET /automobiles/get

Retrieves a list of all registered automobiles. You can filter automobiles by ABS brake status using query parameters.

**Parameters**
- `absBrake`(optional): Filter by ABS brake status (true or false).

**Example response:**
```json
[
  {
    "id": 1,
    "brand": "Toyota",
    "price": 30000,
    "snid": "T12345",
    "absBrake": true,
    "bodyworks": [
      {
        "id": 1,
        "name": "Sedan"
      }
    ],
    "arrivalDate": "2024-10-11T10:30:00"
  },
  {
    "id": 2,
    "brand": "Honda",
    "price": 28000,
    "snid": "H56789",
    "absBrake": false,
    "bodyworks": [
      {
        "id": 2,
        "name": "SUV"
      }
    ],
    "arrivalDate": "2024-10-12T11:00:00"
  }
]

```
### GET /automobiles/search?
Retrieves a single automobile based on its ID or SNID.

**Parameters:**
- `id`: The ID of the automobile.
- `name`: The SNID of the automobile.

**Example response:**
```json
{
  "id": 1,
  "brand": "Toyota",
  "price": 30000,
  "snid": "T12345",
  "absBrake": true,
  "bodyworks": [
    {
      "id": 1,
      "name": "Sedan"
    }
  ],
  "arrivalDate": "2024-10-11T10:30:00"
}

```
### POST /automobiles/add
Creates a new automobile in the system.

**Parameters:**
- `id`: The ID of the automobile.
- `brand`: The brand of the automobile.
- `price`: The price of the automobile.
- `snid`: The SNID of the automobile.
- `absBrake`: Describes if the automobile has o not ABS brakes.
- `bodyworks`:A list containing the IDs of the associated bodyworks.
- `arrivalDate`: Describes the date when the automobile arrived at the dealership.

**Example request body:**
```json
{
  "id": 3,
  "brand": "Ford",
  "price": 25000,
  "snid": "F34567",
  "absBrake": true,
  "bodyworks": [1],
  "arrivalDate": "2024-10-13T12:00:00"
}

```
### PUT /automobiles/update/:id
Updates an existing automobile's data, including the bodywork IDs.

- `id`: The ID of the automobile.
- `brand`: The brand of the automobile.
- `price`: The price of the automobile.
- `snid`: The SNID of the automobile.
- `absBrake`: Describes if the automobile has o not ABS brakes.
- `bodyworks`:A list containing the IDs of the associated bodyworks.
- `arrivalDate`: Describes the date when the automobile arrived at the dealership.

**Example request body:**
```json
{
  "brand": "Ford",
  "price": 28000, <-----changed
  "snid": "F12345", <-----changed
  "absBrake": false, <-----changed
  "bodyworks": [2], <-----changed
  "arrivalDate": "2024-10-15T10:30:00" <-----changed
}
```
### DELETE /automobiles/delete/:id
Deletes an automobile from the system using its ID.

**Parameters:**
- `id`: The ID of the automobile.
