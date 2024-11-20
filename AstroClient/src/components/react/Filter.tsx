import React from 'react';
import { Checkbox, CheckboxGroup } from '@nextui-org/react';
import {Icon} from '@iconify/react'

interface FilterComponentProps {
  label: string;
  filters: { [key: string]: any };
  onFilterChange: (filters: { [key: string]: any }) => void;
}

const FilterComponent: React.FC<FilterComponentProps> = ({ filters, onFilterChange, label }) => {
  const handleCheckboxChange = (selectedValues: string[]) => {
    const newFilters = { ...filters };
    if (selectedValues.includes('yes')) {
      newFilters.absBrake = true;
    } else if (selectedValues.includes('no')) {
      newFilters.absBrake = false;
    } else {
      newFilters.absBrake = null;
    }
    onFilterChange(newFilters);
  };

  return (
    <div className="mb-4 bg-content1 rounded-large p-4 mr-4 w-52">
      <div className='flex items-center'><Icon className='me-2' icon="tabler:filter" /><h4 className='text-lg font-regular'> Filters</h4></div>
      <div className='ms-6'>
        <CheckboxGroup
            label={label}
            value={
            filters.absBrake === true ? ['yes'] : 
            filters.absBrake === false ? ['no'] : []
            }
            onChange={handleCheckboxChange}
        >
            <Checkbox value="yes">Yes</Checkbox>
            <Checkbox value="no">No</Checkbox>
        </CheckboxGroup>
      </div>  
    </div>
  );
};

export default FilterComponent;