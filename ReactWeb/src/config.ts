const config = {
    baseApiUri: "https://localhost:5000"
}


const currencyFromatter = Intl.NumberFormat("en-US",{
    style:"currency",
    currency:"USD",
    minimumFractionDigits:0,
});
export default config;
export {currencyFromatter}