
import Heder from '../Heder/header';
import bgfoto from './bgfoto.jpg'
import Search  from '../Search/Search';
import PropertyCards from '../Cards/PropertyCards';
function Home(){
    return (
      <div className=''>
  <Heder></Heder>
      <img src={bgfoto} alt='BackGround'></img>

      <div className="absolute top-1/3 mt-6 left-1/2 transform -translate-x-1/2 -translate-y-1/2 text-center w-full">
        <p className="text-white text-5xl font-bold w-full">Find a home in a neighborhood you love.</p>
      <Search></Search>
      </div>
<p className='w-1/4 m5 mb-5 mt-5' style={{marginLeft:'11VW'}}>Pronaideale.com Suggestions</p>
      <PropertyCards amount={4} withdots={true}></PropertyCards> 
    </div>
  )
}

export default Home;


