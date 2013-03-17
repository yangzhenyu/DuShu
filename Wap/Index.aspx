<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Index.Master" CodeBehind="Index.aspx.cs" Inherits="Wap.Index" %>





<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="myCarousel" class="carousel slide">
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="item active">
                <img src="http://www.bootcss.com/assets/img/bootstrap-mdo-sfmoma-01.jpg" alt="">
                <div class="carousel-caption">
                    <h4>First Thumbnail label</h4>
                </div>
            </div>
            <div class="item">
                <img src="http://www.bootcss.com/assets/img/bootstrap-mdo-sfmoma-02.jpg" alt="">
                <div class="carousel-caption">
                    <h4>Second Thumbnail label</h4>
                </div>
            </div>
            <div class="item">
                <img src="http://www.bootcss.com/assets/img/bootstrap-mdo-sfmoma-03.jpg" alt="">
                <div class="carousel-caption">
                    <h4>Third Thumbnail label</h4>
                </div>
            </div>
        </div>
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">&lsaquo;</a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">&rsaquo;</a>
    </div>
    <div id="searchform" style="padding: 5px 0;">

        <div style="">
            <form class="form-search">
                <div class="ui-input-search ui-icon-searchfield" style="width: 100%; margin: 0 auto;">
                    <input class="ui-input-text" style="width: 80%; padding: 11px 19px; font-size: 17.5px;" id="appendedInputButtons" placeholder="搜索书本或者作者名字" type="text">
                    <%--  <button class="btn btn-large"  type="submit">搜索</button>--%>
                </div>
            </form>
        </div>
        <div>
            <a href="#" class="rc1 ft20 ml_20">重生</a>
            <a href="#" class="rc2 ft20 ml_20">美女</a>
            <a href="#" class="rc3 ft20 ml_20">重生</a>
            <a href="#" class="rc4 ft20 ml_20">美女</a>
            <a href="#" class="rc5 ft20 ml_20">重生</a>
        </div>


    </div>
    <div class="row-fluid">

        <div class="blockContainer span6 clearfix">
            <nav class="p4">
                <article class="menu ft24">
                    <article class="fl title c_gray">强力推荐</article>
                    <article class="fr mark">
                        <a href="javascript:;" class="c_gray current">本期</a> <a href="javascript:;" class="c_gray ml_25">往期</a>
                        <article class="mark_line line"></article>
                    </article>
                </article>
            </nav>
            <div class="touchblock ani">
                <section class="p8 ft24 c3">
                    <ul class="li_b">
                        <li class="bor_t_n"><a href="/t/book/category/111/" class="c_gray2   type">[科幻]</a><a href="/t/book/366308/" class="c3  title">异能少年王:末日审判者</a> </li>
                        <li class=""><a href="/t/book/category/106/" class="c_gray2  type">[穿越]</a><a href="/t/book/366303/" class="c3  title">捡个皇帝老公:淑女攻略</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2   type">[玄幻]</a><a href="/t/book/366591/" class="c3  title">杀神祖先附体:至尊狂圣</a> </li>
                        <li class=""><a href="/t/book/category/131/" class="c_gray2   type">[总裁]</a><a href="/t/book/366298/" class="c3  title">误惹大少爷:娇妻太凶猛</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2   type">[玄幻]</a><a href="/t/book/367210/" class="c3  title">炼丹宗师重生:异界魔君</a> </li>
                        <li class="bor_b_n"><a href="/t/book/category/81/" class="c_gray2   type">[情感]</a><a href="/t/book/353505/" class="c3  title">都市绝恋:再见，我的爱人</a> </li>
                    </ul>
                </section>
                <section class="p8 ft24 c3">
                    <ul class="li_b">
                        <li class="bor_t_n"><a href="/t/book/category/103/" class="c_gray2  type">[都市]</a><a href="/t/book/366299/" class="c3  title">超级异能:我的美女校花</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366292/" class="c3  title">罗森神作降临:白银之歌</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366302/" class="c3  title">热血狂战异界:纯阳武圣</a> </li>
                        <li class=""><a href="/t/book/category/133/" class="c_gray2  type">[幻想]</a><a href="/t/book/366304/" class="c3  title">驯夫记:不负梵心不负妖</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366309/" class="c3  title">逆天修罗魔神:通天修士</a> </li>
                        <li class="bor_b_n"><a href="/t/book/category/131/" class="c_gray2  type">[总裁]</a><a href="/t/book/366300/" class="c3  title">豪门情:谁动了我的前夫</a> </li>
                    </ul>
                </section>
                <div style="clear: both;"></div>
            </div>
        </div>
        <div class="blockContainer span6 clearfix">
            <nav class="p4">
                <article class="menu ft24">
                    <article class="fl title c_gray">点击榜 </article>
                    <article class="fr mark">
                        <a href="javascript:;" class="c_gray current">周榜</a>
                        <a href="javascript:;" class="ml_25 c_gray ">月榜</a>
                        <a href="javascript:;" class="c_gray ml_25">总榜</a>
                        <article class="mark_line line2"></article>
                    </article>
                </article>
            </nav>

            <div class="touchblock ani">
                <section class="p8 ft24">
                    <ul class="li_b">
                        <li class="li_t"><a href="/t/book/351253/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">透视之眼<span class="title_b">(星辉)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/351193/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349006/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">护花高手在都市<span class="title_b">(心在流浪)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/365656/"><span class="num num_c ft18 fl">4</span><span class="fl title">护花狂龙<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class="li_b"><a href="/t/book/351589/"><span class="num num_c ft18 fl">5</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                        </a></li>
                    </ul>
                    <article class="more">
                        <a href="/t/rank/all/sale/month/">
                            <button class="more_btn ft24 c3">更多 </button>
                        </a>
                    </article>
                </section>
                <section class="p8 ft24">
                    <ul class="li_b">
                        <li class="li_t"><a href="/t/book/351253/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">透视之眼<span class="title_b">(星辉)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/351193/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349006/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">护花高手在都市<span class="title_b">(心在流浪)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/365656/"><span class="num num_c ft18 fl">4</span><span class="fl title">护花狂龙<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class="li_b"><a href="/t/book/351589/"><span class="num num_c ft18 fl">5</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                        </a></li>
                    </ul>
                    <article class="more">
                        <a href="/t/rank/all/sale/month/">
                            <button class="more_btn ft24 c3">更多 </button>
                        </a>
                    </article>
                </section>
                <section class="p8 ft24">
                    <ul class="li_b">
                        <li class="li_t"><a href="/t/book/351193/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349006/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">护花高手在都市<span class="title_b">(心在流浪)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/351253/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">透视之眼<span class="title_b">(星辉)</span></span><article class="clear"></article>
                        </a></li>
                        <li class=""><a href="/t/book/349017/"><span class="num num_c ft18 fl">4</span><span class="fl title">药鼎仙途<span class="title_b">(寒香寂寞)</span></span><article class="clear"></article>
                        </a></li>
                        <li class="li_b"><a href="/t/book/351510/"><span class="num num_c ft18 fl">5</span><span class="fl title">特种兵痞在校园<span class="title_b">(艾连)</span></span><article class="clear"></article>
                        </a></li>
                    </ul>
                    <article class="more">
                        <a href="/t/rank/all/sale/total/">
                            <button class="more_btn ft24 c3">更多 </button>
                        </a>
                    </article>
                </section>
            </div>
        </div>

    </div>
    <div class="row-fluid">

        <div class="blockContainer span6 clearfix">
            <nav class="p4">
                <article class="menu ft24">
                    <article class="fl title c_gray">男频</article>
                    <article class="fr mark">
                        <a href="javascript:;" class="c_gray current">本期</a> <a href="javascript:;" class="c_gray ml_25">往期</a>
                        <article class="mark_line line"></article>
                    </article>
                </article>
            </nav>
            <div class="touchblock ani">
                <section class="p8 ft24 c3">
                    <ul class="li_b">
                        <li class="bor_t_n"><a href="/t/book/category/111/" class="c_gray2   type">[科幻]</a><a href="/t/book/366308/" class="c3  title">异能少年王:末日审判者</a> </li>
                        <li class=""><a href="/t/book/category/106/" class="c_gray2  type">[穿越]</a><a href="/t/book/366303/" class="c3  title">捡个皇帝老公:淑女攻略</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2   type">[玄幻]</a><a href="/t/book/366591/" class="c3  title">杀神祖先附体:至尊狂圣</a> </li>
                        <li class=""><a href="/t/book/category/131/" class="c_gray2   type">[总裁]</a><a href="/t/book/366298/" class="c3  title">误惹大少爷:娇妻太凶猛</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2   type">[玄幻]</a><a href="/t/book/367210/" class="c3  title">炼丹宗师重生:异界魔君</a> </li>
                        <li class="bor_b_n"><a href="/t/book/category/81/" class="c_gray2   type">[情感]</a><a href="/t/book/353505/" class="c3  title">都市绝恋:再见，我的爱人</a> </li>
                    </ul>
                </section>
                <section class="p8 ft24 c3">
                    <ul class="li_b">
                        <li class="bor_t_n"><a href="/t/book/category/103/" class="c_gray2  type">[都市]</a><a href="/t/book/366299/" class="c3  title">超级异能:我的美女校花</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366292/" class="c3  title">罗森神作降临:白银之歌</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366302/" class="c3  title">热血狂战异界:纯阳武圣</a> </li>
                        <li class=""><a href="/t/book/category/133/" class="c_gray2  type">[幻想]</a><a href="/t/book/366304/" class="c3  title">驯夫记:不负梵心不负妖</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366309/" class="c3  title">逆天修罗魔神:通天修士</a> </li>
                        <li class="bor_b_n"><a href="/t/book/category/131/" class="c_gray2  type">[总裁]</a><a href="/t/book/366300/" class="c3  title">豪门情:谁动了我的前夫</a> </li>
                    </ul>
                </section>
                <div style="clear: both;"></div>
            </div>
        </div>

        <div class="blockContainer span6 clearfix">
            <nav class="p4">
                <article class="menu ft24">
                    <article class="fl title c_gray">女频</article>
                    <article class="fr mark">
                        <a href="javascript:;" class="c_gray current">本期</a> <a href="javascript:;" class="c_gray ml_25">往期</a>
                        <article class="mark_line line"></article>
                    </article>
                </article>
            </nav>
            <div class="touchblock ani">
                <section class="p8 ft24 c3">
                    <ul class="li_b">
                        <li class="bor_t_n"><a href="/t/book/category/111/" class="c_gray2   type">[科幻]</a><a href="/t/book/366308/" class="c3  title">异能少年王:末日审判者</a> </li>
                        <li class=""><a href="/t/book/category/106/" class="c_gray2  type">[穿越]</a><a href="/t/book/366303/" class="c3  title">捡个皇帝老公:淑女攻略</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2   type">[玄幻]</a><a href="/t/book/366591/" class="c3  title">杀神祖先附体:至尊狂圣</a> </li>
                        <li class=""><a href="/t/book/category/131/" class="c_gray2   type">[总裁]</a><a href="/t/book/366298/" class="c3  title">误惹大少爷:娇妻太凶猛</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2   type">[玄幻]</a><a href="/t/book/367210/" class="c3  title">炼丹宗师重生:异界魔君</a> </li>
                        <li class="bor_b_n"><a href="/t/book/category/81/" class="c_gray2   type">[情感]</a><a href="/t/book/353505/" class="c3  title">都市绝恋:再见，我的爱人</a> </li>
                    </ul>
                </section>
                <section class="p8 ft24 c3">
                    <ul class="li_b">
                        <li class="bor_t_n"><a href="/t/book/category/103/" class="c_gray2  type">[都市]</a><a href="/t/book/366299/" class="c3  title">超级异能:我的美女校花</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366292/" class="c3  title">罗森神作降临:白银之歌</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366302/" class="c3  title">热血狂战异界:纯阳武圣</a> </li>
                        <li class=""><a href="/t/book/category/133/" class="c_gray2  type">[幻想]</a><a href="/t/book/366304/" class="c3  title">驯夫记:不负梵心不负妖</a> </li>
                        <li class=""><a href="/t/book/category/99/" class="c_gray2  type">[玄幻]</a><a href="/t/book/366309/" class="c3  title">逆天修罗魔神:通天修士</a> </li>
                        <li class="bor_b_n"><a href="/t/book/category/131/" class="c_gray2  type">[总裁]</a><a href="/t/book/366300/" class="c3  title">豪门情:谁动了我的前夫</a> </li>
                    </ul>
                </section>
                <div style="clear: both;"></div>
            </div>
        </div>
    </div>
    <div class="row-fluid">
        <div class="blockContainer span6 clearfix">
            <nav class="p4">
                <article class="menu ft24">
                    <article class="fl title c_gray">热门标签 </article>
                </article>
            </nav>
            <section class="p7 p7_20">
                <a href="/t/book/search/?query=%E7%A9%BF%E8%B6%8A" class="k1">穿越</a>
                <a href="/t/book/search/?query=%E9%87%8D%E7%94%9F" class="k2">重生</a>
                <a href="/t/book/search/?query=%E6%80%BB%E8%A3%81" class="k3">总裁</a>
                <a href="/t/book/search/?query=%E7%BE%8E%E5%A5%B3" class="k4">美女</a>
                <a href="/t/book/search/?query=%E6%90%9E%E7%AC%91" class="k5">搞笑</a>
                <a href="/t/book/search/?query=%E4%BF%AE%E7%9C%9F" class="k6">修真</a>
                <a href="/t/book/search/?query=%E6%9E%81%E5%93%81" class="k7">极品</a>
                <a href="/t/book/search/?query=%E7%83%AD%E8%A1%80" class="k8">热血</a>
                <a href="/t/book/search/?query=%E8%99%90%E5%BF%83" class="k9">虐心</a>
                <a href="/t/book/search/?query=%E5%A5%87%E5%B9%BB" class="k10">奇幻</a>
                <a href="/t/book/search/?query=%E5%86%9B%E4%BA%8B" class="k11">军事</a>
                <a href="/t/book/search/?query=%E8%B1%AA%E9%97%A8" class="k12">豪门</a>
                <a href="/t/book/search/?query=%E6%9E%81%E5%93%81" class="k13">极品</a>
                <a href="/t/book/search/?query=%E6%9A%A7%E6%98%A7" class="k15">暧昧</a>
                <a href="/t/book/search/?query=%E5%8D%87%E7%BA%A7" class="k16">升级</a>

            </section>
        </div>



        <div class="blockContainer span6 clearfix">
            <nav class="p4">
                <article class="menu ft24">
                    <article class="fl title c_gray">分类导航 </article>
                </article>
            </nav>

            <ul class="catContent ft22">
                <li><a href="javascript:void(0)">全部分类</a></li>
                <li><a href="javascript:void(0)">玄幻小说</a></li>
                <li><a href="javascript:void(0)">架空历史</a></li>
                <li><a href="javascript:void(0)">仙侠修真</a></li>
                <li><a href="javascript:void(0)">异世大陆</a></li>
                <li><a href="javascript:void(0)">转世重生</a></li>
                <li><a href="javascript:void(0)">言情小说</a></li>
                <li><a href="javascript:void(0)">穿越小说</a></li>
                <li><a href="javascript:void(0)">现代言情</a></li>
                <li><a href="javascript:void(0)">都市小说</a></li>
                <li><a href="javascript:void(0)">官场小说</a></li>
                <li><a href="javascript:void(0)">黑道小说</a></li>
            </ul>
            <div class="clearfix"></div>
        </div>
    </div>

    <div class="b_return"><a class="ft24 ret_btn" href="#body"><span class="b_return_i">︽</span>回顶部 </a></div>
</asp:Content>
