<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Wap.Books.Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="hcenter ft24 curved_box">
        <nav class="ranking_sort_menu c3">
            书籍筛选
            <div class="ranking_sort_menu_r"><span class="ranking_sort_menu_r_ic">︽</span> <span class="ranking_sort_menu_r_ic_up">︾</span> </div>
        </nav>
        <hr class="hr">
        <ul class="ft22 ranking_sort_text">
            <li>
                <div class="ranking_sort_text_tit fl">排列方式：</div>
                <div class="ranking_sort_text_r fl">
                    <ul>
                        <li class="first"><a class="rank_text_c" href="/t/book/category/99/?bookType=total&amp;channelId=0&amp;isChannel=">不限</a> </li>
                        <li><a href="/t/book/category/99/?bookType=total&amp;countType=word&amp;channelId=0&amp;isChannel=">字数</a> </li>
                        <li><a href="/t/book/category/99/?bookType=total&amp;countType=popularity&amp;channelId=0&amp;isChannel=">人气</a> </li>
                    </ul>
                </div>
            </li>
            <li>
                <div class="ranking_sort_text_tit fl">写作进度：</div>
                <div class="ranking_sort_text_r fl">
                    <ul>
                        <li class="first"><a class="rank_text_c" href="/t/book/category/99/?countType=&amp;channelId=0&amp;isChannel=">不限</a> </li>
                        <li><a href="/t/book/category/99/?bookType=complete&amp;countType=&amp;channelId=0&amp;isChannel=">全本</a> </li>
                        <li><a href="/t/book/category/99/?bookType=serial&amp;countType=&amp;channelId=0&amp;isChannel=">连载</a> </li>
                    </ul>
                </div>
            </li>
        </ul>
        <div class="bott_t_bor"></div>
        <div class="bott_c_bor"></div>
    </section>
    <nav class="p4">
        <section class="menu ft22">
            已选条件：<span class="rank_text_c"> 不限 + 人气 + 日榜 </span><a href="/t/rank/"></a>
        </section>
    </nav>
    <div id="novelResult">
        <div class="row-fluid">
            <div class="novelList bookInfoTouch span6" onclick="pub_jump('def','show','bid=128224&amp;type=1')" bid="128224">
                <div class="list_img">
                    <img src="http://r3.11222.cn/resource/bookclub/cover/24/82/2011121510035595.jpg">
                    <p class="list_star">
                        <img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png">
                    </p>
                </div>
                <div class="list_img_info">
                    <p>晚清崛起<span>-老沈阳</span></p>

                    <p class="gray"><strong>连载至:</strong>第970章欢迎法军</p>
                    <p class="gray"><strong>简介:</strong>主角穿越到晚清时期，和自己的弟兄</p>
                </div>
            </div>
            <div class="novelList bookInfoTouch span6" onclick="pub_jump('def','show','bid=128224&amp;type=1')" bid="128224">
                <div class="list_img">
                    <img src="http://r3.11222.cn/resource/bookclub/cover/24/82/2011121510035595.jpg">
                    <p class="list_star">
                        <img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png">
                    </p>
                </div>
                <div class="list_img_info">
                    <p>晚清崛起<span>-老沈阳</span></p>

                    <p class="gray"><strong>连载至:</strong>第970章欢迎法军</p>
                    <p class="gray"><strong>简介:</strong>主角穿越到晚清时期，和自己的弟兄</p>
                </div>
            </div>
            <div class="novelList bookInfoTouch span6" onclick="pub_jump('def','show','bid=183749&amp;type=1')" bid="183749">
                <div class="list_img">
                    <img src="http://r3.11222.cn/resource/bookclub/cover/49/37/201210229404311.jpg">
                    <p class="list_star">
                        <img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png">
                    </p>
                </div>
                <div class="list_img_info">
                    <p>醉枕江山<span>-月关</span></p>

                    <p class="gray"><strong>连载至:</strong>第三百四十三章闻变章(18:12</p>
                    <p class="gray"><strong>简介:</strong>女帝武曌日月凌空，上官婉儿称量天</p>
                </div>
            </div>
            <div class="novelList bookInfoTouch span6" onclick="pub_jump('def','show','bid=132828&amp;type=1')" bid="132828">
                <div class="list_img">
                    <img src="http://r3.11222.cn/resource/bookclub/cover/28/28/2012021013465692.jpg">
                    <p class="list_star">
                        <img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png">
                    </p>
                </div>
                <div class="list_img_info">
                    <p>雅骚<span>-贼道三痴</span></p>

                    <p class="gray"><strong>连载至:</strong>第四百六十章勇气</p>
                    <p class="gray"><strong>简介:</strong>穿越到万历四十年，既想吃喝玩乐，</p>
                </div>
            </div>
            <div class="novelList bookInfoTouch span6" onclick="pub_jump('def','show','bid=137503&amp;type=1')" bid="137503">
                <div class="list_img">
                    <img src="http://r3.11222.cn/resource/bookclub/cover/03/75/2012042411255721.jpg">
                    <p class="list_star">
                        <img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png"><img src="http://r8.11222.cn/booktouch/img/star1.png">
                    </p>
                </div>
                <div class="list_img_info">
                    <p>辛亥大英雄<span>-河马散人</span></p>

                    <p class="gray"><strong>连载至:</strong>第624章白崇禧带来的好消息</p>
                    <p class="gray"><strong>简介:</strong>那一年，小胡子登上了中央广场的演</p>
                </div>
            </div>
        </div>
        <div class="more catMoreTouch" onclick="appendMore()" tid="1" page="2" cid="7">点击加载更多</div>

    </div>
</asp:Content>
