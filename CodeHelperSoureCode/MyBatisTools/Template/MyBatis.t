T_format:$tableMap.config
T_template:<?xml version="1.0" encoding="utf-8" ?>
<!--namespace必须用否者就报错（读取配置文件报：未将对象引用设置到对象的实例）-->
<sqlMap namespace="$namespace.$tableMap" xmlns="http://ibatis.apache.org/mapping" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <alias>
    <typeAlias alias="$tableMapInfo" type="$className,$namespace" />
  </alias>
  <resultMaps>
    <resultMap id="$tableMapInfo_Result" class="$tableMapInfo" >
$Info_Para
    </resultMap> 
  </resultMaps> 	
	<statements>
        <select id="Get$tableMapById" parameterClass="$tableMapInfo" resultMap="$tableMapInfo_Result">
            SELECT * FROM $table WHERE $id=#$id#
        </select>
        <insert id="Insert$tableMap" parameterClass="$tableMapInfo">
           $insert
        </insert>
        <delete id="Delete$tableMap" parameterClass="$tableMapInfo" restultClass="int">
            DELETE FROM $table WHERE $id=#$id#
        </delete>
        <update id="Update$tableMap" parameterClass="$tableMapInfo" restltClass="int">
            $update
        </update>
        <select id="Get$tableMapAll" resultClass="$tableMapInfo">
            SELECT * FROM $table
        </select>   
		<select id="Get$tableMapInfo" parameterClass="$tableMapInfo" resultClass="$tableMapInfo">
            SELECT * FROM $table
			 <dynamic prepend="where">
$where
           </dynamic> 
        </select> 
	    <procedure id="Get$tableMapPagingList"  parameterMap="PagingModel" resultMap="$tableMapInfo_Result">
           spPageViewByStr
        </procedure>
    </statements>
</sqlMap>
T_infodata:$table|$id|$insert|$update|