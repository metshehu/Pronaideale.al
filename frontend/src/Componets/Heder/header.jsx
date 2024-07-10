import { useState } from 'react'
import myImage from "./MetaData/logo2.svg";
import Profile from './Profile';
function Heder() {

        return (
      <div className='flex justify-between '>
        <div className="absolute text-white left-10 top-0 mt-4">Find an Agent</div>
        
        <button className="flex absolute left-1/2 transform -translate-x-1/2 top-0 w-32 mt-4"  > 
        <img className="" src={myImage} alt="Proneles.al" />
        <p className="absolute text-white top-1/2 left-1/2 transform -translate-x-1/3 -translate-y-1/2 ">Pronaidel.al</p>
        </button>
        <Profile></Profile>
      </div>
    )
  }
  
  export default Heder
  
