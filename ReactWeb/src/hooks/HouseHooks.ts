import { House } from "../types/house";
import config from "../config";
import axios, { AxiosError } from "axios";
import { useQuery } from "@tanstack/react-query";



const useFetchHouse = () =>{

    return  useQuery<House[], AxiosError>({
        queryKey: ["houses"],
        queryFn:()=>
        axios.get(`${config.baseApiUri}/houses`)
        .then((resp)=>resp.data),
    });
};

export default useFetchHouse;