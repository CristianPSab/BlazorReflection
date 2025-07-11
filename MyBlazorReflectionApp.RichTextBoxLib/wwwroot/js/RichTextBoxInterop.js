export function initializeRichTextBox(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        alert('RichTextBox inicializado correctamente para el elemento: ' + elementId);
    } else {
        console.error('No se encontró el elemento con ID:', elementId);
    }
}

export function loadCssDynamically(cssPath) {
    const link = document.createElement("link");
    link.rel = "stylesheet";
    link.href = cssPath;
    document.head.appendChild(link);
    console.log("CSS cargado dinámicamente:", cssPath);
}





