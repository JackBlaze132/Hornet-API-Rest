import React, { useState, useEffect } from 'react';
import { Card, CardHeader, CardBody, Input, Button, Spacer, Divider } from '@nextui-org/react';
import API from '@utils/api';
import Formatter from '@utils/formatter';
import { Icon } from '@iconify/react';

interface DisplayCardProps {
  endpoint: string;
}

const DisplayCard: React.FC<DisplayCardProps> = ({ endpoint }) => {
  const [data, setData] = useState<{ [key: string]: any } | null>(null);
  const [searchId, setSearchId] = useState<string>(''); // Primer campo de búsqueda
  const [secondarySearch, setSecondarySearch] = useState<string>(''); // Segundo campo de búsqueda
  const [secondaryPlaceholder, setSecondaryPlaceholder] = useState<string>(''); // Placeholder dinámico
  const formatter = Formatter.getInstance();

  // Cambia el placeholder dinámicamente basado en el endpoint
  useEffect(() => {
    if (endpoint.includes('automobiles')) {
      setSecondaryPlaceholder('Search SNID'); // Campo para SNID en Automobiles
    } else if (endpoint.includes('bodyworks')) {
      setSecondaryPlaceholder('Search Name'); // Campo para Name en Bodyworks
    } else {
      setSecondaryPlaceholder('Search'); // Placeholder genérico
    }
  }, [endpoint]);

  const handleSearchIdChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setSearchId(e.target.value);
  };

  const handleSecondarySearchChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setSecondarySearch(e.target.value);
  };

  const handleSearch = async () => {
    if (!searchId.trim() && !secondarySearch.trim()) {
      alert('Please enter valid search criteria.');
      return;
    }
    try {
      const searchParams: { id?: string; name?: string; snid?: string } = {};
      if (searchId.trim()) searchParams.id = searchId.trim();

      // Configura el segundo parámetro basado en el contexto
      if (endpoint.includes('automobiles') && secondarySearch.trim()) {
        searchParams.snid = secondarySearch.trim(); // Segundo campo busca por SNID
      } else if (endpoint.includes('bodyworks') && secondarySearch.trim()) {
        searchParams.name = secondarySearch.trim(); // Segundo campo busca por Name
      }

      const result = await API.get(endpoint, searchParams);
      if (result.length > 0) {
        setData(result[0]);
      } else {
        alert('Item not found');
        setData(null);
      }
    } catch (error) {
      console.error('Error fetching data:', error);
      alert('Error fetching data');
    }
  };

  return (
    <div>
      {/* Campo para Search ID */}
      <Input
        placeholder="Search ID"
        value={searchId}
        onChange={handleSearchIdChange}
      />
      <Spacer y={1} />

      {/* Campo dinámico para Search Name o Search SNID */}
      <Input
        placeholder={secondaryPlaceholder}
        value={secondarySearch}
        onChange={handleSecondarySearchChange}
      />
      <Spacer y={1} />

      <Button onClick={handleSearch}>
        <Icon icon="tabler:search" className="icon" />
        Search
      </Button>
      <Spacer y={1} />

      {data ? (
        <Card>
          <CardHeader>
            <h4 className="text-lg">Details</h4>
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
                  <strong>{key}:</strong>{' '}
                  {typeof data[key] === 'boolean'
                    ? formatter.booleanToString(data[key])
                    : data[key]}
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
