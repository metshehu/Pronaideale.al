import { useState } from 'react'
function Profile() {

    return (
        <button className='absolute right-10 top-0 flex border border-solid rounded-md border-black p-1 mt-3'> 
            <div className='w-7 h-6 bg-cyan-700 border border-solid rounded-md border-black relative'>
                <p className='absolute top-0'>MS</p>
            </div>

            <div class="flex items-center justify-center h-6">
              <div class="text-black text-3xl w-2 h-9">&#x2807;</div>
          </div>
        </button>
    ) 
    
  }
  
  export default Profile; 
  
