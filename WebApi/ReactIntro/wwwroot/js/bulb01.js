let counter = 1;

class Button extends React.Component {

    handleClick = (event) => {

    }


    render() {
        return (
            <div className="button">
                <button onClick={this.handleClick} />
            </div>
        )

    }
}

class Bulb extends React.Component {

    render() {
        return (
            <div className="bulb">

                </div>
            )
    }

}

class App extends React.Component {

    render() {
        return (
            <div>
                <Bulb lejbel=""/>
                <Bulb lejbel="" />
                <Bulb lejbel="" />
                <Bulb lejbel="" />
                <Bulb lejbel="" />
            </div>
        )
    }
}