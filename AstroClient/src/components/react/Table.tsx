// src/components/react/Table.tsx
import React, { useEffect, useState } from 'react';
import {
  Table,
  TableHeader,
  TableColumn,
  TableBody,
  TableRow,
  TableCell,
  Spinner,
} from '@nextui-org/react';
import API from '@utils/api';
import Formatter from '@utils/formatter';

interface TableProps {
  endpoint: string;
  title: string;
}

const TableReact: React.FC<TableProps> = ({ endpoint, title }) => {
  const [items, setItems] = useState<any[]>([]);
  const [headers, setHeaders] = useState<string[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const formatter = Formatter.getInstance();

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await API.get(endpoint);

        // Procesar y aplanar los datos aquí
        const processedData = response.map((item: any) => {
          const flattenedItem = { ...item };

          // Aplanar el objeto anidado 'bodywork' si existe
          if (item.bodywork && typeof item.bodywork === 'object') {
            flattenedItem.bodywork = item.bodywork.name;
          }

          // Aplanar otros objetos anidados si es necesario
          // Ejemplo:
          // if (item.engine && typeof item.engine === 'object') {
          //   flattenedItem.engine = item.engine.type;
          // }

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
  }, [endpoint]);

  return (
    <div style={{ overflowX: 'auto' }}>
      {loading ? (
        <div className='flex items-center' ><Spinner className='mr-2'/>Loading...</div>
      ) : (
        <Table className="min-w-full">
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
                    {typeof item[header] === 'boolean'
                      ? formatter.booleanToString(item[header])
                      : String(item[header])}
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

export default TableReact;