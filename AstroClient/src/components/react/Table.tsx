import React from 'react';
import { Table, TableHeader, TableColumn, TableBody, TableRow, TableCell } from '@nextui-org/react';
import Formatter from '@utils/formatter'; // Ajusta la ruta según sea necesario

interface TableProps {
  items: any[];
  title: string;
  headers: string[];
}

const TableReact: React.FC<TableProps> = ({ items, title, headers }) => {
  const formatter = Formatter.getInstance(); // Obtiene la instancia de Formatter

  return (
    <div style={{ overflowX: 'auto' }}>
      <h2 style={{ fontSize: '2rem', fontWeight: 'bold', marginBottom: '1rem', color: 'white' }}>
        {title} Table
      </h2>
      <Table className="min-w-full">
        <TableHeader className="bg-gray-200">
        {items.length === 0 ? (
            <TableColumn colSpan={headers.length} style={{ textAlign: 'center' }}>
              No data found
            </TableColumn>
          ) : (
            headers.map((header, index) => (
              <TableColumn key={index}>{header}</TableColumn>
            ))
          )}
        </TableHeader>
        <TableBody>
          {items.map((item, rowIndex) => (
            <TableRow key={rowIndex} className="">
              {headers.map((header, colIndex) => (
                <TableCell key={colIndex} textValue={item[header]?.toString() || ''}>
                  {typeof item[header] === 'boolean' ? formatter.booleanToString(item[header]) :
                   typeof item[header] === 'string' && header.toLowerCase().includes('date') ? formatter.formatDate(item[header]) :
                   item[header] === null ? formatter.nulltoN_A(item[header]) : 
                   item[header]}
                </TableCell>
              ))}
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </div>
  );
};

export default TableReact;