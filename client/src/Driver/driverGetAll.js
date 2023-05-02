import axios from "axios";
import { useEffect, useState } from "react";
import { urlDriver } from "../endpoints";

export function DriverGetAll() {

    const [myResponse, setMyResponse] = useState();
    useEffect(() => {
        axios.get(urlDriver).then((response) => {
            setMyResponse(response.data);
            console.log(response.data);
        });
    }, []);

    if (!myResponse) return null;

    return (
        <div>
            <h1>Drivers:</h1>
            <h2>{myResponse[0].firstName}</h2>
            <div>{myResponse.map(e=>
            <>
                <div>
                    {e.id},
                    <br></br>
                    {e.firstName},  
                    {e.lastName},
                </div>
                <br></br>
                </>
            )}
            </div>
        </div>
    );

}