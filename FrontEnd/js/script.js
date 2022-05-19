$(function () {
    var userID = -1;
    function loadForm() {
        $("#todo_list").hide();
        loadAllTodoItem();
        addTodoItem();
    }
    function loadAllTodoItem() {
        $("#get_started").click(function () {

            currEmail = $("#email").val().toLowerCase();
            var url = 'https://localhost:5001/v1/User'
            $.ajax({
                url: url,
                type: 'POST',
                contentType: 'application/json',
                dataType: 'json',
                data: JSON.stringify(currEmail),
                success: function (response, status, xhr) {
                    if (response.responseCode == 200) {
                        $("#login").hide();
                        $("#todo_list").show();
                        var listTodo = response.data.TodoItem;
                        userID = response.data.UserID[0];
                        var htmlText = '';
                        for (var e of listTodo) {
                            var deadline = new Date(e.deadlineTime);

                            htmlText += `<div class="todo-item">
                                            <div class="titleText">${emptyIfNull(e.title)}</div>
                                            <div class="d-flex">
                                                <div class="descriptionText">${emptyIfNull(e.description)}</div>
                                            </div>
                                            <div class="deadline d-flex">
                                                <span>Thời gian đến hạn:</span>
                                                <div class="d-flex">
                                                <div class="deadlineHour">${emptyIfNull(deadline.getHours())}:${emptyIfNull(deadline.getMinutes())}</div>
                                                    <div class="deadlineText">${emptyIfNull(deadline.getDate())}-${emptyIfNull(deadline.getMonth()) + 1}-${emptyIfNull(deadline.getFullYear())} </div>
                                                </div>
                                            </div>
                                        </div>`;
                        }
                        $('#listTodo').html(htmlText);

                    }
                },
            })
        })

    }
    function loadData(userID) {
        var url = 'https://localhost:5001/v1/TodoItem/' + userID;
        $.ajax({
            url: url,
            type: 'GET',
            contentType: 'application/json',
            success: function (response, status, xhr) {
                if (response.responseCode == 200) {
                    $("#login").hide();
                    $("#todo_list").show();
                    var listTodo = response.data;
                    var htmlText = '';
                    for (var e of listTodo) {
                        var deadline = new Date(e.deadlineTime);

                        htmlText += `<div class="todo-item">
                                            <div class="titleText">${emptyIfNull(e.title)}</div>
                                            <div class="d-flex">
                                                <div class="descriptionText">${emptyIfNull(e.description)}</div>
                                            </div>
                                            <div class="deadline d-flex">
                                                <span>Thời gian đến hạn:</span>
                                                <div class="d-flex">
                                                <div class="deadlineHour">${emptyIfNull(deadline.getHours())}:${emptyIfNull(deadline.getMinutes())}</div>
                                                    <div class="deadlineText">${emptyIfNull(deadline.getDate())}-${emptyIfNull(deadline.getMonth()) + 1}-${emptyIfNull(deadline.getFullYear())} </div>
                                                </div>
                                            </div>
                                        </div>`;
                    }
                    $('#listTodo').html(htmlText);

                }
            },
        })
    }
    function addTodoItem() {
        $("#createBtn").click(function () {
            var title = $('#title').val(),
                description = $('#description').val(),
                remindDate = $('#remindDate').val(),
                remindTime = $('#remindTime').val(),
                deadlineTime = new Date(remindDate + ' ' + remindTime),
                hour = deadlineTime.getHours() + 7,
                deadlineTime = deadlineTime.setHours(hour),
                deadlineTime = new Date(deadlineTime).toJSON(),
                url = 'https://localhost:5001/v1/TodoItem';
            var data = {
                title: title,
                userID: userID,
                deadlineTime: deadlineTime,
                description: description,
            };

            $.ajax({
                url: url,
                type: 'POST',
                contentType: 'application/json',
                dataType: 'json',
                data: JSON.stringify(data),
                success: function (response, status, xhr) {
                    if (response.responseCode == 200) {
                        alert('Thêm thành công');
                        loadData(userID);
                    }
                },
            });
        });

    }
    function emptyIfNull(value) {
        if (value == null) {
            return '';
        }
        return value;
    }
    loadForm();

});