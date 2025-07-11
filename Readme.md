 README - Rutas de ficheros en MyBlazorReflectionApp

Este proyecto usa un componente RichTextBox en una librería Blazor y lo carga dinámicamente con JavaScript y CSS.

## ¿Dónde se ponen las rutas de los ficheros?

**1. Componente RichTextBox.razor**

- Ubicación:  
  `MyBlazorReflectionApp.RichTextBoxLib/Components/RichTextBox.razor`

---

**2. Archivo JavaScript (RichTextBoxInterop.js)**

- Ubicación:  
  `MyBlazorReflectionApp.RichTextBoxLib/wwwroot/js/RichTextBoxInterop.js`

- Ruta en el código Blazor (para importarlo):  
  `./_content/MyBlazorReflectionApp.RichTextBoxLib/js/RichTextBoxInterop.js`

---

**3. Archivo CSS (RichTextBox.css)**

- Ubicación:  
  `MyBlazorReflectionApp.RichTextBoxLib/wwwroot/css/RichTextBox.css`

- Ruta en el código Blazor (para cargarlo dinámicamente o usarlo en link):  
  `./_content/MyBlazorReflectionApp.RichTextBoxLib/css/RichTextBox.css`

