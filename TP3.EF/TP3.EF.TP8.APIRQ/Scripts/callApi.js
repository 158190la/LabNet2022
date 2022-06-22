
    window.addEventListener('load', obtenerDatos);

    function obtenerDatos() {

    const urlKey = '5eT2L1SsjsiRgx1oPtPN0dzZ0DXIh5yqpApQGLTZ';
    var url = `https://api.nasa.gov/planetary/apod?api_key=${urlKey}`;

    fetch(url)
                .then(respuesta => respuesta.json())
                .then(resultado => mostrarDatos(resultado))

    }

    function mostrarDatos({date, explanation, media_type, title, url}) {

    const titulo = document.querySelector('#titulo')
    titulo.innerHTML = title
    const fecha = document.querySelector('#fecha')
    fecha.innerHTML = date
    const descripcion = document.querySelector('#descripcion')
    descripcion.innerHTML = explanation

    const multimedia = document.querySelector('#c_multimedia')
        if (media_type == "image") {
            multimedia.innerHTML = `<img src="${url}" class="img-fluid" alt="${url}">`
        }
    }
    

