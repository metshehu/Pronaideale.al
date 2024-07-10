import { useState } from "react";

function Dtos({onClick,amount}) {
    const [selecotr,setselector] = useState(0)
    function chnageColor(index){
        const calindexstart=index*amount
        setselector(()=>index)

        onClick(calindexstart)
    }
    return (

            <div className='flex justify-center  mt-5 mb-5'>
                <div className="flex justify-between w-10">
                
                    {Array(3).fill(null).map((x,i)=>(
                        <div 
                        className={i==selecotr ? 
                            'w-3 h-3 rounded-lg background bg-gray-600 hover:cursor-pointer':
                             'w-3 h-3 rounded-lg background bg-gray-300 hover:cursor-pointer'} 
                        onClick={()=>{chnageColor(i)}} ></div>
                    ))}
                    </div> 
            </div>
    )}
export default Dtos;