$('a.deleteRow').live('click', function () {
    $(this).parents('div.editorRow:first').remove();
    return false;
});