<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Wap.Index" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <meta charset="utf-8" />
    <title>塔读触屏版</title>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="head"></div>
    <script type="text/javascript">	var pageType = 1; var focusStyle = "";</script>
    <section id="continue" class="ft22 hidden">
        <article class="t_tit">
            <article class="fl">
                <img src="/images/touch/v1/ind_banner_icon.png" width="11" height="20" class="t_tit_name">继续看：
            </article>
            <article class="fl book_name"><a id="continueA" href=""></a></article>
            <div class="banner_t_b"></div>
        </article>
    </section>
    <section id="continueNull" class="index_null"></section>
    <section id="home_banner" class="banner_c">
        <div id="banner_c">
            <div id="banner_list" class="banner_list">
                <ul>
                    <li><a href="http://t.tadu.com/t/book/364920/">
                        <img src="http://media.tadu.com/f/5/e/8/f5e81d60df3448fba31c1da3a21e3bc4.tmp"></a><span style="color: #000000">我老婆是校花</span></li>
                    <li><a href="http://t.tadu.com/t/book/366310/">
                        <img src="http://media.tadu.com/4/0/3/b/403b77bd826e4a07be4f7e1e879d2937.tmp"></a><span style="color: #FFFFFF">侯门闲妻</span></li>
                    <li><a href="http://t.tadu.com/t/book/352119/">
                        <img src="http://media.tadu.com/8/c/d/2/8cd2040d31f347c887063d83a5b373eb.tmp"></a><span style="color: #000000">大圈</span></li>
                </ul>
            </div>
        </div>
        <img src="/images/touch/v1/ban_l_btn.png" width="51" height="90" class="banner_btn_l">
        <img src="/images/touch/v1/ban_r_btn.png" width="51" height="90" class="banner_btn_r">
        <div class="banner_bo_b"></div>
        <div id="ban_ic" class="ban_ic"><span class="ban_acti"></span><span class="ban_acti"></span><span class="ban_acti"></span></div>
    </section>
    <section class="p15 ind_sear">
        <form class="search_form ind_pad_t20" method="get" action="/t/book/search/">
            <input type="text" name="query" class="search ft24" placeholder="异界之九阳真经">
            <button type="submit" class="search_btn fr ft24">搜索 </button>
        </form>
        <article class="hot_label ft22"><a href="/t/book/search/?query=%E9%87%8D%E7%94%9F" class="rc1 ml_25">重生</a><a href="/t/book/search/?query=%E7%83%AD%E8%A1%80" class="rc2 ml_25">热血</a><a href="/t/book/search/?query=%E7%A9%BF%E8%B6%8A" class="rc3 ml_25">穿越</a><a href="/t/book/search/?query=%E7%BE%8E%E5%A5%B3" class="rc4 ml_25">美女</a></article>
    </section>
    <div class="blockContainer">
        <nav class="p2">
            <article class="menu ft24">
                <article class="fl title c_gray">强力推荐</article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_gray current">本期</a> <a href="javascript:;" class="c_gray ml_25">往期</a>
                    <article class="mark_line line"></article>
                </article>
            </article>
        </nav>
        <div class="touchblock ani">
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/111/" class="c_gray2 fl type">[科幻]</a><a href="/t/book/366308/" class="c3 fl title">异能少年王:末日审判者</a> </li>
                    <li class=""><a href="/t/book/category/106/" class="c_gray2 fl type">[穿越]</a><a href="/t/book/366303/" class="c3 fl title">捡个皇帝老公:淑女攻略</a> </li>
                    <li class=""><a href="/t/book/category/99/" class="c_gray2 fl type">[玄幻]</a><a href="/t/book/366591/" class="c3 fl title">杀神祖先附体:至尊狂圣</a> </li>
                    <li class=""><a href="/t/book/category/131/" class="c_gray2 fl type">[总裁]</a><a href="/t/book/366298/" class="c3 fl title">误惹大少爷:娇妻太凶猛</a> </li>
                    <li class=""><a href="/t/book/category/99/" class="c_gray2 fl type">[玄幻]</a><a href="/t/book/367210/" class="c3 fl title">炼丹宗师重生:异界魔君</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/81/" class="c_gray2 fl type">[情感]</a><a href="/t/book/353505/" class="c3 fl title">都市绝恋:再见，我的爱人</a> </li>
                </ul>
            </section>
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/103/" class="c_gray2 fl type">[都市]</a><a href="/t/book/366299/" class="c3 fl title">超级异能:我的美女校花</a> </li>
                    <li class=""><a href="/t/book/category/99/" class="c_gray2 fl type">[玄幻]</a><a href="/t/book/366292/" class="c3 fl title">罗森神作降临:白银之歌</a> </li>
                    <li class=""><a href="/t/book/category/99/" class="c_gray2 fl type">[玄幻]</a><a href="/t/book/366302/" class="c3 fl title">热血狂战异界:纯阳武圣</a> </li>
                    <li class=""><a href="/t/book/category/133/" class="c_gray2 fl type">[幻想]</a><a href="/t/book/366304/" class="c3 fl title">驯夫记:不负梵心不负妖</a> </li>
                    <li class=""><a href="/t/book/category/99/" class="c_gray2 fl type">[玄幻]</a><a href="/t/book/366309/" class="c3 fl title">逆天修罗魔神:通天修士</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/131/" class="c_gray2 fl type">[总裁]</a><a href="/t/book/366300/" class="c3 fl title">豪门情:谁动了我的前夫</a> </li>
                </ul>
            </section>
            <div style="clear: both;"></div>
        </div>
    </div>
    <div class="blockContainer">
        <nav class="p3">
            <article class="menu ft24">
                <article class="fl title c_blue">网文男频</article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_blue2 current">推荐</a> <a href="javascript:;" class="ml_25 c_blue2 ">全本</a> <a href="javascript:;" class="c_blue2 ml_25">畅销</a>
                    <article class="mark_line line"></article>
                </article>
            </article>
        </nav>
        <div class="touchblock ani">
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/99/" class="c_blue7 fl type">[玄幻]</a><a href="/t/book/366292/" class="c3 fl title">罗森神作降临:白银之歌</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/366307/" class="c3 fl title">为美女而奋斗:天生煞星</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/367226/" class="c3 fl title">护花:美女的贴身兵王</a> </li>
                    <li class=""><a href="/t/book/category/99/" class="c_blue7 fl type">[玄幻]</a><a href="/t/book/351589/" class="c3 fl title">独掌异界权色:兽破苍穹</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/112/" class="c_blue7 fl type">[游戏]</a><a href="/t/book/367002/" class="c3 fl title">逐美记:网游之枭傲天下</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/man/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/351193/" class="c3 fl title">妖孽保镖</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/351510/" class="c3 fl title">特种兵痞在校园</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/349006/" class="c3 fl title">护花高手在都市</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/350582/" class="c3 fl title">花心医生</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/360769/" class="c3 fl title">超级黄金手</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/book/category/98/?bookType=complete&countType=popularity&channelId=1&isChannel=1">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/351253/" class="c3 fl title">透视之眼</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/351193/" class="c3 fl title">妖孽保镖</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/349006/" class="c3 fl title">护花高手在都市</a> </li>
                    <li class=""><a href="/t/book/category/103/" class="c_blue7 fl type">[都市]</a><a href="/t/book/365656/" class="c3 fl title">护花狂龙</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/99/" class="c_blue7 fl type">[玄幻]</a><a href="/t/book/351589/" class="c3 fl title">兽破苍穹</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/rank/male/sale/day/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
        </div>
    </div>
    <div class="blockContainer">
        <nav class="p3_red mt_25">
            <article class="menu ft24">
                <article class="fl title c_red">网文女频 </article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_red current">推荐</a> <a href="javascript:;" class="ml_25 c_red ">全本</a> <a href="javascript:;" class="c_red ml_25">畅销</a>
                    <article class="mark_line line"></article>
                </article>
            </article>
        </nav>
        <div class="touchblock ani">
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/131/" class="c_red fl type">[总裁]</a><a href="/t/book/367225/" class="c3 fl title">情缠:这个总裁有点坏</a> </li>
                    <li class=""><a href="/t/book/category/106/" class="c_red fl type">[穿越]</a><a href="/t/book/366432/" class="c3 fl title">虐恋倾世皇妃:负君心</a> </li>
                    <li class=""><a href="/t/book/category/131/" class="c_red fl type">[总裁]</a><a href="/t/book/366306/" class="c3 fl title">霸道情人:迷情女总裁</a> </li>
                    <li class=""><a href="/t/book/category/106/" class="c_red fl type">[穿越]</a><a href="/t/book/366574/" class="c3 fl title">爱上父王:妖王宠邪妃</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/132/" class="c_red fl type">[婚恋]</a><a href="/t/book/367638/" class="c3 fl title">与总裁有染:假爱真做</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/woman/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/106/" class="c_red fl type">[穿越]</a><a href="/t/book/354129/" class="c3 fl title">醉红妆</a> </li>
                    <li class=""><a href="/t/book/category/106/" class="c_red fl type">[穿越]</a><a href="/t/book/362571/" class="c3 fl title">特工下堂妃</a> </li>
                    <li class=""><a href="/t/book/category/106/" class="c_red fl type">[穿越]</a><a href="/t/book/360426/" class="c3 fl title">代嫁丫鬟懒洋洋</a> </li>
                    <li class=""><a href="/t/book/category/106/" class="c_red fl type">[穿越]</a><a href="/t/book/362922/" class="c3 fl title">废妾大小姐</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/104/" class="c_red fl type">[言情]</a><a href="/t/book/362708/" class="c3 fl title">前夫如狼</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/book/category/98/?bookType=complete&countType=popularity&channelId=2&isChannel=1">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/129/" class="c_red fl type">[古言]</a><a href="/t/book/364562/" class="c3 fl title">奴家不是祸水</a> </li>
                    <li class=""><a href="/t/book/category/131/" class="c_red fl type">[总裁]</a><a href="/t/book/366298/" class="c3 fl title">娇妻太凶猛</a> </li>
                    <li class=""><a href="/t/book/category/131/" class="c_red fl type">[总裁]</a><a href="/t/book/359289/" class="c3 fl title">家有萌妻</a> </li>
                    <li class=""><a href="/t/book/category/131/" class="c_red fl type">[总裁]</a><a href="/t/book/365651/" class="c3 fl title">恶魔总裁的天使新娘</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/104/" class="c_red fl type">[言情]</a><a href="/t/book/366576/" class="c3 fl title">先婚厚爱</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/rank/female/sale/day/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
        </div>
    </div>
    <div class="blockContainer">
        <nav class="p4 mt_25">
            <article class="menu ft24">
                <article class="fl title c_gray">文学频道 </article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_gray current">推荐</a> <a href="javascript:;" class="c_gray ml_25">畅销</a>
                    <article class="mark_line line"></article>
                </article>
            </article>
        </nav>
        <div class="touchblock ani">
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/86/" class="c_gray fl type">[军事]</a><a href="/t/book/366610/" class="c3 fl title">海军版士兵突击:火蓝刀锋</a> </li>
                    <li class=""><a href="/t/book/category/81/" class="c_gray fl type">[情感]</a><a href="/t/book/354297/" class="c3 fl title">伪爱:婚姻很远，暧昧很近</a> </li>
                    <li class=""><a href="/t/book/category/86/" class="c_gray fl type">[军事]</a><a href="/t/book/360705/" class="c3 fl title">尖刀出击:独狼特遣队</a> </li>
                    <li class=""><a href="/t/book/category/115/" class="c_gray fl type">[官场]</a><a href="/t/book/351552/" class="c3 fl title">新官铁腕推廉:领导班子</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/81/" class="c_gray fl type">[情感]</a><a href="/t/book/351851/" class="c3 fl title">最争议婚恋小说:婚姻男女</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/literature/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p5 ft24 c3">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/category/102/" class="c_gray fl type">[社会]</a><a href="/t/book/352119/" class="c3 fl title">大圈</a> </li>
                    <li class=""><a href="/t/book/category/81/" class="c_gray fl type">[情感]</a><a href="/t/book/353944/" class="c3 fl title">嫁入豪门</a> </li>
                    <li class=""><a href="/t/book/category/115/" class="c_gray fl type">[官场]</a><a href="/t/book/351552/" class="c3 fl title">领导班子</a> </li>
                    <li class=""><a href="/t/book/category/81/" class="c_gray fl type">[情感]</a><a href="/t/book/350067/" class="c3 fl title">婚房</a> </li>
                    <li class="bor_b_n"><a href="/t/book/category/115/" class="c_gray fl type">[官场]</a><a href="/t/book/360181/" class="c3 fl title">副省长女秘书</a> </li>
                </ul>
                <article class="more">
                    <a href="/t/rank/literature/sale/day/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
        </div>
    </div>
    <nav class="p4 mt_25">
        <article class="menu ft24">
            <article class="fl title c_gray">热门标签 </article>
        </article>
    </nav>
    <section class="p7 p7_20"><a href="/t/book/search/?query=%E7%A9%BF%E8%B6%8A" class="k1">穿越</a><a href="/t/book/search/?query=%E9%87%8D%E7%94%9F" class="k2">重生</a><a href="/t/book/search/?query=%E6%80%BB%E8%A3%81" class="k3">总裁</a><a href="/t/book/search/?query=%E7%BE%8E%E5%A5%B3" class="k4">美女</a><a href="/t/book/search/?query=%E6%90%9E%E7%AC%91" class="k5">搞笑</a><a href="/t/book/search/?query=%E4%BF%AE%E7%9C%9F" class="k6">修真</a><a href="/t/book/search/?query=%E6%9E%81%E5%93%81" class="k7">极品</a><a href="/t/book/search/?query=%E7%83%AD%E8%A1%80" class="k8">热血</a><a href="/t/book/search/?query=%E8%99%90%E5%BF%83" class="k9">虐心</a><a href="/t/book/search/?query=%E5%A5%87%E5%B9%BB" class="k10">奇幻</a><a href="/t/book/search/?query=%E5%86%9B%E4%BA%8B" class="k11">军事</a><a href="/t/book/search/?query=%E8%B1%AA%E9%97%A8" class="k12">豪门</a><a href="/t/book/search/?query=%E6%9E%81%E5%93%81" class="k13">极品</a><a href="/t/book/search/?query=YY" class="k14">YY</a><a href="/t/book/search/?query=%E6%9A%A7%E6%98%A7" class="k15">暧昧</a><a href="/t/book/search/?query=%E5%8D%87%E7%BA%A7" class="k16">升级</a><a href="/t/book/search/?query=%E5%A5%B3%E7%94%9F" class="k17">女生</a><a href="/t/book/search/?query=%E7%95%85%E9%94%80" class="k18">畅销</a><a href="/t/book/search/?query=%E4%BF%AE%E7%9C%9F" class="k19">修真</a><a href="/t/book/search/?query=%E8%87%B3%E5%B0%8A" class="k20">至尊</a></section>
    <div class="blockContainer">
        <nav class="p4">
            <article class="menu ft24">
                <article class="fl title c_gray">精品书籍</article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_gray current">全本</a> <a href="javascript:;" class="c_gray ml_25">免费</a>
                    <article class="mark_line line"></article>
                </article>
            </article>
        </nav>
        <div class="touchblock ani">
            <section class="p5 ft24 c3 pt fineBooks">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/350051/" class="c3 title">独步仙道:九州仙魔志</a> </li>
                    <li class=""><a href="/t/book/350643/" class="c3 title">潜规则:恶魔的兼职情人</a> </li>
                    <li class=""><a href="/t/book/362406/" class="c3 title">诱爱女仆:杠上恶魔少爷</a> </li>
                    <li class=""><a href="/t/book/363235/" class="c3 title">废柴嫡女蜕变:盛世风华</a> </li>
                    <li class="bor_b_n"><a href="/t/book/356945/" class="c3 title">骗子有文化:都市风水师</a> </li>
                </ul>
            </section>
            <section class="p5 ft24 c3 pt fineBooks">
                <ul>
                    <li class="bor_t_n"><a href="/t/book/546/" class="c3 title">复仇的女神</a> </li>
                    <li class=""><a href="/t/book/385/" class="c3 title">经济学原理</a> </li>
                    <li class=""><a href="/t/book/2320/" class="c3 title">恋爱中的女人</a> </li>
                    <li class=""><a href="/t/book/817/" class="c3 title">厚黑学</a> </li>
                    <li class="bor_b_n"><a href="/t/book/929/" class="c3 title">第三个女郎</a> </li>
                </ul>
            </section>
        </div>
    </div>
    <div class="ban_bor">
        <a href="http://t.tadu.com/t/book/351423/">
            <img src="http://media.tadu.com/7/d/a/5/7da5151e0c7648b6958e5d0b1831da1c.tmp" width="480" height="199"></a>
    </div>
    <div class="blockContainer">
        <nav class="p4">
            <article class="menu ft24">
                <article class="fl title c_gray">畅销榜 </article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_gray current">周榜</a> <a href="javascript:;" class="ml_25 c_gray ">月榜</a> <a href="javascript:;" class="c_gray ml_25">总榜</a>
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
                    <a href="/t/rank/all/sale/week/">
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
    <div class="blockContainer">
        <nav class="p4 mt_25">
            <article class="menu ft24">
                <article class="fl title c_gray">打赏榜 </article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_gray current">周榜</a> <a href="javascript:;" class="ml_25 c_gray ">月榜</a> <a href="javascript:;" class="c_gray ml_25">总榜</a>
                    <article class="mark_line line2"></article>
                </article>
            </article>
        </nav>
        <div class="touchblock ani">
            <section class="p8 ft24">
                <ul class="li_b">
                    <li class="li_t"><a href="/t/book/351589/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/366302/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">纯阳武圣<span class="title_b">(黑袍老祖)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/361512/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">不灭元神<span class="title_b">(百世经纶)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/366298/"><span class="num num_c ft18 fl">4</span><span class="fl title">娇妻太凶猛<span class="title_b">(炼狱)</span></span><article class="clear"></article>
                    </a></li>
                    <li class="li_b"><a href="/t/book/366303/"><span class="num num_c ft18 fl">5</span><span class="fl title">淑女攻略<span class="title_b">(凰女)</span></span><article class="clear"></article>
                    </a></li>
                </ul>
                <article class="more">
                    <a href="/t/rank/all/tip/week/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p8 ft24">
                <ul class="li_b">
                    <li class="li_t"><a href="/t/book/351589/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/366302/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">纯阳武圣<span class="title_b">(黑袍老祖)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/361512/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">不灭元神<span class="title_b">(百世经纶)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/366298/"><span class="num num_c ft18 fl">4</span><span class="fl title">娇妻太凶猛<span class="title_b">(炼狱)</span></span><article class="clear"></article>
                    </a></li>
                    <li class="li_b"><a href="/t/book/366303/"><span class="num num_c ft18 fl">5</span><span class="fl title">淑女攻略<span class="title_b">(凰女)</span></span><article class="clear"></article>
                    </a></li>
                </ul>
                <article class="more">
                    <a href="/t/rank/all/tip/month/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p8 ft24">
                <ul class="li_b">
                    <li class="li_t"><a href="/t/book/361512/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">不灭元神<span class="title_b">(百世经纶)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/364771/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">仙国大帝<span class="title_b">(观棋)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/352453/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">仙家<span class="title_b">(龙马)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/351589/"><span class="num num_c ft18 fl">4</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                    </a></li>
                    <li class="li_b"><a href="/t/book/351193/"><span class="num num_c ft18 fl">5</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                    </a></li>
                </ul>
                <article class="more">
                    <a href="/t/rank/all/tip/total/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
        </div>
    </div>
    <div class="blockContainer">
        <nav class="p4 mt_25">
            <article class="menu ft24">
                <article class="fl title c_gray">人气榜 </article>
                <article class="fr mark">
                    <a href="javascript:;" class="c_gray current">周榜</a> <a href="javascript:;" class="ml_25 c_gray ">月榜</a> <a href="javascript:;" class="c_gray ml_25">总榜</a>
                    <article class="mark_line line2"></article>
                </article>
            </article>
        </nav>
        <div class="touchblock ani">
            <section class="p8 ft24">
                <ul class="li_b">
                    <li class="li_t"><a href="/t/book/366298/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">娇妻太凶猛<span class="title_b">(炼狱)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/351193/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/351510/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">特种兵痞在校园<span class="title_b">(艾连)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/349022/"><span class="num num_c ft18 fl">4</span><span class="fl title">六欲仙缘<span class="title_b">(飞舞激扬)</span></span><article class="clear"></article>
                    </a></li>
                    <li class="li_b"><a href="/t/book/365550/"><span class="num num_c ft18 fl">5</span><span class="fl title">我的合租情人<span class="title_b">(坐墙等红杏)</span></span><article class="clear"></article>
                    </a></li>
                </ul>
                <article class="more">
                    <a href="/t/rank/all/popularity/week/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p8 ft24">
                <ul class="li_b">
                    <li class="li_t"><a href="/t/book/366298/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">娇妻太凶猛<span class="title_b">(炼狱)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/351193/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/366306/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">迷情女总裁<span class="title_b">(王小六)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/366300/"><span class="num num_c ft18 fl">4</span><span class="fl title">谁动了我的前夫<span class="title_b">(清凉如意)</span></span><article class="clear"></article>
                    </a></li>
                    <li class="li_b"><a href="/t/book/351589/"><span class="num num_c ft18 fl">5</span><span class="fl title">兽破苍穹<span class="title_b">(妖夜)</span></span><article class="clear"></article>
                    </a></li>
                </ul>
                <article class="more">
                    <a href="/t/rank/all/popularity/month/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
            <section class="p8 ft24">
                <ul class="li_b">
                    <li class="li_t"><a href="/t/book/349022/"><span class="num num_c1 ft18 fl">1</span><span class="fl title">六欲仙缘<span class="title_b">(飞舞激扬)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/349006/"><span class="num num_c2 ft18 fl">2</span><span class="fl title">护花高手在都市<span class="title_b">(心在流浪)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/351193/"><span class="num num_c3 ft18 fl">3</span><span class="fl title">妖孽保镖<span class="title_b">(青狐妖)</span></span><article class="clear"></article>
                    </a></li>
                    <li class=""><a href="/t/book/351253/"><span class="num num_c ft18 fl">4</span><span class="fl title">透视之眼<span class="title_b">(星辉)</span></span><article class="clear"></article>
                    </a></li>
                    <li class="li_b"><a href="/t/book/350632/"><span class="num num_c ft18 fl">5</span><span class="fl title">全职房东<span class="title_b">(穿衣服的国宝)</span></span><article class="clear"></article>
                    </a></li>
                </ul>
                <article class="more">
                    <a href="/t/rank/all/popularity/total/">
                        <button class="more_btn ft24 c3">更多 </button>
                    </a>
                </article>
            </section>
        </div>
    </div>
    <div class="b_return"><a href="#body" class="ft24 ret_btn"><span class="b_return_i">︽</span>回顶部 </a></div>
    <div id="loading" style="position: fixed; top: 50%; left: 50%; margin-top: -50px; margin-left: -50px; border-radius: 5px; z-index: 1000; display: none;">
        <img src="/images/touch/v1/loading.gif" style="margin-top: 10%;">
    </div>
    <footer class="mt_20">
        <section class="p9">
            <article></article>
            <nav class="wap">请在wifi或3G下浏览(<a href="http://wap.tadu.com" alt="wap.tadu.com">点此访问简版</a>) </nav>
            <nav>
                <ul>
                    <li><a href="/t/index/">首页</a><span class="line dot"></span> </li>
                    <li id="footZoneLi" link="/t/user/space/">空间<span class="line dot"></span> </li>
                    <li id="footBookshelfLi" link="/t/user/history/"><a>书架</a><span class="line dot"></span> </li>
                    <li><a href="/t/recharge/">充值</a> </li>
                </ul>
                <ul>
                    <li><a href="/t/copyright/">声明</a><span class="line"></span> </li>
                    <li><a href="/t/feedback/">建议</a><span class="line"></span> </li>
                    <li><a href="/t/service/">客服</a><span class="line"></span> </li>
                    <li><a href="/t/help/">帮助</a> </li>
                </ul>
            </nav>
            <footer>
                <p>塔读tadu.com&nbsp;<span id="time"></span> </p>
                <p>京ICP备09017823号 </p>
            </footer>
        </section>
    </footer>
  </asp:Content>
