import React, { useState } from 'react';

import { Icon } from '@iconify/react/dist/iconify.js';
import { Input, Button, Spacer, Checkbox, Select, SelectItem, DatePicker, type DateValue } from '@nextui-org/react';
import API from '@utils/api'; // Ajusta la ruta según sea necesario
import { format, parseISO } from 'date-fns';

 const bodies = [
  {value: "", label:""}
 ]

interface FormProps {
  endpoint: string;
  fields: { name: string, type: string, placeholder: string, options?: { value: string | number, label: string }[] }[];
}

const Form: React.FC<FormProps> = ({ endpoint, fields }) => {
  const [formData, setFormData] = useState<{ [key: string]: any }>({});
  const [dateValue, setDateValue] = useState<DateValue | null>(null);

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
    const { name, value, type } = e.target;
    if (type === 'checkbox' && e.target instanceof HTMLInputElement) {
      setFormData({ ...formData, [name]: e.target.checked });
    } else if (name === 'bodywork') {
      setFormData({ ...formData, [name]: {id : value} });
    } else {
      setFormData({ ...formData, [name]: value });
    }
  };

  const handleDateChange = (date: DateValue | null, name: string) => {
    if (date) {
      // Convertir la fecha a formato ISO
      console.log(typeof(date))
      const cluedate = new Date(date.toString())
      const isoDate = format(cluedate, "yyyy-mm-dd'T'HH:mm:ss");
      console.log(isoDate);
      setFormData({ ...formData, [name]: isoDate });
      setDateValue(date);
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

      alert('Form submitted successfully:');

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
              value={dateValue || null}
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
        <Icon icon="tabler:send-2" />
        Submit
      </Button>
    </form>
  );
};

export default Form;
