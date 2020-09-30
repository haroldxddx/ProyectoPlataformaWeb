<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageProfesor.Master" AutoEventWireup="true" CodeBehind="foro.aspx.cs" Inherits="ProyectoPlataformaW.Vista.foro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="comment-form-container">
    <form id="frm-comment">
        <div class="input-row">
            <input type="hidden" name="comment_id" id="commentId"
                placeholder="Name" /> &nbsp;<asp:GridView ID="gdvListarCom" runat="server">
            </asp:GridView>
            <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
        </div>
        <div class="input-row">
            <textarea class="input-field" type="text" name="comment"
                id="comment" placeholder="Add a Comment">  </textarea>
        </div>
        <div>
            <input type="button" class="btn-submit" id="btnPublicar"
                value="Publicar" />
            <div id="comment-message">Tu comentario se ha publicado correctamente!</div>
        </div>

    </form>
</div>
<div id="output"></div>
<script>
        function postReply(commentId) {
                $('#commentId').val(commentId);
                $("#name").focus();
        }

        $("#submitButton").click(function() {
                $("#comment-message").css('display', 'none');
                var str = $("#frm-comment").serialize();

                $.ajax({
                        url : "comment-add.php",
                        data : str,
                        type : 'post',
                        success : function(response) {
                                var result = eval('(' + response + ')');
                                if (response) {
                                        $("#comment-message").css('display', 'inline-block');
                                        $("#name").val("");
                                        $("#comment").val("");
                                        $("#commentId").val("");
                                        listComment();
                                } else {
                                        alert("Failed to add comments !");
                                        return false;
                                }
                        }
                });
        });

        $(document).ready(function() {
                listComment();
        });

        function listComment() {
                $
                                .post(
                                                "comment-list.php",
                                                function(data) {
                                                        var data = JSON.parse(data);

                                                        var comments = "";
                                                        var replies = "";
                                                        var item = "";
                                                        var parent = -1;
                                                        var results = new Array();

                                                        var list = $("<ul class='outer-comment'>");
                                                        var item = $("<li>").html(comments);

                                                        for (var i = 0; (i < data.length); i++) {
                                                                var commentId = data[i]['comment_id'];
                                                                parent = data[i]['parent_comment_id'];

                                                                if (parent == "0") {
                                                                        comments = "<div class='comment-row'>"
                                                                                        + "<div class='comment-info'><span class='commet-row-label'>from</span> <span class='posted-by'>"
                                                                                        + data[i]['comment_sender_name']
                                                                                        + " </span> <span class='commet-row-label'>at</span> <span class='posted-at'>"
                                                                                        + data[i]['date']
                                                                                        + "</span></div>"
                                                                                        + "<div class='comment-text'>"
                                                                                        + data[i]['comment']
                                                                                        + "</div>"
                                                                                        + "<div><a class='btn-reply' onClick='postReply("
                                                                                        + commentId + ")'>Reply</a></div>"
                                                                                        + "</div>";

                                                                        var item = $("<li>").html(comments);
                                                                        list.append(item);
                                                                        var reply_list = $('<ul>');
                                                                        item.append(reply_list);
                                                                        listReplies(commentId, data, reply_list);
                                                                }
                                                        }
                                                        $("#output").html(list);
                                                });
        }

        function listReplies(commentId, data, list) {
                for (var i = 0; (i < data.length); i++) {
                        if (commentId == data[i].parent_comment_id) {
                                var comments = "<div class='comment-row'>"
                                                + " <div class='comment-info'><span class='commet-row-label'>from</span> <span class='posted-by'>"
                                                + data[i]['comment_sender_name']
                                                + " </span> <span class='commet-row-label'>at</span> <span class='posted-at'>"
                                                + data[i]['date'] + "</span></div>"
                                                + "<div class='comment-text'>" + data[i]['comment']
                                                + "</div>"
                                                + "<div><a class='btn-reply' onClick='postReply("
                                                + data[i]['comment_id'] + ")'>Reply</a></div>"
                                                + "</div>";
                                var item = $("<li>").html(comments);
                                var reply_list = $('<ul>');
                                list.append(item);
                                item.append(reply_list);
                                listReplies(data[i].comment_id, data, reply_list);
                        }
                }
        }
</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
