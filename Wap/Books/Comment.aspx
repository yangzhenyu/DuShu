<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Comment.aspx.cs" Inherits="Wap.Books.Comment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--发布框-->
    <div class="articleComment">
        <h5>请您<a href='http://3g.sina.com.cn/prog/wapsite/sso/login.php?ns=1&amp;revalid=0&amp;backURL=http%3A%2F%2Fbook.proc.sina.cn%2Fcmnt%2Flist.php%3Fproduct%3Dbook%26index%3D1_5_222236_222236%7C0%7C1&amp;backTitle=%CA%D6%BB%FA%D0%C2%C0%CB%CD%F8&amp;vt=4&amp;wm=4002&amp;PHPSESSID=658bc9f5bb115fb698e959469b8e7be4'>登录</a>/<a href='http://3g.sina.com.cn/prog/wapsite/sso/register.php?ns=1&amp;revalid=0&amp;backURL=http%3A%2F%2Fbook.proc.sina.cn%2Fcmnt%2Flist.php%3Fproduct%3Dbook%26index%3D1_5_222236_222236%7C0%7C1&amp;backTitle=%CA%D6%BB%FA%D0%C2%C0%CB%CD%F8&amp;vt=4&amp;wm=4002&amp;PHPSESSID=658bc9f5bb115fb698e959469b8e7be4'>注册</a>后再评论<span>0条</span></h5>

        <form action="http://book.proc.sina.cn/cmnt/post.php?product=book&amp;vt=4&amp;wm=4002&amp;PHPSESSID=658bc9f5bb115fb698e959469b8e7be4" method="post" onsubmit="return formCheck(this)">
            <div class="moarea">
                <textarea name="cmntContent" class="newarea" cols="" rows="" id="cmnt_text_area">请输入评论</textarea>

                <input type="hidden" name="product" value="book" />
                <input type="hidden" name="index" value="1_5_222236_222236|0|1" />
                <input type="hidden" name="vcode" value="sinacnvode" />

            </div>
            <div class="articleComment_fb">

                <span class="fr">
                    <input type="submit" class="btn btn-info" value="发言"></span>
            </div>
        </form>
    </div>
    <!--评论主体-->
    <div id="artcileMain">
        <div class="commentnav">
            <a href='list.php?product=book&amp;index=1_5_222236_222236|0|1&amp;vt=4&amp;wm=4002&amp;PHPSESSID=658bc9f5bb115fb698e959469b8e7be4' class='secondnav on'>最新评论</a><span>|</span><a href='list.php?product=book&amp;index=1_5_222236_222236|0|1&amp;list=hot&amp;vt=4&amp;wm=4002&amp;PHPSESSID=658bc9f5bb115fb698e959469b8e7be4' class='secondnav'>最热评论</a>
        </div>
        <div class="commentCont">

            <div class="list_empty">暂时没有评论，快来留下您的看法吧!</div>
            <div id="more" style="display: none"></div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <article class="fl second"><a href="/t/book/category/130/" class="c_white fl ml_30"><span class="va">玉楼笙歌</span></a> </article>
    <article class="fl third"><a class="c_white fl ml_30"><span class="va">评论内容</span></a> </article>

</asp:Content>

