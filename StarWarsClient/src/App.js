// src/App.js
import React, { useState, useEffect } from 'react';
import List from './components/List';
import Pagination from './components/Pagination';

const App = () => {
  const [starshipDATA, setStarshipDATA] = useState({ count: 0, results: [] });
  const [currentPage, setCurrentPage] = useState(1);
  const [recordsPerPage] = useState(5);

 
  useEffect(() => {
    //chnage the URL host name according to your api
    fetchStarships('https://localhost:44393/api/starswars/starships')
  }, []);
 
  const indexOfLastRecord = currentPage * recordsPerPage;
    const indexOfFirstRecord = indexOfLastRecord - recordsPerPage;
    const currentRecords = starshipDATA.results.slice(indexOfFirstRecord, indexOfLastRecord);
    const nPages = Math.ceil(starshipDATA.results.length / recordsPerPage)

  const fetchStarships = async (url) => {
    try {
      const response = await fetch(url);
      const data = await response.json();
      setStarshipDATA(data);
    } catch (error) {
      console.error('Error fetching starships:', error);
    }
  };

  return (
    <div>
      <h1>React Pagination Example</h1>
      <List starships={currentRecords} />
      <Pagination
                nPages={nPages}
                currentPage={currentPage}
                setCurrentPage={setCurrentPage}
            />
    </div>

    
  );
};

export default App;