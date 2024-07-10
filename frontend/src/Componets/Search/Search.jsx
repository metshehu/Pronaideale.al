import { useState } from "react";
import SrArrow from './Arrow.svg'
import Dropdown from './Dropdown.jsx'
import SearchImg from './lens2.png'

function Search() {
    const [opsion,setopsion] = useState('For Rent')
    const [firstName, setFirstName] = useState('');
    const [count ,setcount]= useState(0);
    function changeopsion(N){
        console.log(N);
        setopsion(N)
    }
    function searchChange(new_text){
        setFirstName(new_text);
    }
    return (
        <div className='absolute left-1/4 w-1/2 mt-10 rounded-full border-solid  h-16 bg-gray-50 border'>
        <Dropdown opsion={opsion} changeopsion={changeopsion}></Dropdown>
        <img className="w-10 ml-28 mt-2 relative h-10" src={SrArrow} alt="Arrow" />

        <input laceholder="Search" className="absolute bg-gray-50 font-thin left-40 w-3/5 top-1/3" value={firstName} onChange={e => searchChange(e.target.value)} />
        <form>
            <input
                className="absolute  border-none bg-gray-50 font-thin left-40 w-3/5 top-1/3"
                type="text"
                placeholder="Place, NeigherHood , School or Agent"
                value={firstName}
                onChange={e=> searchChange(e.target.value)}
            />
        </form>
        <button><img className="absolute w-10 bg-gray-100 top-0 mt-3 right-7 h-1/2" src={SearchImg} alt="asffasd" /></button>
        
     </div>
  )
}

export default Search;


