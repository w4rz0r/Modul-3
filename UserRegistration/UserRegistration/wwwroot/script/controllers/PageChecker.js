const appElement = document.getElementById('app'), views = {};

function render(page) {
    if (page) model.state.page = page;
    if (!(model.state.page in views)) {
        console.error(`view "${model.state.page}" doesn't exist.`);
        return;
    }
    const html = views[model.state.page]();
    if (html == undefined) return;
    appElement.innerHTML = html;
}