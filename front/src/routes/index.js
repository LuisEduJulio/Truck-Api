import { Route, Switch } from "react-router-dom";
import Modals from "../layout/modals";
import Navbar from "../layout/navbar";

import Home from "../views/home";
import UpdateTruck from "../views/updateTruck";

function Routes() {
    return (
        <>
            <Navbar />
            <Switch>
                <Route exact path="/" component={Home} />
                <Route exact path="/updatetruck/:id" component={UpdateTruck} />
            </Switch>
            <Modals />
        </>
    );
}

export default Routes;