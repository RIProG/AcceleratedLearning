let root = document.getElementById("root");

class Textruta extends React.Component {

    state = {
        value: "",
        backgroundColor: "white"
    }

    handleInput = (event) => {

        let regex = RegExp(this.props.validera);
        if (this.props.ignoreracasing) {
            if (regex.test(event.target.value.toUpperCase())) {
                this.setState({ backgroundColor: "green" });
            }
            else {
                this.setState({ backgroundColor: "red" });
            }

        }
        else {
            if (regex.test(event.target.value)) {
                this.setState({ backgroundColor: "green" });
            }
            else {
                this.setState({ backgroundColor: "red" });
            }
        }

        this.setState({
            value: event.target.value
        })
    }

    render() {
        return (
            <div className="textwrap">
                <label>{this.props.lejbel}</label>
                <input validera={this.props.validera} ignoreracasing={this.props.ignoreracasing}
                    onChange={this.handleInput} value={this.state.value}
                    style={{ backgroundColor: this.state.backgroundColor }}/>
            </div>
        )
    }
}

class App extends React.Component {

    render() {
        return (
            <div>
                <Textruta lejbel="Förnamn" />
                <Textruta lejbel="Efternamn" validera="son$" />
                <Textruta lejbel="Email" validera="\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b" ignoreracasing="true" />
            </div>
        )
    }
}

ReactDOM.render(<div><App /></div>, root);