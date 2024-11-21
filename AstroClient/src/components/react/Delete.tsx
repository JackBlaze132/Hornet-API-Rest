import React, { useState } from 'react';
import {Icon} from '@iconify/react'
import { Input, Button, Spacer, Card, CardHeader, CardBody, Divider } from '@nextui-org/react';
import API from '@utils/api'; // Asegúrate de importar correctamente la clase API
import Formatter from '@utils/formatter'; // Asegúrate de importar correctamente la clase Formatter

interface DisplayCardProps {
  endpoint: string;
  enddelete: string
}

const DisplayCard: React.FC<DisplayCardProps> = ({ endpoint, enddelete }) => {
  const [data, setData] = useState<{ [key: string]: any } | null>(null);
  const [searchId, setSearchId] = useState<string>('');
  const formmatter = Formatter.getInstance();

  const handleSearchChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setSearchId(e.target.value);
  };

  const handleSearch = async () => {
    if (!searchId.trim()) {
      alert('Please enter a valid ID.');
      return;
    }
    try {
      const result = await API.get(endpoint, { id: searchId });
      console.log(searchId);
      if (result.length > 0) {
        setData(result[0]);
      } else {
        alert('Item not found');
      }
    } catch (error) {
      console.error('Error fetching data:', error);
      alert('Item not found');
    }
  };

  const handleDelete = async () => {
    if (!searchId.trim()) {
      alert('Please enter a valid ID.');
      return;
    }
    try {
      await API.delete( enddelete, searchId);
      alert('Item deleted successfully');
      setData(null);
      setSearchId('');
    } catch (error) {
      console.error('Error deleting data:', error);
      alert('Error deleting data');
    }
  };

  return (
    <div>
      <Input
        placeholder="Search ID"
        value={searchId}
        onChange={handleSearchChange}
      />
      <Spacer y={1} />
      <Button onClick={handleSearch}><Icon icon="tabler:search" className="icon" />Search</Button>
      <Spacer y={1} />
      {data ? (
        <div>
          <Card>
            <CardHeader>
              <h4 className='text-lg'>Details</h4>
            </CardHeader>
            <Divider />
            <CardBody>
              {Object.keys(data).map((key) => {
                if (key === 'bodywork' && data[key]) {
                  return (
                    <div key={key}>
                      <strong>Bodywork:</strong> {data[key].name}
                    </div>
                  );
                }
                return (
                  <p key={key}>
                    <strong>{key}:</strong> {typeof data[key] === 'boolean' ? formmatter.booleanToString(data[key]) : data[key]}
                  </p>
                );
              })}
            </CardBody>
          </Card>
          <Button color="danger" onClick={handleDelete} className="max-w-[250px]">
            <Icon icon="tabler:trash-x" />Delete
          </Button>
        </div>
      ) : null}
      
    </div>
  );
};

export default DisplayCard;