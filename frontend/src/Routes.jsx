import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Home from './pages/Home';
import Options from './pages/Options';
import About from './pages/About';

export default function Routes() {
    return (
        <BrowserRouter>
            <Switch>
                <Route exact path="/">
                    <Home />
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
