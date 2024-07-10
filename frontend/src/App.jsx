import { useEffect, useState } from 'react'
import Home from './Componets/Home/Home.jsx'
import { BrowserRouter,Routes, Route} from 'react-router-dom';

function App() {
    return (
      <BrowserRouter>
      <div>
        <Routes>
        <Route path='/' element={<Home/>}> </Route>
        </Routes>
      </div>
  </BrowserRouter>
  )
}


export default App;
