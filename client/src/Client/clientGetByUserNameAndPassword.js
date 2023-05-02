import axios from "axios";
import { useState } from "react";
import { urlClient } from "../endpoints";
import { useForm } from "react-hook-form";

export const ClientGetByUserNameAndPassword = () => {
    const [userName, setUserName] = useState("");
    const [password, setPassword] = useState("");
    const [myResponse, setMyResponse] = useState({});

    const { handleSubmit } = useForm({});
    const onSubmit = () => {
        console.log(userName);
        console.log(password);
        axios.get(`${urlClient}/${userName}/${password}`)
            .then(response => {
                console.log(response.data);
                setMyResponse(response.data);

            })
            .catch(error => {
                console.log(error);
            });
    }
    return (

        <div>
            <form onSubmit={handleSubmit(onSubmit)}>
                <input type="text" placeholder="userName" onChange={(e) => setUserName(e.target.value)}></input>
                <input type="password" placeholder="password" onChange={(e) => setPassword(e.target.value)}></input>
                <input type="submit"></input>
            </form>
            <h1>Clients:</h1>
            <h2>{myResponse.id}</h2>
            <h2>{myResponse.firstName}</h2>
            <h2>{myResponse.lastName}</h2>

        </div>
    );
}

