在web.config添加如下配置节：

<httpHandlers>
   <add verb="*" path="*.aspx" 
        type=" GY.Core.Web.URLRewriter.RewriterFactoryHandler,GY.Core" />
</httpHandlers>


然后按照如下格式，在wen.config中写入要重写的url的规则：

<RewriterConfig>
   <Rules>
     <RewriterRule>
            <LookFor>~/Products/Default/.aspx</LookFor>
            <SendTo>~/ListCategories.aspx</SendTo>
      </RewriterRule>
      <RewriterRule>
         <LookFor>~/Products/Beverages_(/d{1,4})/.aspx</LookFor>
         <SendTo>~/ListProductsByCategory.aspx?CategoryID=$1</SendTo>
      </RewriterRule>
      <RewriterRule>
   </Rules>
</RewriterConfig>

上例中得表达式一个是不带参数的重写，一个是带参数的，

带参数的~/Products/Beverages_(/d{1,4})/.aspx中 _(/d{1,4}) 是规则表达式，只要符合这个规则的网页，

会转发到下边的~/ListProductsByCategory.aspx?CategoryID=$1

这个网址其中，$1会接收到 (/d{1,4}) 规则表达式相对应的参数的具体值。从而达到转发的目的。