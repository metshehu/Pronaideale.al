
import { useState } from "react";
function Dropdown({opsion,changeopsion}){

    const [isOpen, setIsOpen] = useState(false);
return(

<div className="absolute left-0    h-full  inline-block text-left">

<button
  type="button"
  onClick={() => setIsOpen(!isOpen)}
  className="inline-flex w-full h-full justify-center gap-x-1.5 rounded-l-full bg-gray-200 px-3 py-2 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50"
  id="menu-button"
  aria-expanded={isOpen}
  aria-haspopup="true"
>
 <p className="mt-3">{opsion}</p> 
  <svg
    className="-mr-1 mt-3 h-5 w-5 text-gray-400"
    viewBox="0 0 20 20"
    fill="currentColor"
    aria-hidden="true"
  >
    <path className=""
      fillRule="evenodd"
      d="M5.23 7.21a.75.75 0 011.06.02L10 11.168l3.71-3.938a.75.75 0 111.08 1.04l-4.25 4.5a.75.75 0 01-1.08 0l-4.25-4.5a.75.75 0 01.02-1.06z"
      clipRule="evenodd"
    />
  </svg>
</button>

{isOpen && (
  <div className="absolute right-0 z-10 mt-2 w-28 origin-top-right rounded-md bg-white shadow-lg ring-1 text-3x1 ring-black ring-opacity-5 focus:outline-none" role="menu" aria-orientation="vertical" aria-labelledby="menu-button" tabIndex="-1">
    <div className="py-1" role="none">
      <button className="text-gray-700 block w-full px-4 py-2 text-sm" onClick={()=>{changeopsion('For Rent');setIsOpen(!isOpen)}} role="menuitem" tabIndex="-1" id="menu-item-0">For Rent</button>
      <button className="text-gray-700 block w-full px-4 py-2 text-sm" onClick={()=>{changeopsion('For Sale');setIsOpen(!isOpen)}} role="menuitem" tabIndex="-1" id="menu-item-1">For Sale</button>
      <button className="text-gray-700 block w-full px-4 py-2 text-sm"  onClick={()=>{changeopsion('Sold');setIsOpen(!isOpen)}} role="menuitem" tabIndex="-1" id="menu-item-2">Sold</button>
    </div>
  </div>
)}
</div> )}

export default  Dropdown;