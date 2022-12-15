function getNavigation() {
    return /*HTML*/ `
    <nav>
        <div class="nav-links" id="navLinks">
            <ul>
                <li><a onclick="render('Homepage');">Home</a></li>
                <li><a onclick="render('Secondpage');">Second Page</a></li>
            </ul>
        </div>
    </nav>
    `;
}

function getFooter() {
    return /*HTML*/`
    <div class="icons">
        <i class="fa fa-facebook"></i>
        <i class="fa fa-twitter"></i>
        <i class="fa fa-instagram"></i>
        <i class="fa fa-linkedin"></i>
        <i class="fa fa-github"></i>
    </div>
    `}