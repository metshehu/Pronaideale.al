import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import axios from "axios"
function App() {
  const [count, setCount] = useState(0)
  const [users,setusers]= useState([]);
  async function oClick(){
  
    fetch('http://localhost:5207/api/Users')
    .then(response => response.json())
    .then(data => setusers(data));
  }
  return (
    <>
          <h1 className="text-3xl font-bold underline">
      Hello world! helllo no way bro
    </h1>
    <p className='text-3xl font-bold underline-offset-1'>hello met hi bennet ku je shkemb</p>
    <button onClick={oClick}>CLICKME</button>
    {users.length >0 ?users.map(x=><><p>{x.name} this is my fritnsn ame</p><p>{x.lastname} -- this is my last name</p></>):<></>}
    </>
  )
}

export default App
