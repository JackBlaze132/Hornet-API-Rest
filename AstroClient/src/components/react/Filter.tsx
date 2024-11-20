import React from 'react';
import { Checkbox, CheckboxGroup } from '@nextui-org/react';
import { Icon } from '@iconify/react';

interface FilterConfig {
  field: string;
  label: string;
}

interface FilterComponentProps {
  filters: { [key: string]: any };
  onFilterChange: (filters: { [key: string]: any }) => void;
  filterConfig: FilterConfig[]; // Recepción de la configuración de filtros
}

const FilterComponent: React.FC<FilterComponentProps> = ({ filters, onFilterChange, filterConfig }) => {
  const handleCheckboxChange = (field: string, selectedValues: string[]) => {
    const newFilters = { ...filters };
    if (selectedValues.includes('yes')) {
      newFilters[field] = true;
    } else if (selectedValues.includes('no')) {
      newFilters[field] = false;
    } else {
      delete newFilters[field];
    }
    onFilterChange(newFilters);
  };

  return (
    <div className="mb-4 bg-content1 rounded-large p-4 mr-4 w-52">
      <div className='flex items-center'>
        <Icon className='me-2' icon="tabler:filter" />
        <h4 className='text-lg font-regular'>Filters</h4>
      </div>
      <div className='ms-6'>
        {filterConfig.map(({ field, label }) => (
          <CheckboxGroup
            key={field}
            label={label}
            value={
              filters[field] === true ? ['yes'] :
              filters[field] === false ? ['no'] :
              []
            }
            onChange={(selected) => handleCheckboxChange(field, selected)}
          >
            <Checkbox value="yes">Yes</Checkbox>
            <Checkbox value="no">No</Checkbox>
          </CheckboxGroup>
        ))}
      </div>  
    </div>
  );
};

export default FilterComponent;