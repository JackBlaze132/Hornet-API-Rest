import React, { useState, useEffect } from 'react';
import { Input, Button, Spacer, Checkbox, Select, SelectItem } from '@nextui-org/react';
import API from '@utils/api'; // Ajusta la ruta según sea necesario

interface UpdateFormProps {
  endpoint: string;
  fields: { name: string, type: string, placeholder: string, options?: { value: string | number, label: string }[] }[];
  searchEndpoint: string;
  bodyworks?: { value: string | number, label: string }[]; // Hacer que bodyworks sea opcional
}

const UpdateForm: React.FC<UpdateFormProps> = ({ endpoint, fields, searchEndpoint, bodyworks }) => {
  const [formData, setFormData] = useState<{ [key: string]: any }>({});
  const [searchId, setSearchId] = useState<string>('');

  const handleSearchChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setSearchId(e.target.value);
  };

  const handleSearch = async () => {
    if (!searchId.trim()) {
      alert('Please enter a valid ID.');
      return;
    }
    try {
      const result = await API.get(searchEndpoint, { id: searchId });
      if (result.length > 0) {
        const item = result[0];
        setFormData(item);
        if (item.bodyworks && item.bodyworks.length > 0) {
          setFormData((prevData) => ({
            ...prevData,
            bodyworks: item.bodyworks[0].id
          }));
        }
      } else {
        alert('Item not found');
      }
    } catch (error) {
      console.error('Error searching item:', error);
      alert('Failed to search item.');
    }
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value, type, checked } = e.target;
    if (type === 'checkbox' && e.target instanceof HTMLInputElement) {
      setFormData({ ...formData, [name]: checked });
    } else {
      setFormData({ ...formData, [name]: value });
    }
  };

  const handleSelect = (e: React.ChangeEvent<HTMLSelectElement>) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      await API.put(`${endpoint}/${formData.id}`, formData);
      alert('Item updated successfully!');
    } catch (error) {
      console.error('Error updating item:', error);
      alert('Failed to update item.');
    }
  };

  return (
    <div>
      <Input
        type="text"
        placeholder="Search by ID"
        value={searchId}
        onChange={handleSearchChange}
      />
      <Button onClick={handleSearch}>Search</Button>
      <Spacer y={1} />
      <form onSubmit={handleSubmit}>
        {fields.map((field) => (
          <div key={field.name}>
            {field.type === 'checkbox' ? (
              <Checkbox
                name={field.name}
                isSelected={formData[field.name] || false}
                onChange={handleChange}
              >
                {field.placeholder}
              </Checkbox>
            ) : field.type === 'select' ? (
              <Select
                name={field.name}
                value={formData[field.name] || ''}
                onChange={handleSelect}
                label={field.placeholder}
                fullWidth
              >
                {(bodyworks || []).map((body) => (
                  <SelectItem key={body.value} value={body.value}>
                    {body.label}
                  </SelectItem>
                ))}
              </Select>
            ) : (
              <Input
                type={field.type}
                name={field.name}
                value={formData[field.name] || ''}
                onChange={handleChange}
                fullWidth
                isClearable
                placeholder={field.placeholder}
              />
            )}
            <Spacer y={1} />
          </div>
        ))}
        <Button type="submit">Update</Button>
      </form>
    </div>
  );
};

export default UpdateForm;