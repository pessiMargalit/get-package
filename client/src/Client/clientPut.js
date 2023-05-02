import axios from "axios";
import {useState } from "react";
import { urlClient } from "../endpoints";
import {useForm} from "react-hook-form";
import {yupResolver} from "@hookform/resolvers/yup";
import * as yup from "yup";

export const ClientPut = ()=>{
    const [id,setId] = useState(0);
    const schema = yup.object().shape({
        id:yup.string().length(9).required(),
        firstName:yup.string().required("First name is required"),
        lastName:yup.string().required("Last name is required"),
        phoneNumber:yup
        .string()
        .matches(
          /^((\\+[1-9]{1,4}[ \\-]*)|(\\([0-9]{2,3}\\)[ \\-]*)|([0-9]{2,4})[ \\-]*)*?[0-9]{3,4}?[ \\-]*[0-9]{3,4}?$/,
          "Enter a valid phone number"
        ).required(),
        email:yup.string().email().required(),
        userName:yup.string().required(),
        password:yup.string().min(5).max(12).required()


    })
    const { register, handleSubmit,formState:{errors} } = useForm({
        resolver:yupResolver(schema),
    });
    const onSubmit=(data)=>{
        axios.put(`${urlClient}/${id}`, data)
                    .then(response => {
                        console.log(response.data);
                        console.log(data);
                    })
                    .catch(error => {
                        console.log(error);
                    });
    }
    return(
<form onSubmit={handleSubmit(onSubmit)}>
<input type="text" placeholder="firstName" {...register("firstName")}></input>
<p>{errors.firstName?.message}</p>
<input type="text" placeholder="lastName" {...register("lastName")}></input>
<p>{errors.lastName?.message}</p>
<input type="text" placeholder="id" onChange={(e)=>setId(e.target.value)} {...register("id")}></input>
<p>{errors.id?.message}</p>
<input type="text" placeholder="phoneNumber" {...register("phoneNumber")}></input>
<p>{errors.phoneNumber?.message}</p>
<input type="email" placeholder="email" {...register("email")}></input>
<p>{errors.email?.message}</p>
<input type="text" placeholder="userName" {...register("userName")}></input>
<p>{errors.userName?.message}</p>
<input type="password" placeholder="password" {...register("password")}></input>
<p>{errors.password?.message}</p>
<input type="submit"></input>
</form>
    );
}


