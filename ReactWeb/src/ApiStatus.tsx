type Args = {
    status: "success" | "error" | "pending";
};


const ApiStatus = ({status}:Args)=>{
    switch(status){
        case "error":
            return <div>Error communicating with the server</div>
        case "pending":
            return <div>Loading....</div>;
        default:
            throw Error("Unknown API status"); 
    }
}

export default ApiStatus;