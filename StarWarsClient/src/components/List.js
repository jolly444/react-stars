// src/List.js
import React from 'react';

const List = ({ starships  }) => {
  return (

    
    <div>
      <h1>Starships</h1>
      <ul>
        {starships.map((starship) => (
          <li key={starship.url}>
            <h3>{starship.name}</h3>
            <p>Model: {starship.model}</p>
            <p>Manufacturer: {starship.manufacturer}</p>
            {/* Add more details as needed */}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default List;