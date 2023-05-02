//#region import
import React from 'react';
import logo from './logo.svg';
import './App.css';
import { DriverPost } from './Driver/driverPost';
import { DriverGetAll } from './Driver/driverGetAll';
import { ClientPost } from './Client/clientPost';
import { ClientGetAll } from './Client/clientGetAll';
import { ClientPut } from './Client/clientPut';
import { ClientDelete } from './Client/clientDelete';
import { ClientGetByUserNameAndPassword } from './Client/clientGetByUserNameAndPassword';
import { ClientGetById } from './Client/clientGetById';
//#endregion
function App() {

  return (
    <div className="App">
      <header className="App-header">

  {/* --------------Driver--------------*/}
 {/* <DriverGetAll></DriverGetAll> */}
 {/* <DriverPost></DriverPost>  */}

 {/* --------------Client--------------*/}
 <ClientGetAll/>
 {/* <ClientGetByUserNameAndPassword/> */}
 {/* <ClientGetById/> */}
 {/* <ClientPost/> */}
 {/* <ClientPut/> */}
 {/* <ClientDelete/> */}

 {/* --------------Package--------------*/}

      </header>
         </div>
  );
}

export default App;
