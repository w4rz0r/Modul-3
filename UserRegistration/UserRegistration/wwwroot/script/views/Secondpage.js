views.Secondpage = () => {
    return /*HTML*/ `
        ${getNavigation()}
        <div>Hello World!</div>
        <button onclick="render('Homepage')">Back to Homepage</button>
        ${getFooter()}
    `;
}