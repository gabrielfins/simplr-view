import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Navbar from 'components/Navbar';
import Sales from 'pages/Sales';
import Clients from 'pages/Clients';
import Suppliers from 'pages/Suppliers';
import Employees from 'pages/Employees';
import AddClient from 'pages/add/Client';
import AddSupplier from 'pages/add/Supplier';
import AddEmployee from 'pages/add/Employee';
import Report from 'pages/Report';
import Options from 'pages/Options';
import About from 'pages/About';

export default function Routes() {
    return (
        <BrowserRouter>
            <Navbar />
            <Switch>
                <Route exact path="/">
                    <Sales />
                </Route>
                <Route exact path="/clients">
                    <Clients />
                </Route>
                <Route exact path="/suppliers">
                    <Suppliers />
                </Route>
                <Route exact path="/employees">
                    <Employees />
                </Route>
                <Route path="/clients/add">
                    <AddClient />
                </Route>
                <Route path="/suppliers/add">
                    <AddSupplier />
                </Route>
                <Route path="/employees/add">
                    <AddEmployee />
                </Route>
                <Route path="/report">
                    <Report />
                </Route>
                <Route path="/options">
                    <Options />
                </Route>
                <Route path="/about">
                    <About />
                </Route>
            </Switch>
        </BrowserRouter>
    );
}
