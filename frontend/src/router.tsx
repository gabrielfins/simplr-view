import { BrowserRouter, Switch, Route } from 'react-router-dom';
import Navbar from './components/Navbar';
import DevAssist from './components/DevAssist';
import Home from './pages/Home';

export default function Router() {
    return (
        <BrowserRouter>
            <Navbar />
            <DevAssist />
            <Switch>
                <Route exact path="/" component={Home} />
            </Switch>
        </BrowserRouter>
    );
}
