function PostData(url, data, callback,errorCallback)
{
    $.post(url, data, function (result, status) {
        if (status == "success") {
            callback(result);
        }
        else {
            if (errorCallback!==null && errorCallback!==undefined) {
                errorCallback(result);
            }
            else
            {
                alert(result);
            }
        }
    });
}