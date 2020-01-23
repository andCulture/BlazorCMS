window.BlazorCmsJsFunctions = {
    focus: function (selector) {
        var el = document.querySelector(selector);
        if (el != null && el.focus != null) {
            el.focus();
        }
    },
    hasClass: function (selector, className) {
        var el = document.querySelector(selector);
        if (el == null || el.classList == null) {
            return false;
        }

        return el.classList.contains(className);
    }
};