
//Объявление состояний стрелок и изображений папок в меню аккордеон
const arrowOpen = document.querySelectorAll('.arrow-open');
const arrowClose = document.querySelectorAll('.arrow-close');

const folderClosed = document.querySelectorAll('.img-folder__closed');
const folderOpened = document.querySelectorAll('.img-folder__opened');

//Объявление изображения и названия папок
const accordionFolder = document.querySelectorAll('.accordion-folder');

//Прослушивание всех стрелок открытия с последующим изменением картинок 
arrowOpen.forEach((item, index) => {
    item.addEventListener('click', () => {
        if (folderClosed[index].classList.contains('hidden')) {
            arrowClose[index].classList.remove('hidden');
            item.classList.add('hidden');
            folderClosed[index].classList.remove('hidden');
            folderOpened[index].classList.add('hidden');
        }
    });
});

//Прослушивание всех стрелок закрытия с последующим изменением картинок 
arrowClose.forEach((item, index) => {
    item.addEventListener('click', () => {
        if (folderOpened[index].classList.contains('hidden')) {
            item.classList.add('hidden');
            arrowOpen[index].classList.remove('hidden');
            folderClosed[index].classList.add('hidden');
            folderOpened[index].classList.remove('hidden');
        }
    });
});

//Изменение картинок стрелок и папок после двойного клика на название папки
accordionFolder.forEach((item, index) => {
    item.addEventListener('dblclick', () => {
        if (folderClosed[index].classList.contains('hidden')) {
            arrowOpen[index].classList.add('hidden');
            arrowClose[index].classList.remove('hidden');
            folderClosed[index].classList.remove('hidden');
            folderOpened[index].classList.add('hidden');
        }
        else {
            arrowClose[index].classList.add('hidden');
            arrowOpen[index].classList.remove('hidden');
            folderClosed[index].classList.add('hidden');
            folderOpened[index].classList.remove('hidden');
        }
    });
});

//Объявление состояний названия файлов
const file = document.querySelectorAll('.file-name');

//Прослушивание всех файлов с последующим изменением на активное 
file.forEach(fileElem => {
    fileElem.addEventListener('click', () => {
        if (fileElem.classList.contains('active')) {
            fileElem.classList.remove('active');
        }
        else {
            file.forEach(item => {
                item.classList.remove('active');
            });
            fileElem.classList.add('active');
        }
    });
});
