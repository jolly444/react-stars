// src/App.js
import React, { useState, useEffect } from 'react';
import List from './components/List';
import Pagination from './components/Pagination';

const App = () => {
  const [starshipDATA, setStarshipDATA] = useState({ count: 0, results: [] });
 
  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch('https://localhost:44393/api/starswars/starships');
        const data = await response.json();
        setStarshipDATA(data);
      } catch (error) {
        console.error('Error fetching starships data:', error);
      }
    };

    fetchData();
  }, []);
 
  return (
    <div>
      <h1>React Pagination Example</h1>
      <List starships={starshipDATA.results} />
      {/* <Pagination currentPage={currentPage} totalPages={totalPages} onPageChange={handlePageChange} /> */}
    </div>
  );
};

export default App;