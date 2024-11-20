import React, { useState } from 'react';
import { Card, CardHeader, CardBody, CardFooter, Input, Button, Spacer, Divider } from '@nextui-org/react';
import API from '@utils/api'; // Ajusta la ruta según sea necesario
import Formatter from '@utils/formatter';
import {Icon} from '@iconify/react'

interface DisplayCardProps {
  endpoint: string;
}

const DisplayCard: React.FC<DisplayCardProps> = ({ endpoint }) => {
  const [data, setData] = useState<{ [key: string]: any } | null>(null);
  const [searchId, setSearchId] = useState<string>('');
  const formmatter = Formatter.getInstance()

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
      if (result.length > 0) {
        setData(result[0]);
      } else {
        alert('Item not found');
      }
    } catch (error) {
      console.error('Error fetching data:', error);
      alert('Error fetching data');
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
        <Card>
          <CardHeader>
            <h4 className='text-lg'>Details</h4>
          </CardHeader>
          <Divider />
          <CardBody>
            {Object.keys(data).map((key) => {
              if (key === 'bodywork' && data[key]){
                return (
                  <div key={key}>
                    <strong>Bodywork:</strong> {data[key].name}
                  </div>
                );
              }
              return(
              <p key={key}>
                <strong>{key}:</strong> {typeof data[key] === 'boolean' ? formmatter.booleanToString(data[key]) : data[key]}
              </p>
              );
            })}
          </CardBody>
        </Card>
      ) : (
        <div>No data to display</div>
      )}
    </div>
  );
};

export default DisplayCard;