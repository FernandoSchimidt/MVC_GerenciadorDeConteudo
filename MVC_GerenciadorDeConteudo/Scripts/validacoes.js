var ValidaExclusao = function (id, evento) {

    if (confirm("Excluir?")) {
        return true;
    } else {
        evento.preventDefault();
        return false;
    }

}