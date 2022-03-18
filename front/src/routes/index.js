import { Route, Switch } from "react-router-dom";
import Navbar from "../layout/navbar";

import Home from "../views/home";
import UpdateTruck from "../views/updateTruck";

function Routes() {
    return (
        <>
            <Navbar />
            <Switch>
                <Route exact path="/" component={Home} />
                <Route exact path="/updatetruck/{:id}" component={UpdateTruck} />
            </Switch>
        </>
    );
}

export default Routes;