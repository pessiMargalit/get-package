import axios from "axios";
import {useState } from "react";
import { urlClient } from "../endpoints";
import {useForm} from "react-hook-form";

export const ClientDelete = ()=>{
    const [userName,setUserName] = useState("");
    const [password,setPassword] = useState("");
    const {handleSubmit} = useForm({});
    const onSubmit=()=>{
        console.log(userName);
        console.log(password);
        axios.delete(`${urlClient}/${userName}/${password}`)
                    .then(response => {
                        console.log(response.data);
                    })
                    .catch(error => {
                        console.log(error);
                    });
    }
    return(
<form onSubmit={handleSubmit(onSubmit)}>
<input type="text" placeholder="userName"  onChange={(e)=>setUserName(e.target.value)}></input>
<input type="password" placeholder="password"  onChange={(e)=>setPassword(e.target.value)}></input>
<input type="submit"></input>
</form>
    );
}


