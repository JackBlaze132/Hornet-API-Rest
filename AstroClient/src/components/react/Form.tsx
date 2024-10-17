import React, { useState } from 'react';
import { Input, Button, Spacer, Checkbox } from '@nextui-org/react';
import API from '@utils/api'; // Ajusta la ruta según sea necesario

interface FormMotorcycleProps {
  endpoint: string;
  fields: { name: string, type: string, placeholder: string }[];
}

const FormMotorcycle: React.FC<FormMotorcycleProps> = ({ endpoint, fields }) => {
  const [formData, setFormData] = useState<{ [key: string]: any }>({});

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value, type, checked } = e.target;
    setFormData({ ...formData, [name]: type === 'checkbox' ? checked : value });
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault(); // Evitar la recarga de la página
    console.log('Form data before submit:', formData); // Verificar los datos del formulario
    try {
      const response = await API.post(endpoint, formData);
      console.log('Form submitted successfully:', response);
    } catch (error) {
      console.error('Error submitting form:', error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      {fields.map((field) => (
        <div key={field.name}>
          {field.type === 'checkbox' ? (
            <Checkbox
              name={field.name}
              checked={formData[field.name] || false}
              onChange={handleChange}
            >
              {field.placeholder}
            </Checkbox>
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
      <Button type="submit" color="warning">
        Submit
      </Button>
    </form>
  );
};

export default FormMotorcycle;