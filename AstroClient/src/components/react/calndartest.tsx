import React, { useState } from "react";
import { DatePicker } from "@nextui-org/react";
import { format, parseISO } from "date-fns"; // Asegúrate de tener date-fns instalada
import {
  parseDate,
  now,
  getLocalTimeZone,
  parseDateTime,
} from "@internationalized/date";
const MyComponent = () => {
  const [formData, setFormData] = useState({ date: null });
  const [dateValue, setDateValue] = useState<Date | null>(null);

  const handleDateChange = (date: any | null, name: string) => {
    if (date) {
      const isoDate = format(date, "yyyy-MM-dd'T'HH:mm:ss");
      setFormData({ ...formData, [name]: isoDate });
      setDateValue(date); // Actualiza el estado del DatePicker
    } else {
      setFormData({ ...formData, [name]: null });
      setDateValue(null); // Limpia el DatePicker
    }
  };



  const uploadDate = (date: any) => {
    const clueDate = new Date(date.toString());
    const isoDAte = format(clueDate, "yyyy-mm-dd'T'HH:mm:ss");
    console.log(isoDAte);
  };

  return (
    <div>
      <DatePicker
        name="date"
        onChange={(date) => handleDateChange(date, "date")}
        label="Selecciona una fecha"
        value={dateValue} // Vincula el valor del DatePicker al estado
        showMonthAndYearPickers
        granularity="minute"
      />
      <button onClick={() => updateDatePicker("2023-10-12T14:30:00")}>
        Actualizar Fecha
      </button>
      <br />
      <button onClick={() => uploadDate(dateValue)}>Subir Fecha</button>
    </div>
  );
};
export default MyComponent;
