export function initializeRichTextBox(elementId) {
    const element = document.getElementById(elementId);
    if (element) {
        alert('RichTextBox inicializado correctamente para el elemento: ' + elementId);
    } else {
        alert('No se encontr� el elemento con ID:', elementId);
    }
}
