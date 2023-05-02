import axios from "axios";
import { useState } from "react";
import { urlPackage } from "../endpoints";
import { useForm } from "react-hook-form";

export const PackageGetByClientId = () => {
    const [id, setId] = useState("");
    const [myResponse, setMyResponse] = useState([{}]);

    const { handleSubmit } = useForm({});
    const onSubmit = () => {
        axios.get(`${urlPackage}/clientId/${id}`)
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
                <input type="text" placeholder="id" onChange={(e) => setId(e.target.value)}></input>
                <input type="submit"></input>
            </form>
            <h1>Clients:</h1>
            <div>{myResponse.map(e=>
            <>
                <div>
                    {e.hostId}
                </div>
                <br></br>
                </>
            )}
            </div>
        </div>
    );
}

