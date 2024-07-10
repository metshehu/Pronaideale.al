
import { useEffect, useState } from 'react';
import Stockphoto from './props.jpg'
import Dtos from '../Dots/Dtos';
function PropertyCards({amount,withdots}) {
    const [index,setindex]= useState(0);
    const [Propertys,setPropertys]=useState([
        {
            "Name": "John Doe",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },
        {
            "Name": "Jane Smith",
            "Street": "456 Elm Avenue",
            "City": "Los Angeles",
            "Size": 234.56,
            "Price": 2000
        },
        {
            "Name": "Michael Johnson",
            "Street": "789 Oak Lane",
            "City": "Chicago",
            "Size": 345.67,
            "Price": 3000
        },
        {
            "Name": "Emily Brown",
            "Street": "1011 Maple Drive",
            "City": "Houston",
            "Size": 456.78,
            "Price": 4000
        },
        {
            "Name": "William Taylor",
            "Street": "1213 Cedar Road",
            "City": "Philadelphia",
            "Size": 567.89,
            "Price": 5000
        },
        {
            "Name": "John Doe1",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },
        {
            "Name": "John Doe2",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },
        {
            "Name": "John Doe3",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },{
            "Name": "John DoeASDFASDF",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },{
            "Name": "John DoeASDFASDF",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },
        {
            "Name": "John DoeASDFASDF",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },
        {
            "Name": "John DoeASDFASDF",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        },
        {
            "Name": "John DoeASDFASDF",
            "Street": "123 Main Street",
            "City": "New York",
            "Size": 123.45,
            "Price": 1000
        }
    ]
      )
      function incres(newnum){
       setindex(()=>newnum)
      }

   return (      
      <div>
        <div className='flex h-full relative justify-center '>
            
            {Propertys.slice(index,index+amount).map(props=>(
                <div className="card w-80 h-80 mx-auto rounded-lg hover:cursor-pointer shadow-lg  p-0 mr-1 ml-1">
            <img className='rounded-lg w-full h-9/12' src={Stockphoto} alt='Stockphoto'></img>
            <div className='p-4'>
            <p>${props.Price} {props.Size}</p>
            <p >{props.City}-{props.Street}</p> 
            </div>
            </div>
            ))}
            </div>
            {withdots ? <Dtos className="hover:cursor-pointer" onClick={incres} amount={amount}></Dtos>: <></>}
      </div>
  )
}

export default PropertyCards;

