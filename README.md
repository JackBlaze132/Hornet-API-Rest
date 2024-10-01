# Hornet API rest

This API provides access to the collection of motorcycles registered in Hornet SA., including Brand, SNIND and more.

## Endpoints

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
Deletes a motorcycle.

**Parameters:**
- `id`: The ID of the motorcycle to delete.
