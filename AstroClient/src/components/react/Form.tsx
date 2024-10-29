import React, { useState } from 'react';
import { Icon } from '@iconify/react/dist/iconify.js';
import { Input, Button, Spacer, Checkbox, Select, SelectItem, DatePicker } from '@nextui-org/react';
import API from '@utils/api'; // Ajusta la ruta según sea necesario
import { format } from 'date-fns';

 const bodies = [
  {value: "", label:""}
 ]

interface FormProps {
  endpoint: string;
  fields: { name: string, type: string, placeholder: string, options?: { value: string | number, label: string }[] }[];
}

const Form: React.FC<FormProps> = ({ endpoint, fields }) => {
  const [formData, setFormData] = useState<{ [key: string]: any }>({});

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
    const { name, value, type } = e.target;
    if (type === 'checkbox' && e.target instanceof HTMLInputElement) {
      setFormData({ ...formData, [name]: e.target.checked });
    } else if (name === 'bodyworks') {
      setFormData({ ...formData, [name]: [value] });
    } else {
      setFormData({ ...formData, [name]: value });
    }
  };

  const handleDateChange = (date: any, name: string) => {
    if (date) {
      // Convertir la fecha a formato ISO
      console.log(date)
      const isoDate = format(date, "yyyy-mm-dd'T'HH:mm:ss");
      console.log(isoDate);
      setFormData({ ...formData, [name]: isoDate });
    } else {
      setFormData({ ...formData, [name]: null });
    }
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
          ) : field.type === 'select' ? (
            <Select
              name={field.name}
              value={formData[field.name] || ''}
              onChange={handleChange}
              label={field.placeholder}
              fullWidth
            >
              {field.options ? (
                field.options.map((option) => (
                  <SelectItem key={option.value} value={option.value} textValue={option.label}>
                    {option.label}
                  </SelectItem>
                ))
              ) : (
                bodies.map((body) => (
                  <SelectItem key={body.value} value={body.value} textValue={body.label}>
           
                  </SelectItem>
                ))
              )}
            </Select>
          ) : field.type === 'datetime-local' ?(
            <DatePicker
              calendarProps={{
                color: "danger"
              }}
              name={field.name}
              onChange={(date) => handleDateChange(date, field.name)} // Cambiado aquí
              label={field.placeholder}
              showMonthAndYearPickers
              granularity='minute'
              selectorIcon={<Icon icon="tabler:calendar-clock" />}
            />
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

export default Form;