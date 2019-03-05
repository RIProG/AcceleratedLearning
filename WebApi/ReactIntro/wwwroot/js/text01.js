let root = document.getElementById("root");

class TextField extends React.Component {

    state = { value: "L" }

    handleInput = (event) => {

        this.setState({
            value: event.target.value

        })
    }

    render() {
        return (<div>
            <input onChange={this.handleInput} value={this.state.value} />
            <input onChange={this.handleInput} value={this.state.value} />
            <input onChange={this.handleInput} value={this.state.value} />
            <input onChange={this.handleInput} value={this.state.value} />
            <input onChange={this.handleInput} value={this.state.value} />
        </div>)
    }
}

ReactDOM.render(<div><TextField /><TextField /></div>, root);