import axios from "axios";
import { useEffect, useState } from "react";
import { urlClient } from "../endpoints";

export function ClientGetAll() {

    const [myResponse, setMyResponse] = useState();
    useEffect(() => {
        axios.get(urlClient).then((response) => {
            setMyResponse(response.data);
            console.log(response.data);
        });
    }, []);

    if (!myResponse) return null;

    return (
        <div>
            <h1>Clients:</h1>
            <div>{myResponse.map(e=>
            <>
                <div>
                    {e.id},
                    <br></br>
                    {e.firstName},  
                    {e.lastName},
                    <br></br>
                    <p>packages:</p>
                    {e.packages.map(p=>
                        <p>{p._Id}</p>
                         )}
                </div>
            
                <br></br>
                </>
            )}
            </div>
        </div>
    );
}