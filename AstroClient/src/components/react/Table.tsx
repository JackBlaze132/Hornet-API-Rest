// src/components/react/Table.tsx

import React, { useState, useEffect } from 'react';
import FilterComponent from '@components/react/Filter';
import API from '@utils/api';
import { Spinner, Table, TableHeader, TableColumn, TableBody, TableRow, TableCell } from '@nextui-org/react';

interface FilterConfig {
  field: string;
  label: string;
}

interface TableComponentProps {
  endpoint: string;
  filterConfig: FilterConfig[]; // Añadir la configuración de filtros como prop
}

const TableComponent: React.FC<TableComponentProps> = ({ endpoint, filterConfig }) => {
  const [filters, setFilters] = useState<{ [key: string]: any }>({});
  const [items, setItems] = useState<any[]>([]);
  const [headers, setHeaders] = useState<string[]>([]);
  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await API.get(endpoint, filters);
        const processedData = response.map((item: any) => {
          const flattenedItem = { ...item };
          if (item.bodywork && typeof item.bodywork === 'object') {
            flattenedItem.bodywork = item.bodywork.name;
          }
          return flattenedItem;
        });
        setItems(processedData);
        if (processedData.length > 0) {
          setHeaders(Object.keys(processedData[0]));
        }
      } catch (error) {
        console.error('Error fetching data:', error);
      } finally {
        setLoading(false);
      }
    };
    fetchData();
  }, [endpoint, filters]);

  return (
    <div className='flex'>
      <div className='me-4'>
        <FilterComponent
          filters={filters}
          onFilterChange={(newFilters) => setFilters(newFilters)}
          filterConfig={filterConfig} // Pasar la configuración de filtros
        />
      </div>
      {loading ? (
        <div className='flex items-center'><Spinner className='mr-2'/>Loading...</div>
      ) : (
        <Table className="w-[70rem]">
          <TableHeader>
            {headers.map((header) => (
              <TableColumn key={header}>{header}</TableColumn>
            ))}
          </TableHeader>
          <TableBody>
            {items.map((item, rowIndex) => (
              <TableRow key={rowIndex}>
                {headers.map((header) => (
                  <TableCell key={header}>
                    {typeof item[header] === 'boolean' ? String(item[header]) : item[header]}
                  </TableCell>
                ))}
              </TableRow>
            ))}
          </TableBody>
        </Table>
      )}
    </div>
  );
};

export default TableComponent;