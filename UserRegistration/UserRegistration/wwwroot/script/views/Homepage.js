views.Homepage = () => {
    return /*HTML*/`
            ${getNavigation()}
            <ul>
                ${createPeopleHtml()}
            </ul>
            <hr/>
            Fornavn:<br/>
            <input
                type="text"
                oninput="model.inputs.firstName=this.value"
                value="${model.inputs.firstName || ''}"
            /><br/>
            E-post:<br/>
            <input

            type="text"
            oninput="model.inputs.email=this.value"
            value="${model.inputs.email || ''}"
            /><br/>

            <button onclick="createOrUpdatePerson()">
                ${model.inputs.id == null ? 'Lag ny' : 'Rediger'}
            </button>

            <button onclick="render('Secondpage')">Render Second Page</button>
            ${getFooter()}
            `;
}

async function getData() {
    const response = await axios.get('/people');
    model.people = response.data;
    render();
}

function createPeopleHtml() {
    return model.people.map(p => /*HTML*/`
                <li>
                    ${p.firstName}
                    ${p.email}
                    <button onclick="editPerson('${p.id}')">rediger</button>
                    <button onclick="deletePerson('${p.id}')">x</button>
                </li>
                `).join('');
}

function createOrUpdatePerson() {
    if (model.inputs.id == null) createPerson();
    else updatePerson();
    model.inputs = {
        id: null,
        firstName: null,
        email: null,
    };
    render();
}

function createPerson() {
    const person = {
        id: Math.random().toString(16).slice(2),
        firstName: model.inputs.firstName,
        email: model.inputs.email,
    };
    model.people.push(person);
}

function updatePerson() {
    const person = model.people.find(p => p.id == model.inputs.id);
    if (person == null) return;
    person.firstName = model.inputs.firstName;
    person.email = model.inputs.email;
}

async function deletePerson(id) {
    const response = await axios.delete('/people/' + id);
    getData();
}

function editPerson(id) {
    const person = model.people.find(p => p.id == id);
    if (person == null) return;
    model.inputs.id = person.id;
    model.inputs.firstName = person.firstName;
    model.inputs.email = person.email;
    render();
}