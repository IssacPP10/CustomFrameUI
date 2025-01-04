
# Modern Theme Menu  

Un menú moderno y personalizable desarrollado en Windows Forms, diseñado para ofrecer una experiencia visual atractiva y funcional. Este proyecto incluye:  
- Cambio de tema persistente con selección dinámica.  
- Botones personalizados para maximizar, minimizar y cerrar la ventana.  
- Diseño limpio e intuitivo que combina funcionalidad y estética.  

## 🚀 Características  
- **Cambio de tema:** Los usuarios pueden seleccionar entre varios temas (por ejemplo, Defecto, Morado, Verde) desde un `ComboBox`. Los cambios de tema se guardan automáticamente y persisten incluso después de cerrar la aplicación.  
- **Botones personalizados:** Los botones originales de maximizar, minimizar y cerrar se reemplazaron con controles personalizados que replican la funcionalidad estándar de Windows.  
- **Diseño responsivo:** Los colores y estilos se aplican dinámicamente a todos los controles de la interfaz para garantizar una experiencia consistente.  

## 🛠️ Tecnologías utilizadas  
- **C# (Windows Forms):** Para el desarrollo de la aplicación de escritorio.  
- **.NET Framework:** Para la ejecución de la aplicación.  

## 📷 Capturas de pantalla  
### Vista del menú principal con tema "Defecto"  
![Captura de pantalla 2025-01-04 134308](https://github.com/user-attachments/assets/e0e3424f-5702-4b5d-b215-3c2fe685e47d)

### Vista del menú principal con tema "Morado"  
![Captura de pantalla 2025-01-04 140709](https://github.com/user-attachments/assets/1b14dc33-0cac-4c72-9321-30101b9d17b5)

### Vista del menú principal con tema "Verde"  
![Captura de pantalla 2025-01-04 140722](https://github.com/user-attachments/assets/f33734c5-0f92-4fa2-a5a5-dea7be337c72)


## 📂 Estructura del proyecto  
```plaintext
ModernThemeMenu/
│
├── Properties/
│   ├── Settings.settings         # Configuración para persistencia del tema.
│   ├── Resources.resx            # Recursos de la aplicación.
│
├── ThemeColors.cs                # Clase para la gestión de colores por tema.
├── ThemeManager.cs               # Clase para manejar la persistencia y selección del tema.
├── Form1.cs                      # Formulario principal con la UI.
├── Form1.Designer.cs             # Código generado automáticamente para el diseño del formulario.
├── Program.cs                    # Punto de entrada de la aplicación.
│
└── README.md                     # Documentación del proyecto.
```

## 🔧 Cómo ejecutar  
1. Clona este repositorio:  
   ```bash
   git clone https://github.com/tuusuario/ModernThemeMenu.git
   ```  
2. Abre el archivo `.sln` en Visual Studio.  
3. Compila y ejecuta la aplicación.  

## 📋 Próximas mejoras  
- Agregar más temas personalizados.  
- Incluir animaciones al cambiar de tema.  
- Soporte para personalización avanzada de colores por parte del usuario.  

## 🤝 Contribuciones  
¡Las contribuciones son bienvenidas! Si deseas mejorar este proyecto, abre un `pull request` o crea un `issue` para discutir tus ideas.  

## 📝 Licencia  
Este proyecto está licenciado bajo la [MIT License](LICENSE).  

---

¡Gracias por explorar este proyecto! Si tienes sugerencias o preguntas, no dudes en abrir un `issue`. 🎨✨
