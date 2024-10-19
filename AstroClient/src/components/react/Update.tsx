import React, { useState } from 'react';
import { Input, Button, Spacer, Checkbox } from '@nextui-org/react';
import API from '@utils/api'; // Ajusta la ruta según sea necesario

interface Motorcycle {
  id: number;
  brand: string;
  price: number;
  snid: string;
  absBrake: boolean;
  forkType: string;
  helmetIncluded: boolean;
  arrivalDate: string;
}

const UpdateMotorcycleForm: React.FC = () => {
  const [motorcycle, setMotorcycle] = useState<Motorcycle>({
    id: 0,
    brand: '',
    price: 0,
    snid: '',
    absBrake: false,
    forkType: '',
    helmetIncluded: false,
    arrivalDate: '',
  });

  const [searchId, setSearchId] = useState<string>('');

  const handleSearchChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setSearchId(e.target.value);
  };

  const handleSearch = async () => {
    try {
      const result = await API.get(API.SEARCH_MOTORCYCLES, { id: searchId });
      if (result.length > 0) {
        setMotorcycle(result[0]);
      } else {
        alert('Motorcycle not found');
      }
    } catch (error) {
      console.error('Error searching motorcycle:', error);
      alert('Failed to search motorcycle.');
    }
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value, type, checked } = e.target;
    setMotorcycle({
      ...motorcycle,
      [name]: type === 'checkbox' ? checked : value,
    });
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      await API.put(API.PUT_MOTORCYCLES, motorcycle);
      alert('Motorcycle updated successfully!');
    } catch (error) {
      console.error('Error updating motorcycle:', error);
      alert('Failed to update motorcycle.');
    }
  };

  return (
    <div>
      <Input
        type="text"
        placeholder="Search Motorcycle by ID"
        value={searchId}
        onChange={handleSearchChange}
      />
      <Button onClick={handleSearch}>Search</Button>
      <Spacer y={1} />
      <form onSubmit={handleSubmit}>
        <Input
          type="number"
          name="id"
          placeholder="Motorcycle ID"
          value={motorcycle.id.toString()}
          onChange={handleChange}
          required
        />
        <Spacer y={1} />
        <Input
          type="text"
          name="brand"
          placeholder="Brand"
          value={motorcycle.brand}
          onChange={handleChange}
          required
        />
        <Spacer y={1} />
        <Input
          type="number"
          name="price"
          placeholder="Price"
          value={motorcycle.price.toString()}
          onChange={handleChange}
          required
        />
        <Spacer y={1} />
        <Input
          type="text"
          name="snid"
          placeholder="SNID"
          value={motorcycle.snid}
          onChange={handleChange}
          required
        />
        <Spacer y={1} />
        <Checkbox
          name="absBrake"
          checked={motorcycle.absBrake}
          onChange={handleChange}
        >
          ABS Brake
        </Checkbox>
        <Spacer y={1} />
        <Input
          type="text"
          name="forkType"
          placeholder="Fork Type"
          value={motorcycle.forkType}
          onChange={handleChange}
          required
        />
        <Spacer y={1} />
        <Checkbox
          name="helmetIncluded"
          checked={motorcycle.helmetIncluded}
          onChange={handleChange}
        >
          Helmet Included
        </Checkbox>
        <Spacer y={1} />
        <Input
          type="datetime-local"
          name="arrivalDate"
          placeholder="Arrival Date"
          value={motorcycle.arrivalDate}
          onChange={handleChange}
          required
        />
        <Spacer y={1} />
        <Button type="submit">Update Motorcycle</Button>
      </form>
    </div>
  );
};

export default UpdateMotorcycleForm;