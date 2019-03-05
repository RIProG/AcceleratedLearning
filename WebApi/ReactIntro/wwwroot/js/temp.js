console.log('Hello from temp.js');

let root = document.getElementById("root");

const Knapp = function () {
    return (
        <button>Goooo</button>
    )
}
//Två element måste ha en övergripande, typ en div. Vanliga html-element måste skrivas med små bokstäver (div, inte DIV/Div).
//ReactDOM.render(<div><Knapp /><Knapp /></div>, root);

class Button extends React.Component {

    state = { counter: 0, counter2: 0 }

    handleClickkkk = () => {

        this.setState((x) => {
            return { counter: x.counter + 1};

        })
    }

    handleMouseOver = () => {

        this.setState((x) => {
            return {counter2: x.counter2 +1}
        }
        )
    }

    render() {

        return (
            <div>
                <button onClick={this.handleClickkkk} onMouseOver={this.handleMouseOver}>Klicka {this.state.counter}  Mouseover {this.state.counter2}</button>
            </div>)
    }
}
ReactDOM.render(<div><Button /></div>, root);
